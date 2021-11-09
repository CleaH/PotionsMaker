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
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        Potion currentPotion;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Ingredient> nosIngredients;
            using (PotionMakerContext db = new PotionMakerContext())
            {
                nosIngredients = db.Ingredients.ToList();
            }
            ViewData["Ingredients"] = nosIngredients;
            currentPotion = this.GetPotionFromCookies();
            currentPotion.Ingredients.Add(new Ingredient()
            {
                Nom = "test",
                IngredientId = 1,
            });
            SavePotionIntoCookies(currentPotion);
            Dictionary<Ingredient, int> listeIngCurrentPotion = ParsePotionIngredients();
            ViewBag.potion = currentPotion;
            ViewBag.listeIngredients = listeIngCurrentPotion;
            return View();
        }

        private Dictionary<Ingredient, int> ParsePotionIngredients()
        {
            Dictionary<Ingredient, int> listeIng = new Dictionary<Ingredient, int>();
            foreach (var ing in currentPotion.Ingredients)
            {
                if (!listeIng.ContainsKey(ing))
                {
                    listeIng.Add(ing, 1);
                }
                else
                {
                    listeIng[ing] = listeIng[ing] + 1;
                }
            }

            return listeIng;
        }

        public Potion GetPotionFromCookies()
        {
            Potion currentPotion;
            if (HttpContext.Session.GetObjectFromJson<Potion>("currentPotion") == null)
            {
                currentPotion = new Potion();
                HttpContext.Session.SetObjectAsJson("currentPotion", currentPotion);
            }
            else
            {
                currentPotion = HttpContext.Session.GetObjectFromJson<Potion>("currentPotion");
            }
            return currentPotion;
        }

        public void SavePotionIntoCookies(Potion potion)
        {
            HttpContext.Session.SetObjectAsJson("currentPotion", potion);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
