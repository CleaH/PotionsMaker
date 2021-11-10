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
        List<Ingredient> nosIngredients;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (PotionMakerContext db = new PotionMakerContext())
            {
                nosIngredients = db.Ingredients.ToList();
            }
            ViewData["Ingredients"] = nosIngredients;
            currentPotion = GetPotionFromCookies();
            SavePotionIntoCookies(currentPotion);
            Dictionary<Ingredient, int> listeIngCurrentPotion = ParsePotionIngredients(currentPotion);
            ViewBag.potion = currentPotion;
            ViewBag.listeIngredients = listeIngCurrentPotion;
            return View();
        }



        private Dictionary<Ingredient, int> ParsePotionIngredients(Potion potion)
        {
            Dictionary<int, int> listeIngInt = new Dictionary<int, int>();
            foreach (var ing in potion.Ingredients)
            {
                if (!listeIngInt.ContainsKey(ing.IngredientId))
                {
                    listeIngInt.Add(ing.IngredientId, 1);
                }
                else
                {
                    listeIngInt[ing.IngredientId] = listeIngInt[ing.IngredientId] + 1;
                }
            }

            Dictionary<Ingredient, int> listeIng = new Dictionary<Ingredient, int>();
            foreach (KeyValuePair<int, int> item in listeIngInt)
            {

                listeIng.Add(nosIngredients.Where(ing => ing.IngredientId == item.Key).ToList()[0], item.Value);
            }

            return listeIng;
        }

        public Potion GetPotionFromCookies()
        {
            Potion cookiePotion;
            if (HttpContext.Session.GetObjectFromJson<Potion>("currentPotion") == null)
            {
                cookiePotion = new Potion();
                HttpContext.Session.SetObjectAsJson("currentPotion", currentPotion);
            }
            else
            {
                cookiePotion = HttpContext.Session.GetObjectFromJson<Potion>("currentPotion");
            }
            return cookiePotion;
        }

        public void SavePotionIntoCookies(Potion potion)
        {
            HttpContext.Session.SetObjectAsJson("currentPotion", potion);
        }

        public IActionResult ResetPotionIntoCookies()
        {
            currentPotion = new Potion();
            SavePotionIntoCookies(currentPotion);
            Dictionary<Ingredient, int> listeIngCurrentPotion = ParsePotionIngredients(currentPotion);
            ViewBag.potion = currentPotion;
            ViewBag.listeIngredients = listeIngCurrentPotion;
            return RedirectToAction("Index");
        }

        // implémenter méthode de calcul de potion en fonction des ingrédients
        //public IActionResult Test(string e)
        //{
        //    Console.WriteLine(e);
        //    return RedirectToAction("Index");
        //}

        public IActionResult AddIngredientToPotion(int ingredientId)
        {
            using (PotionMakerContext db = new PotionMakerContext())
            {
                nosIngredients = db.Ingredients.ToList();
            }
            Ingredient ingredient = nosIngredients.Where(ing => ing.IngredientId == ingredientId).ToList()[0];
            currentPotion = GetPotionFromCookies();
            if (currentPotion == null)
            {
                currentPotion = new Potion();
            }
            currentPotion.Ingredients.Add(ingredient);
            Dictionary<Ingredient, int> listeIngCurrentPotion = ParsePotionIngredients(currentPotion);

            Color ingColor = GetIngredientColor(ingredient);
            currentPotion.ActualColor = ColorTools.ChangeColor(ingColor, currentPotion.ActualColor);

            SavePotionIntoCookies(currentPotion);
            ViewBag.potion = currentPotion;
            ViewBag.listeIngredients = listeIngCurrentPotion;
            return RedirectToAction("Index");
        }

        private Color GetIngredientColor(Ingredient ing)
        {
            Color ingColor = new Color();
            ingColor = Color.FromArgb((int)ing.R, (int)ing.V, (int)ing.B);
            return ingColor;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
