using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TFTWebApp.Api.Helper;
using TFTWebApp.Core.Models;
using TFTWebApp.infrastructure;

namespace TFTWebApp.Api.Controllers
{
    [ApiController]
    [Route("champions")]
    public class ChampionsController : ControllerBase
    {
        private readonly ILogger<ChampionsController> _logger;

        private readonly TFTContext _context;

        public ChampionsController(ILogger<ChampionsController> logger, TFTContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("{championName}")]
        [HttpGet]
        public string GetChampion(string championName)
        {
            var existingchampion = _context.Champions
                .Include(champion => champion.Ability)
                .Include(champion => champion.Stats)
                .Include(champion => champion.Ability.Variables)
                .Include(champion => champion.Traits)
                .SingleOrDefault(x => x.Name.Replace("'","").Replace(" ", "") == championName);
                
            if (existingchampion is not null)
            {
                return JsonSerializer.Serialize(existingchampion);
            }

            using (StreamReader reader = new StreamReader("Data/champs-set-11.json"))
            {
                var jsonTFTData = reader.ReadToEnd();
                var data = JsonSerializer.Deserialize<TFTData>(jsonTFTData);

                var jsonChampion = data
                    .setData
                    .First(x => x.number == 11)
                    .champions
                    .FirstOrDefault(x =>
                        x?.name is not null &&
                        string.Equals(championName, x.name.Replace("'","").Replace(" ", ""), StringComparison.InvariantCultureIgnoreCase)) ;

                if (jsonChampion == null)
                {
                    return "Champion not found";
                }

                 var champion = jsonChampion.ToChampion();

                _context.Abilities.Add(champion.Ability);
                _context.Champions.Add(champion);
                _context.ChampionStats.Add(champion.Stats);

                _context.SaveChanges();

                return JsonSerializer.Serialize(champion);
            }
        }
        
        [Route("all")]
        [HttpGet]
        public string GetAllChampions()
        {
            using (StreamReader reader = new StreamReader("Data/champs-set-11.json"))
            {
                var jsonTFTData = reader.ReadToEnd();
                var data = JsonSerializer.Deserialize<TFTData>(jsonTFTData);

                var pagedJsonChampionData = data
                    .setData
                    .First(x => x.number == 11)
                    .champions
                    .OrderBy(x => x.cost);

                var pagedChampionData = pagedJsonChampionData.Select(x => x.ToChampion());

                return JsonSerializer.Serialize(pagedChampionData);

            }
        }
    }
}
