using System.Collections.Generic;

namespace PotionsMaker.Models
{
    public class Potion
    {
        public string ActualColor { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Dictionary<string, (int?, string)> Stats { get; set; }
        public int compteur;

        public Potion()
        {
            Ingredients = new List<Ingredient>();
            ActualColor = "#d1edec";
            Stats = new Dictionary<string, (int?, string)> {
                {"Toxicité", (0, "")},
                {"Soin", (0, "")},
                {"Amour", (0, "")},
                {"Puissance", (0, "")},
                {"Mana", (0, "")},
                {"Intelligence", (0, "")},
                {"Agilité", (0, "")}
            };
        }
    }
}
