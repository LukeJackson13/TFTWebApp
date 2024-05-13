using TFTWebApp.Core.Models;

public static class ImageHelpers {

    public static string GetChampionIconUrl(Champion? champion){
        return champion is not null 
            ? $"background-image: url(\"img/champions/TFT11_{champion.Name.Replace("'", "").Replace(" ", "")}.TFT_Set11.png\"); background-repeat: no-repeat; background-size: 104px 60px;" 
            : string.Empty;
    }
}