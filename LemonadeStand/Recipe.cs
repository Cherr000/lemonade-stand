using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public int recipeLemon;
        public int recipeSugar;
        public int recipeIce;
        public Recipe()
        {
            recipeLemon = 0;
            recipeSugar = 0;
            recipeIce = 0;
        }
        public void GetRecipe()
        {
            Console.WriteLine($"\n {recipeLemon} Lemon, {recipeSugar} Sugar Cube, and {recipeIce} Ice Cube Will Equal To 1 Pitch and 1 Pitch Equal To 5 cups");
        }
    }
}
