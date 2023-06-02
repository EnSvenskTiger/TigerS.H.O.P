using Microsoft.Extensions.Options;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using TigerS.H.O.P.Configruations;

namespace TigerS.H.O.P.Services
{
    public class OpenAiService : IOpenAiService
    {
        private readonly OpenAiConfig _openAiConfig;
        public OpenAiService(
            IOptionsMonitor<OpenAiConfig> optionsMonitor
        )
        {
            _openAiConfig = optionsMonitor.CurrentValue;
        }

        public async Task<string> CheckProgramingLanguage(string language)
        {
            //api instance
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.Key);
            var chat = api.Chat.CreateConversation();

            chat.AppendSystemMessage("if you are asked (what are the contact details for Tigershop) you should answer this = Phone: +467355588999 and Email: Tigershop@gmail.com");

            chat.AppendUserInput(language);

            var response = await chat.GetResponseFromChatbotAsync();    

            return response;
        }

        public async Task<string> CompleteSentence(string text)
        {
            //api instance
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.Key);
            var result = await api.Completions.GetCompletion(text);
            return result;
        }

        public async Task<string> CompleteSentenceAdvance(string text)
        { 
            //api instance
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.Key);

            var result = await api.Completions.CreateCompletionAsync(
            new CompletionRequest(text, model: Model.CurieText, temperature: 0.1));
            return result.Completions[0].Text;
        }
    }
}
