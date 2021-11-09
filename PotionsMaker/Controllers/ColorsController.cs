using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using PotionsMaker.Tools;
using PotionsMaker.Models;


namespace PotionsMaker.Controllers
{
    public class ColorsController : Controller
    {
        List<Color> colors = new List<Color> { Color.Red, Color.BlueViolet, Color.AliceBlue, Color.Aqua, Color.CadetBlue };
        Potion currentPotion;
        public IActionResult Index()
        {
            if (HttpContext.Session.GetObjectFromJson<Potion>("currentPotion") == null)
            {
                currentPotion = new Potion();
                HttpContext.Session.SetObjectAsJson("currentPotion", currentPotion);
                ViewBag.Debug = "New potion";
            }
            else
            {
                currentPotion = HttpContext.Session.GetObjectFromJson<Potion>("currentPotion");
                ViewBag.Debug = "Existing potion";
                currentPotion.Ingredients.Add(new Ingredient());
            }

            if (currentPotion.compteur < colors.Count)
            {
                ViewBag.Message = "inferieur";
                currentPotion.compteur++;
            }
            else
            {
                ViewBag.Message = "superieur";
                currentPotion.compteur = 0;
            }

            ViewBag.Color = ColorTools.ChangeColor(ViewBag.Color, currentPotion.ActualColor);
            currentPotion.ActualColor = ViewBag.Color;
            ViewBag.Compteur = currentPotion.compteur;
            ViewBag.Ingredients = currentPotion.Ingredients.Count;
            HttpContext.Session.SetObjectAsJson("currentPotion", currentPotion);
            return View("Index", currentPotion);
        }
    }
}
