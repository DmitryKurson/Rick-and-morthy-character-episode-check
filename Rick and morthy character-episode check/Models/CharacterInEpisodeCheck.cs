using System.ComponentModel.DataAnnotations;
namespace Rick_and_morthy_character_episode_check.Models
{
    public class CharacterInEpisodeCheck
    {
        [Display(Name = "Введіть ім'я персонажа:")]
        [Required(ErrorMessage = "Будь ласка, введіть ім'я персонажа")]
        public string character_name { get; set; }
        [Display(Name = "Введіть назву епізоду:")]
        [Required(ErrorMessage = "Будь ласка, введіть назву епізоду")]
        public string episode_name { get; set; }

        //public static CharacterInEpisodeCheck[] GetData()
        //{
        //    var client = new RestClient("https://cryptingup.com/api/");
        //    var request = new RestRequest("assets");
        //    var response = client.Execute(request);
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        string rawResponse = response.Content;
        //        Rootobject result = JsonConvert.DeserializeObject<Rootobject>(rawResponse);
        //        return result.assets;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}
