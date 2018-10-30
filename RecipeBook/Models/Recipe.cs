using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string CookingInstructions { get; set; }
        public string Comments { get; set; }
        public string Image { get; set; }
        public int TotalPriceOfTheDish { get; set; } //should be the total of the ingrendient's 
        public int RateOfTheDish { get; set; } //cijfer of aantal sterren 
        
    }
}
