using System.Collections.Generic;
using System.Linq;
using PotionsMaker.Models;

namespace PotionsMaker 
{
    public class PotionController
    {
        static public void SetStats(Potion potion)
        {
            foreach (Ingredient ingredient in potion.Ingredients)
            {
                potion.Stats["Toxicité"] += ingredient.Toxicity;
                potion.Stats["Soin"] += ingredient.Soin;
                potion.Stats["Amour"] += ingredient.Amour;
                potion.Stats["Puissance"] += ingredient.Puissance;
                potion.Stats["Mana"] += ingredient.Mana;
                potion.Stats["Intelligence"] += ingredient.Intelligence;
                potion.Stats["Agilité"] += ingredient.Agilite;
            }
        }
        static public Dictionary<string, int?> GetMaxStats(Potion potion)
        {
            SetStats(potion);
            Dictionary<string, int?> sortedStats = potion.Stats.OrderByDescending( s => s.Value).ToDictionary(p => p.Key, p => p.Value);
            return sortedStats;
        }
    }
}