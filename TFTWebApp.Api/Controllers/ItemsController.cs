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
            using (StreamReader reader = new StreamReader("Data/items-set-11.json"))
            {
                var jsonTFTData = reader.ReadToEnd();
                var data = JsonSerializer.Deserialize<TFTData>(jsonTFTData);

            var jsonAllItems = data
                .items;

                var itemsData = jsonAllItems.Select(x => x.ToItems());

                return JsonSerializer.Serialize(itemsData);
            }
        }
    }
