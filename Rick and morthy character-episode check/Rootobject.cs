using Rick_and_morthy_character_episode_check.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rick_and_morthy_character_episode_check
{
    public class Rootobject
    {
        public List<Character> character { get; set; }// = Character.GetCharacters();
        public List<Episode> episode { get; set; } //= Episode.GetEpisode();
    }
}
