using System.ComponentModel.DataAnnotations;

namespace RecipeWebAPI.Models
{
    public class Ingredient
    {
        [Key]
        public string? Name { get; set; }
        public string? Amount { get; set; }
    }
}
