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

        // Método para instânciar os detalhes de uma carta
        public IActionResult Card()
        {
            
            var card = new CardModel
            {
                Name = "Herigast, Nullkite em erupção\r\n",
                Type = "Criatura Lendária",
                Text = "Emergir{6}{R}{R} (Você pode conjurar esta mágica sacrificando uma criatura e pagando o custo de emergência reduzido pelo valor de mana daquela criatura.)\r\n\r\nAo lançar esta magia, você pode exilar sua mão. Se fizer isso, compre três cartas.\r\n\r\nVôo\r\n\r\nCada feitiço de criatura que você lança emerge. O custo de emergência é igual ao seu custo de mana",
                Stats = "6/6"
            };

            // Retorna a exibição com o modelo de carta
            return View(card);
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}