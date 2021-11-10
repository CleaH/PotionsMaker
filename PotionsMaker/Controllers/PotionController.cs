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
        static public void GetMaxStats(Potion potion)
        {
            SetStats(potion);
            potion.Stats = potion.Stats.OrderByDescending( s => s.Value.Item1).ToDictionary(p => p.Key, p => p.Value);
        }
        static public void GetMaxEffects(Potion potion) 
        {
            GetMaxStats(potion);

            switch (potion.Stats["Toxicité"].Item1)
            {
                case int i when (i < -10):
                    potion.Stats["Toxicité"] = (potion.Stats["Toxicité"].Item1, "La potion n'est pas toxique.");
                    break;
                case int i when (i >= -10 && i < -5):
                    potion.Stats["Toxicité"] = (potion.Stats["Toxicité"].Item1, "La potion est très peu toxique.");
                    break;
                case int i when (i >= -5 && i < 0):
                    potion.Stats["Toxicité"] = (potion.Stats["Toxicité"].Item1, "La potion est peu toxique.");
                    break;
                case int i when (i >= 0 && i < 5):
                    potion.Stats["Toxicité"] = (potion.Stats["Toxicité"].Item1, "La potion est légèrement toxique.");
                    break;
                case int i when (i >= 5 && i < 10):
                    potion.Stats["Toxicité"] = (potion.Stats["Toxicité"].Item1, "La potion est très toxique.");
                    break;
                case int i when (i >= 10):
                    potion.Stats["Toxicité"] = (potion.Stats["Toxicité"].Item1, "La potion est mortelle !");
                    break;
            }
            switch (potion.Stats["Soin"].Item1)
            {
                case int i when (i < -10):
                    potion.Stats["Soin"] = (potion.Stats["Soin"].Item1, "La potion ne soigne pas.");
                    break;
                case int i when (i >= -10 && i < -5):
                    potion.Stats["Soin"] = (potion.Stats["Soin"].Item1, "La potion soigne très peu.");
                    break;
                case int i when (i >= -5 && i < 0):
                    potion.Stats["Soin"] = (potion.Stats["Soin"].Item1, "La potion soigne peu.");
                    break;
                case int i when (i >= 0 && i < 5):
                    potion.Stats["Soin"] = (potion.Stats["Soin"].Item1, "La potion soigne beaucoup.");
                    break;
                case int i when (i >= 5 && i < 10):
                    potion.Stats["Soin"] = (potion.Stats["Soin"].Item1, "La potion peut soigner de toute blessure et empoisonnement.");
                    break;
                case int i when (i >= 10):
                    potion.Stats["Soin"] = (potion.Stats["Soin"].Item1, "La potion peut ressuciter !");
                    break;
            }
            switch (potion.Stats["Amour"].Item1)
            {
                case int i when (i < -10):
                    potion.Stats["Amour"] = (potion.Stats["Amour"].Item1, "La potion rend hideux !");
                    break;
                case int i when (i >= -10 && i < -5):
                    potion.Stats["Amour"] = (potion.Stats["Amour"].Item1, "La potion rend très moche.");
                    break;
                case int i when (i >= -5 && i < 0):
                    potion.Stats["Amour"] = (potion.Stats["Amour"].Item1, "La potion rend un peu plus moche.");
                    break;
                case int i when (i >= 0 && i < 5):
                    potion.Stats["Amour"] = (potion.Stats["Amour"].Item1, "La potion rend un peu plus beau.");
                    break;
                case int i when (i >= 5 && i < 10):
                    potion.Stats["Amour"] = (potion.Stats["Amour"].Item1, "La potion rend très belle/beau.");
                    break;
                case int i when (i >= 10):
                    potion.Stats["Amour"] = (potion.Stats["Amour"].Item1, "La potion rend irresistible !");
                    break;
            }
            switch (potion.Stats["Puissance"].Item1)
            {
                case int i when (i < -10):
                    potion.Stats["Puissance"] = (potion.Stats["Puissance"].Item1, "La potion rend aussi faible qu'un Boursouf !");
                    break;
                case int i when (i >= -10 && i < -5):
                    potion.Stats["Puissance"] = (potion.Stats["Puissance"].Item1, "La potion affaiblit énormément.");
                    break;
                case int i when (i >= -5 && i < 0):
                    potion.Stats["Puissance"] = (potion.Stats["Puissance"].Item1, "La potion affaiblit un peu.");
                    break;
                case int i when (i >= 0 && i < 5):
                    potion.Stats["Puissance"] = (potion.Stats["Puissance"].Item1, "La potion rend un peu plus fort.");
                    break;
                case int i when (i >= 5 && i < 10):
                    potion.Stats["Puissance"] = (potion.Stats["Puissance"].Item1, "La potion rend beaucoup plus fort.");
                    break;
                case int i when (i >= 10):
                    potion.Stats["Puissance"] = (potion.Stats["Puissance"].Item1, "La potion rend aussi fort d'un Nundu !");
                    break;
            }
            switch (potion.Stats["Mana"].Item1)
            {
                case int i when (i < -10):
                    potion.Stats["Mana"] = (potion.Stats["Mana"].Item1, "La potion rend incapable d'utiliser la magie !");
                    break;
                case int i when (i >= -10 && i < -5):
                    potion.Stats["Mana"] = (potion.Stats["Mana"].Item1, "La potion réduit énormement da quantité d'énergie magique.");
                    break;
                case int i when (i >= -5 && i < 0):
                    potion.Stats["Mana"] = (potion.Stats["Mana"].Item1, "La potion réduit un peu la quantité d'énergie magique.");
                    break;
                case int i when (i >= 0 && i < 5):
                    potion.Stats["Mana"] = (potion.Stats["Mana"].Item1, "La potion augmente un peu la quantité d'énergie magique.");
                    break;
                case int i when (i >= 5 && i < 10):
                    potion.Stats["Mana"] = (potion.Stats["Mana"].Item1, "La potion augmente énormement la quantité d' énergie magique.");
                    break;
                case int i when (i >= 10):
                    potion.Stats["Mana"] = (potion.Stats["Mana"].Item1, "La potion permet d'utiliser les sorts les plus puissants !");
                    break;
            }
            switch (potion.Stats["Intelligence"].Item1)
            {
                case int i when (i < -10):
                    potion.Stats["Intelligence"] = (potion.Stats["Intelligence"].Item1, "La potion rend aussi imbécile qu'un Troll !");
                    break;
                case int i when (i >= -10 && i < -5):
                    potion.Stats["Intelligence"] = (potion.Stats["Intelligence"].Item1, "La potion rend très bête.");
                    break;
                case int i when (i >= -5 && i < 0):
                    potion.Stats["Intelligence"] = (potion.Stats["Intelligence"].Item1, "La potion rend un peu plus bête.");
                    break;
                case int i when (i >= 0 && i < 5):
                    potion.Stats["Intelligence"] = (potion.Stats["Intelligence"].Item1, "La potion rend un peu plus intelligent.");
                    break;
                case int i when (i >= 5 && i < 10):
                    potion.Stats["Intelligence"] = (potion.Stats["Intelligence"].Item1, "La potion rend très intelligent.");
                    break;
                case int i when (i >= 10):
                    potion.Stats["Intelligence"] = (potion.Stats["Intelligence"].Item1, "La potion rend aussi intelligent que Hermione Granger !");
                    break;
            }
            switch (potion.Stats["Agilité"].Item1)
            {
                case int i when (i < -10):
                    potion.Stats["Agilité"] = (potion.Stats["Agilité"].Item1, "La potion rend aussi peu agile que Hagrid !");
                    break;
                case int i when (i >= -10 && i < -5):
                    potion.Stats["Agilité"] = (potion.Stats["Agilité"].Item1, "La potion rend très peu agile.");
                    break;
                case int i when (i >= -5 && i < 0):
                    potion.Stats["Agilité"] = (potion.Stats["Agilité"].Item1, "La potion rend peu agile.");
                    break;
                case int i when (i >= 0 && i < 5):
                    potion.Stats["Agilité"] = (potion.Stats["Agilité"].Item1, "La potion rend un peu plus agile.");
                    break;
                case int i when (i >= 5 && i < 10):
                    potion.Stats["Agilité"] = (potion.Stats["Agilité"].Item1, "La potion rend très agile.");
                    break;
                case int i when (i >= 10):
                    potion.Stats["Agilité"] = (potion.Stats["Agilité"].Item1, "La potion rend aussi agile que Dobby !");
                    break;
            }
        }
    }
}