using GoogleGenAI.SDK;
using GoogleGenAI.SDK.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace n8n.SDK.ConsoleApp;

internal class Worker(IGenerativeLanguageApi api, ILogger<Worker> logger)
{
    public async Task RunAsync(CancellationToken cancellationToken = default)
    {
        var textResponse = await api.GenerateTextAsync("gemini-2.0-flash", new GenerateTextRequest
        {
            Prompt = new TextPrompt
            {
                Text = "Explain how AI works in a few words"
            }
        }, cancellationToken: cancellationToken);
        logger.LogInformation("result: {result}", ToJson(textResponse));

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
        logger.LogInformation("result: {result}", ToJson(contentResponse));
    }

    private static string ToJson(object value)
    {
        return JsonConvert.SerializeObject(value, Formatting.Indented);
    }
}