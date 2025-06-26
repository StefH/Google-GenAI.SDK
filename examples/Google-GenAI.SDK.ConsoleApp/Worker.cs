using GoogleGenAI.SDK;
using GoogleGenAI.SDK.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace n8n.SDK.ConsoleApp;

internal class Worker(IGoogleGeminiApi api, ILogger<Worker> logger)
{
    public async Task RunAsync(CancellationToken cancellationToken = default)
    {
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
        logger.LogInformation("result: {result}", ToJson(result));
    }

    private static string ToJson(object value)
    {
        return JsonConvert.SerializeObject(value, Formatting.Indented);
    }
}