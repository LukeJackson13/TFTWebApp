using System.Diagnostics;
using System.Text.RegularExpressions;
using TFTWebApp.Core.Models;

namespace TFTWebApp.Services
{
    public class ItemDescriptionParser
    {
        public static void ParseItem(Item item)
        {
            var itemDescription = Regex.Replace(item.Description, "<[^>]*>", string.Empty);
            itemDescription = Regex.Replace(itemDescription, @"@TFTUnitProperty.*?@", string.Empty);
            var atRegex = new Regex("@(.*?)@");
            var atTags = atRegex.Matches(itemDescription).Select(x => x.ToString().Replace("@", "")).ToList();

            if (itemDescription.Contains("&nbsp;"))
            {
                itemDescription = itemDescription.Replace("&nbsp;", " ");
            }
            if (itemDescription.Contains("[Unique - only 1 per champion]"))
            {
                itemDescription = itemDescription.Replace("[Unique - only 1 per champion]", " ");
            }

            foreach (var atTag in atTags)
            {
                string stringValues = "";
                int multiplier = 1;
                var currentTag = atTag;

                if (atTag.Contains("100"))
                {
                    multiplier = 100;
                    currentTag = currentTag.Replace("*100", "");
                }

                var property = item.Effects.GetType().GetProperty(currentTag);
                if (property != null)
                {
                    object propertyValue = property.GetValue(item.Effects);

                    float value = propertyValue?.ToString() == "null" ? 0 : float.Parse(propertyValue.ToString());

                    stringValues += ((int)(value * multiplier)).ToString();
                }

                itemDescription = itemDescription.Replace($"@{atTag}@", $"{stringValues}"); ;

            }
            item.Description = itemDescription;
        }
    }
}
