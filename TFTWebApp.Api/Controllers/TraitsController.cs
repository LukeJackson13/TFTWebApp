using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TFTWebApp.Api.Helper;
using TFTWebApp.Core.Models;

namespace TFTWebApp.Api.Controllers;

[ApiController]
[Route("traits")]
public class TraitsController : Controller
{
    [Route("")]
    [HttpGet]
    public string GetAllTraits()
    {
        using (StreamReader reader = new StreamReader("Data/champs-set-11.json"))
        {
            var jsonTFTData = reader.ReadToEnd();
            var data = JsonSerializer.Deserialize<TFTData>(jsonTFTData);

            var teambuilderChampiondata = data
                .setData
                .First(x => x.number == 11)
                .traits;

            var teambuilderChampionData = teambuilderChampiondata.Select(x => x.ToTraitBreakpoint());

            return JsonSerializer.Serialize(teambuilderChampionData);
        }
    }
}