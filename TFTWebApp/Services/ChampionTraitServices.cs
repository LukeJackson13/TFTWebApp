using TFTWebApp.Core.Models;

namespace TFTWebApp.Services
{
    public class ChampionTraitServices
    {
        public static string GetChampionTraits(Champion champion)
        {
            return string.Join(", ", champion.Traits.Select(x => x.Name));
        }

        public static List<int> TraitBreakpoints(TraitBreakpoint trait)
        {
            List<int> breakpoints = [];

            foreach (var effect in trait.Effects)
            {
                breakpoints.Add(effect.MinUnits);
            }

            return breakpoints;
        }
    }
}
