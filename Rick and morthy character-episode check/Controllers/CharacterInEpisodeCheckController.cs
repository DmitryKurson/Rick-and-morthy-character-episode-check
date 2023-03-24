using Rick_and_morthy_character_episode_check.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Rick_and_morthy_character_episode_check.Controllers
{
    public class CharacterInEpisodeCheckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(CharacterInEpisodeCheck obj)
        {
            if (ModelState.IsValid)
            {
                Rootobject r = new Rootobject();
                //r.episode = Episode.GetEpisode();
                //r.character = Character.GetCharacters();
                //Console.WriteLine(r.character.Length);
                //Console.WriteLine(r.episode.Length);
                
                //for (int i = 0; i < r.episode.Length; i++)
                //{
                //    if (r.episode[i].name == obj.episode_name)
                //    {
                //        if (r.episode[i].characters.Contains(obj.character_name))
                //        {
                //            Console.WriteLine("true");
                //        }
                //        else
                //        {
                //            Console.WriteLine("false");
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("no");
                //    }
                //}                
            }
            return View("Index");
        }
    }
}
