using TFTWebApp.Core.Models;

namespace TFTWebApp.Services
{
    public class ChampionNameService
    {
        public static string GetChampionName(Champion champion)
        {
            return champion.Name.Replace("'", "").Replace(" ", "");
        }
    }
}
