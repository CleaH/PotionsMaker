using System;
using System.Collections.Generic;

#nullable disable

namespace PotionsMaker.Models
{
    public partial class Ingredient
    {
        public int IngredientId { get; set; }
        public string Nom { get; set; }
        public string DescriptionIngredient { get; set; }
        public byte[] ImageIngredient { get; set; }
        public int? R { get; set; }
        public int? V { get; set; }
        public int? B { get; set; }
        public int? Toxicity { get; set; }
        public int? Soin { get; set; }
        public int? Amour { get; set; }
        public int? Puissance { get; set; }
        public int? Mana { get; set; }
        public int? Intelligence { get; set; }
        public int? Agilite { get; set; }
        public decimal? TauxReussite { get; set; }
    }
}
