using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using waifu_simulator.Utils.DTOs;

namespace waifu_simulator.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WaifuGenerator : ControllerBase
{
    private static readonly List<Waifu> Waifus = new List<Waifu>
        {
            new Waifu
            {
                Name = "Makima",
                Anime = "Chainsaw Man",
                Opinion = "Becoming IShowSpeed and start barking"
            },
            new Waifu
            {
                Name = "Venti",
                Anime = "Genshin Impact",
                Opinion = "Best girl no doubt"
            },
            new Waifu
            {
                Name = "Mona",
                Anime = "Genshin Impact",
                Opinion = "I used to fap to her creampie hentai 10x times per day"
            },
            new Waifu{
                Name = "Raiden Shogun",
                Anime = "Genshin Impact",
                Opinion = "HER HENTAI IS SOO GOOD WTF"
            },
            new Waifu{
                Name = "Sparkle",
                Anime = "Honkai star rail",
                Opinion = "Sex now Sex now Sex now"
            }
        };
    [HttpGet("{anime}")]
    public ActionResult<Waifu> GetWaifuByAnime(string anime)
    {
        if(anime == "Honkshin starbuck"){
            return Ok(Waifus[4]);
        }

        var waifusFromAnime = Waifus.Where(w => w.Anime.ToLower() == anime.ToLower()).ToList();

        if (waifusFromAnime.Any())
        {
            var randomWaifu = waifusFromAnime[new Random().Next(waifusFromAnime.Count)];
            return Ok(randomWaifu);
        }

        return NotFound($"No waifus found for anime '{anime}'.");
    }
}