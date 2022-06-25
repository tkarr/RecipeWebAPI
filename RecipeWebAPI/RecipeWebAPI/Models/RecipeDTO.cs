namespace RecipeWebAPI.Models
{
    public class RecipeDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new();
        public int Id { get; set; }
    }
}
