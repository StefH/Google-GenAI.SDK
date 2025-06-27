using GoogleGenAI.SDK;
using GoogleGenAI.SDK.Options;
using GoogleGenAI.SDK.RetryPolicies;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase.HttpClientFactory;
using Stef.Validation;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

[PublicAPI]
public static class ServiceCollectionExtensions
{
    // This regex pattern will match any part of a string that starts with "apikey=" (in a case-insensitive manner) followed by any number of characters that are not an ampersand.
    [RegexPattern]
    private const string RegexMatch = "(?i)key=[^&]*";
    private const string RegexReplacement = "key=***";

    public static IServiceCollection AddGoogleGeminiSDK(this IServiceCollection services, IConfiguration configuration)
    {
        Guard.NotNull(services);
        Guard.NotNull(configuration);

        return services.AddGoogleGeminiSDK(options =>
        {
            configuration.GetSection(nameof(GoogleGenAIOptions)).Bind(options);
        });
    }

    public static IServiceCollection AddGoogleGeminiSDK(this IServiceCollection services, IConfigurationSection section)
    {
        Guard.NotNull(services);
        Guard.NotNull(section);

        return services.AddGoogleGeminiSDK(section.Bind);
    }

    public static IServiceCollection AddGoogleGeminiSDK(this IServiceCollection services, Action<GoogleGenAIOptions> configureAction)
    {
        Guard.NotNull(services);
        Guard.NotNull(configureAction);

        var options = new GoogleGenAIOptions();
        configureAction(options);

        return services.AddGoogleGeminiSDK(options);
    }

    public static IServiceCollection AddGoogleGeminiSDK(this IServiceCollection services, GoogleGenAIOptions options)
    {
        Guard.NotNull(services);
        Guard.NotNull(options);

        var jsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

        if (string.IsNullOrEmpty(options.HttpClientName))
        {
            options.HttpClientName = nameof(IGenerativeLanguageApi);
        }

        services.AddOptionsWithDataAnnotationValidation(options);
        
        services
            .AddHttpClient(options.HttpClientName!, httpClient =>
            {
                httpClient.BaseAddress = options.BaseAddress;
                httpClient.Timeout = TimeSpan.FromSeconds(options.TimeoutInSeconds);
            })
            .AddPolicyHandler((serviceProvider, _) => HttpClientRetryPolicies.GetPolicy<IGenerativeLanguageApi>(serviceProvider, options.MaxRetries, options.HttpStatusCodesToRetry))
            .UseWithRestEaseClient(new UseWithRestEaseClientOptions<IGenerativeLanguageApi>
            {
                RestClientConfigurer = restClient => restClient.JsonSerializerSettings = jsonSerializerSettings,
                InstanceConfigurer = geminiApi =>
                {
                    geminiApi.Key = options.Key;
                }
            })
#if NET8_0_OR_GREATER
            .ConfigureSanitizedLogging(o => o.RequestUriReplacements.Add(RegexMatch, RegexReplacement))
#endif
            ;

#if !NET8_0_OR_GREATER
        services.UseSanitizedHttpLogger(o => o.RequestUriReplacements.Add(RegexMatch, RegexReplacement));
#endif

        return services;
    }
}