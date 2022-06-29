using RecipeWebAPI.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace RecipeWebAPI.Models.Recipe
{
    public class Recipe
    {
        [Key]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new();
        public int Id { get; set; }


    }
}
