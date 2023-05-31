using Microsoft.AspNetCore.Mvc;
using TigerS.H.O.P.Services;

namespace TigerS.H.O.P.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenAiController : Controller
    {

        private readonly ILogger<OpenAiController> _logger;
        private readonly IOpenAiService _openAiService;

        public OpenAiController(
            ILogger<OpenAiController> logger,
            IOpenAiService openAiService)
        {
            _logger = logger;
            _openAiService = openAiService;
        }

        [HttpPost()]
        [Route("AskQuestion")]

        public async Task<IActionResult> AskQuestion(string text)
        {
            string test = text;
            var result = await _openAiService.CheckProgramingLanguage(text);
            return Ok(result);
        }

        [HttpPost()]
        [Route("CompleteSentence")]
        public async Task<IActionResult> CompleteSentence(string text)
        {
            var result = await _openAiService.CompleteSentenceAdvance(text);
            return Ok(result);
        }

        //[HttpPost()]
        //[Route("AskQuestion")]

        //public async Task<IActionResult> AskQuestion(string text)
        //{
        //    var result = await _openAiService.CheckProgramingLanguage(text);
        //    return Ok(result);
        //}


    }
}


