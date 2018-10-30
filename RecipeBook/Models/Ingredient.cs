using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsVegan { get; set; }
        public bool IsVegetarian { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
        public Allergies Allergy{ get; set; }
         


        public enum Allergies
        {
            GLUTEN,
            EGG,
            COWMILK,
            TREENUTS,
            PEANUTS,
            SHELLFISH,
            SOY
        }
          

    }
}
