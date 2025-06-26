## Google GenAI .NET SDK
Unofficial [RestEase](https://github.com/canton7/RestEase) C# Client for [Google Gemini](https://ai.google.dev/gemini-api/docs).

### Register

``` c#
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .AddJsonFile("appsettings.Development.json", optional: true)
    .Build();

services.AddGoogleGeminiSDK(configuration);

var serviceProvider = services.BuildServiceProvider();
```

### Example

``` c#
var api = serviceProvider.GetRequiredService<IGoogleGeminiApi>();

var result = await api.GenerateContentAsync("gemini-2.0-flash", new GeminiRequest
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
}, cancellationToken); 
```