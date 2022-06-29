using Microsoft.EntityFrameworkCore;

namespace RecipeWebAPI.Models.Shared
{
    public class IngredientContext: DbContext
    {
        public IngredientContext(DbContextOptions<IngredientContext> options) : base(options)
        {

        }

        public DbSet<Ingredient> Ingredients { get; set; } = null;
    }
}
