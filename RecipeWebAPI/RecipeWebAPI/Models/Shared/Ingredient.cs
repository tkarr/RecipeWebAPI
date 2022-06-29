using System.ComponentModel.DataAnnotations;

namespace RecipeWebAPI.Models.Shared
{
    public class Ingredient
    {
        [Key]
        public string? Name { get; set; }
        public string? Amount { get; set; }
    }
}
