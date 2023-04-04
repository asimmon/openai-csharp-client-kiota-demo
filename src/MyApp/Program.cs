using Microsoft.Kiota.Http.HttpClientLibrary;
using MyApp.OpenAi;
using MyApp.OpenAi.Models;

Console.WriteLine("Enter your OpenAI API key:");
var apiKey = Console.ReadLine() ?? throw new InvalidOperationException("Could not read OpenAI API key");

var authProvider = new OpenAiAuthenticationProvider(apiKey);
var requestAdapter = new HttpClientRequestAdapter(authProvider);
var client = new OpenAiClient(requestAdapter);

var response = await client.Chat.Completions.PostAsync(new CreateChatCompletionRequest
{
    Model = "gpt-3.5-turbo",
    Messages = new List<ChatCompletionRequestMessage>
    {
        new ChatCompletionRequestMessage
        {
            Role = ChatCompletionRequestMessage_role.System,
            Content = "You are a helpful assistant."
        },
        new ChatCompletionRequestMessage
        {
            Role = ChatCompletionRequestMessage_role.User,
            Content = "Who won the world series in 2020?"
        },
        new ChatCompletionRequestMessage
        {
            Role = ChatCompletionRequestMessage_role.Assistant,
            Content = "The Los Angeles Dodgers won the World Series in 2020."
        },
        new ChatCompletionRequestMessage
        {
            Role = ChatCompletionRequestMessage_role.User,
            Content = "Where was it played?"
        }
    }
});

// Prints "The 2020 World Series was played at Globe Life Field in Arlington, Texas."
Console.WriteLine(response?.Choices?[0].Message?.Content);