using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotionsMaker.Models
{
    public class Potion
    {
        public string ActualColor { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public int compteur;

        public Potion()
        {
            Ingredients = new List<Ingredient>();
            ActualColor = "#FFFFFF";
        }
    }
}
