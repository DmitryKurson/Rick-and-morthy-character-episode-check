using Microsoft.AspNetCore.Mvc;

namespace Rick_and_morthy_character_episode_check.Controllers
{
    public class CharacterInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
