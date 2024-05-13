using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TFTWebApp.Api.Helper;
using TFTWebApp.Core.Models;

namespace TFTWebApp.Api.Controllers;

[ApiController]
[Route("teamBuilder")]
public class TeamBuilderController : Controller
{
    [Route("")]
    [HttpGet]
    public string GetAllChampions()
    {
        using (StreamReader reader = new StreamReader("Data/TFTData.json"))
        {
            var jsonTFTData = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<TFTData>(jsonTFTData);

            var teambuilderChampiondata = data
                .setData
                .First(x => x.number == 11)
                .champions.OrderBy(x => x.cost)
                .Where(x => x.name != "Tibbers" && x.name != "Voidspawn" && x.name != "Target Dummy")
                .Take(60);

            var teambuilderChampionData = teambuilderChampiondata.Select(x => x.ToChampion());

            return JsonSerializer.Serialize(teambuilderChampionData);
        }
    }

    [Route("traits")]
    [HttpGet]
    public string GetAllTraits()
    {
        using (StreamReader reader = new StreamReader("Data/TFTData.json"))
        {
            var jsonTFTData = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<TFTData>(jsonTFTData);

            var teambuilderChampiondata = data
                .setData
                .First(x => x.number == 11)
                .traits
                .Take(60);

            var teambuilderChampionData = teambuilderChampiondata.Select(x => x.ToTraitBreakpoint());

            return JsonSerializer.Serialize(teambuilderChampionData);
        }
    }
}