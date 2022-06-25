﻿using Microsoft.EntityFrameworkCore;

namespace RecipeWebAPI.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; } = null;
    }
}
