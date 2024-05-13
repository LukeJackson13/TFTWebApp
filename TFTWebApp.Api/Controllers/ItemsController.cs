using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TFTWebApp.Core.Models;
using TFTWebApp.Api.Helper;
using TFTWebApp.Core.Constants;
using System.ComponentModel;

namespace TFTWebApp.Api.Controllers;

    [ApiController]
    [Route("items")]
    public class ItemsController : Controller
    {
        [Route("")]
        [HttpGet]
        public string GetAllItems()
        {
            using (StreamReader reader = new StreamReader("Data/TFTData.json"))
            {
                var jsonTFTData = reader.ReadToEnd();
                var data = JsonSerializer.Deserialize<TFTData>(jsonTFTData);

                var jsonAllItems = data
                    .items
                    .Where(x => (x.apiName.Contains("TFT_Item_") || x.apiName.Contains("TFT11_Item")) && !string.IsNullOrEmpty(x.name))
                    .Where(x => !x.apiName.Contains("TFT_Item_FreeDeathblade") && !x.apiName.Contains("TFT_Item_SeraphsEmbrace") && !x.apiName.Contains("TFT_Item_FreeBFSword"))
                    .Where(x => TFTWebApp.Core.Constants.Constant.combinedItemNames.Any(name => x.name.Contains(name)) || TFTWebApp.Core.Constants.Constant.Components.Any(component => (x.name.Replace("'", "").Replace(" ", "").Replace(".", "")).IndexOf(component, StringComparison.OrdinalIgnoreCase) >= 0))
                    .GroupBy(x => x.name)
                    .Select(g => g.First())
                    .Take(60);

                var itemsData = jsonAllItems.Select(x => x.ToItems());

                return JsonSerializer.Serialize(itemsData);
            }
        }
    }
