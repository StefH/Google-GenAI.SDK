# ![Logo](./resources/logo_32x32.png) Google GenAI .NET SDK
Unofficial [RestEase](https://github.com/canton7/RestEase) C# Client for [Google Gemini](https://ai.google.dev/gemini-api/docs).

## 📦 Google-GenAI.SDK
[![NuGet Badge](https://img.shields.io/nuget/v/Google-GenAI.SDK)](https://www.nuget.org/packages/Google-GenAI.SDK)<br>

## ⭐ Usage

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
var api = serviceProvider.GetRequiredService<IGenerativeLanguageApi>();

var result = await api.GenerateContentAsync("gemini-2.0-flash", new GenerateContentRequest
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