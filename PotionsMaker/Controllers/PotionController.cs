using System;
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

                potion.Stats["Toxicité"] = (potion.Stats["Toxicité"].Item1 + ingredient.Toxicity, potion.Stats["Toxicité"].Item2);
                potion.Stats["Soin"] = (potion.Stats["Soin"].Item1 + ingredient.Soin, potion.Stats["Soin"].Item2);
                potion.Stats["Amour"] = (potion.Stats["Amour"].Item1 + ingredient.Amour, potion.Stats["Amour"].Item2);
                potion.Stats["Puissance"] = (potion.Stats["Puissance"].Item1 + ingredient.Puissance, potion.Stats["Puissance"].Item2);
                potion.Stats["Mana"] = (potion.Stats["Mana"].Item1 + ingredient.Mana, potion.Stats["Mana"].Item2);
                potion.Stats["Intelligence"] = (potion.Stats["Intelligence"].Item1 + ingredient.Intelligence, potion.Stats["Intelligence"].Item2);
                potion.Stats["Agilité"] = (potion.Stats["Agilité"].Item1 + ingredient.Agilite, potion.Stats["Agilité"].Item2);
            }
        }
        static public Dictionary<string, (int?, string)> GetMaxStats(Potion potion)
        {
            SetStats(potion);
            Dictionary<string, (int?, string)> sortedStats = potion.Stats.OrderByDescending( s => s.Value.Item1).ToDictionary(p => p.Key, p => p.Value);
            return sortedStats;
        }
        static public void GetMaxEffects(Potion potion) 
        {
            Dictionary<string, (int?, string)> sortedStats = GetMaxStats(potion);
            switch (sortedStats["Toxicité"].Item1)
            {
                

            }
        }
            
        
    }
}