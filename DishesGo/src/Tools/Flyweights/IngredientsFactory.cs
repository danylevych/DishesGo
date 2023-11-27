using DishesGo.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace DishesGo.src.Tools.Flyweights
{
    public static class IngredientsFactory
    {
        private static Dictionary<string, Image> keyValuePairs = new Dictionary<string, Image>();
        
        private static Dictionary<string, int>  ingredientsId = new Dictionary<string, int>();

        public static Dictionary<string, Image> Pairs { get { return keyValuePairs; } }

        private static DateTime FeelingDateTime {  get; set; }
        
        public static bool isFeeled { get; private set; }



        public static void FeelAndUpdateValues()
        {
            if (CanUpdate())
            {
                isFeeled = true;
                keyValuePairs.Clear();
                ingredientsId.Clear();

                // Feel the keyval for ingrediends.
                using (DishesGo_dbEntities context = new DishesGo_dbEntities())
                {
                    var ingredients = context.Ingredients.ToList();

                    foreach (var item in ingredients)
                    {
                        if (item.ingredient_photo != null)
                        {
                            using (MemoryStream ms = new MemoryStream(item.ingredient_photo))
                            {
                                keyValuePairs.Add(item.ingredient_name, Image.FromStream(ms));
                            }
                        }
                        else
                        {
                            keyValuePairs.Add(item.ingredient_name, Properties.Resources.titlePhoto);
                        }

                        ingredientsId.Add(item.ingredient_name, item.ingredient_id);
                    }

                    // Set date of updating.
                    var result = context.UpdateLogs.FirstOrDefault(tableUpdate => tableUpdate.table_name == "Ingredients");

                    if (result != null)
                    {
                        FeelingDateTime = result.last_update;
                    }
                }
            }
        }

        public static Image GetIngridientImage(string key)
        {
            // If user want to get instance, that does not exist.
            if (!keyValuePairs.ContainsKey(key)) 
            {
                throw new NullReferenceException("The DishesGo database does not have the element  = " + key);
            }

            return keyValuePairs[key];
        }

        public static int GetIngridientID(string key)
        {
            // If user want to get instance, that does not exist.
            if (!ingredientsId.ContainsKey(key))
            {
                throw new NullReferenceException("The DishesGo database does not have the element  = " + key);
            }

            return ingredientsId[key];
        }

        public static void Clear()
        {
            keyValuePairs.Clear();
            ingredientsId.Clear();
            isFeeled = false;
        }

        public static bool CanUpdate()
        {
            if (!isFeeled)
            {
                return true; // If the dictionary is empty, we have to feel it.
            }

            using (DishesGo_dbEntities context = new DishesGo_dbEntities())
            {
                var result = context.UpdateLogs.FirstOrDefault(tableUpdate => tableUpdate.table_name == "Ingredients");

                if (result != null)
                {
                    return result.last_update != FeelingDateTime; // Check last update.
                }
                return false;
            }
        }
    }
}
