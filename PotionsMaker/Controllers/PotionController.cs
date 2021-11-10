using PotionsMaker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using PotionsMaker.Tools;


namespace PotionsMaker.Controllers
{
    public class PotionController : Controller
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

        public IActionResult Index()
        {
            return View();
        }


    }
}