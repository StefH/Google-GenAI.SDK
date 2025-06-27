using GoogleGenAI.SDK.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GoogleGenAI.SDK.ConsoleApp;

internal class Worker(IGenerativeLanguageApi api, ILogger<Worker> logger)
{
    public async Task RunAsync(CancellationToken cancellationToken = default)
    {
        var contentResponse = await api.GenerateContentAsync("gemini-2.0-flash", new GenerateContentRequest
        {
            Contents =
            [
                new Content
                {
                    Parts =
                    [
                        new Part
                        {
                            Text = "Explain how AI works in a few words"
                        }
                    ]
                }
            ]
        }, cancellationToken: cancellationToken);
        logger.LogInformation("response: {response}", ToJson(contentResponse));

        var embedResponse = await api.EmbedContentAsync("gemini-embedding-exp-03-07", new EmbedContentRequest
        {
            Content = new Content
            {
                Parts =
                [
                    new Part
                    {
                        Text = "AI"
                    }
                ]
            }
        }, cancellationToken: cancellationToken);
        logger.LogInformation("response: {response}", ToJson(embedResponse));
    }

    private static string ToJson(object value)
    {
        return JsonConvert.SerializeObject(value, Formatting.Indented);
    }
}