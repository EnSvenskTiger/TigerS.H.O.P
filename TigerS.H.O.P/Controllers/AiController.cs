using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using TigerS.H.O.P.Models;

namespace TigerS.H.O.P.Controllers
{
    public class AiController : Controller
    {
        
        public IActionResult Index()
        {
            var UserInput = new StringViewModel();
            return View(UserInput);
        }
        [HttpPost]
        public async Task<IActionResult> Index(StringViewModel Input) 
        {
            string url = "https://localhost:7221/OpenAi/AskQuestion?text=contact%20details%20for%20Tigershop"; // byta när vi får Azure
            var ApiRequest = new
            {
                Input = Input.QuestionToAi
            };
            var ToString = JsonConvert.SerializeObject(ApiRequest);
            var InputString = new StringContent(ToString, Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            var Respons = await client.PostAsync($"{url}", InputString);
            var ApiAnwser = await Respons.Content.ReadAsStringAsync();
            Input.AiRespons= ApiAnwser;
            return View(Input);
        }
        public async Task<IActionResult> Ai(StringViewModel Input)
        {
            var ApiRequest = new
            {
                Input = Input.QuestionToAi
            };
            var ToString = JsonConvert.SerializeObject(ApiRequest);
            var InputString = new StringContent(ToString, Encoding.UTF8, "application/json");
            HttpClient client= new HttpClient();
            var Respons = await client.PostAsync("https://localhost:7221/OpenAi/AskQuestion?text=contact%20details%20for%20Tigershop", InputString);
            var ApiAnwser = await Respons.Content.ReadAsStringAsync();
            var Anwser = JsonConvert.DeserializeObject<StringViewModel>(ApiAnwser);
            return View(Anwser);
        }
    }
}
