using Microsoft.AspNetCore.Mvc;
using Rick_and_morthy_character_episode_check.Models;
using System.Diagnostics;

namespace Rick_and_morthy_character_episode_check.Controllers
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

        public IActionResult CharacterInfo()
        {
            return View();
        }
        public IActionResult CharacterEpisodeCheck()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}