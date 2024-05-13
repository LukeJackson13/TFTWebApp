using TFTWebApp.Core.Models;

namespace TFTWebApp.Services
{
    public class ImageServices
    {
        public static string GetTraitIconUrl(string traitValue)
        {
            return $"img/traitIcons/Trait_Icon_11_{traitValue}.TFT_Set11.png";
        }

        public static string GetIconColour(int traitNumber,string traitName, List<TraitBreakpoint> traitBreakpoints)
        {
            List<int> breakpoints = new List<int>();

            foreach (var trait in traitBreakpoints)
            {
                if(traitName == trait.Name)
                {
                    foreach ( var effect in trait.Effects)
                    {
                        breakpoints.Add(effect.MinUnits);
                    }
                }
            }
            if(traitName == "Heavenly")
            {
                if(traitNumber < 2)
                {
                    return "#71797E";
                }
                if (traitNumber < 4)
                {
                    return "#CD7F32";
                }
                if (traitNumber < 6)
                {
                    return "#C0C0C0";
                }
                if (traitNumber == 6)
                {
                    return "gold";
                }
                else
                {
                    return "#b9f2ff";
                }
            }
            else if(traitNumber < breakpoints[0])
            {
                return "#71797E";
            }
            else if( breakpoints[0] == 1|| traitNumber < breakpoints[1])
            {
                return "#CD7F32";
            }
            else if(traitNumber < breakpoints[2])
            {
                return "#C0C0C0";
            }
            else if (traitNumber < breakpoints[3])
            { 
                return "gold";
            }
            else
            {
                return "#b9f2ff";
            }
        }

        public static string GetChampionIconUrl(Champion champion)
        {
            var urlName = champion.Name.Replace("'", "").Replace(" ", "");
            return $"img/champions/TFT11_{urlName}.TFT_Set11.png"; ;
        }
    }
}
