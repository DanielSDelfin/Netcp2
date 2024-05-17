using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Netcp2.Models;
using System.Diagnostics;

namespace Netcp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // M�todo para inst�nciar os detalhes de uma carta
        public IActionResult Card()
        {
            
            var card = new CardModel
            {
                Name = "Herigast, Nullkite em erup��o\r\n",
                Type = "Criatura Lend�ria",
                Text = "Emergir{6}{R}{R} (Voc� pode conjurar esta m�gica sacrificando uma criatura e pagando o custo de emerg�ncia reduzido pelo valor de mana daquela criatura.)\r\n\r\nAo lan�ar esta magia, voc� pode exilar sua m�o. Se fizer isso, compre tr�s cartas.\r\n\r\nV�o\r\n\r\nCada feiti�o de criatura que voc� lan�a emerge. O custo de emerg�ncia � igual ao seu custo de mana",
                Stats = "6/6"
            };

            // Retorna a exibi��o com o modelo de carta
            return View(card);
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}