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

            using (StreamReader reader = new StreamReader("Data/TFTData.json"))
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
        
        [Route("all/{page}/{pageSize}")]
        [HttpGet]
        public string GetChampionsPageSize(int page, int pageSize)
        {
            using (StreamReader reader = new StreamReader("Data/TFTData.json"))
            {
                var jsonTFTData = reader.ReadToEnd();
                var data = JsonSerializer.Deserialize<TFTData>(jsonTFTData);

                var pagedJsonChampionData = data
                    .setData
                    .First(x => x.number == 11)
                    .champions
                    .Where(x => x.name != "Tibbers" && x.name != "Voidspawn" && x.name != "Target Dummy")
                    .OrderBy(x => x.cost)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize);

                var pagedChampionData = pagedJsonChampionData.Select(x => x.ToChampion());

                return JsonSerializer.Serialize(pagedChampionData);

            }
        }

        [Route("traits/{traitName}/description")]
        [HttpGet]
        public string GetTraitDescription(string traitName)
        {
            using var reader = new StreamReader("Data/TFTData.json");

            var jsonTFTData = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<TFTData>(jsonTFTData);

            var description = data.setData.First(x => x.number == 11).traits.FirstOrDefault(x => string.Equals(traitName, x.name, StringComparison.OrdinalIgnoreCase))?.desc ?? string.Empty;

            return description;
        }
    }
}
