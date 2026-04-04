using Abc.Data;
using Abc.Infra;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Movies.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new AbcSoftMoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AbcSoftMoviesContext>>());

            if (context == null || context.Movies == null)
            {
                throw new NullReferenceException(
                    "Null BlazorWebAppMoviesContext or Movie DbSet");
            }

            if (context.Movies.Any())
            {
                return;
            }

            context.Movies.AddRange(
                new Movie
                {
                    Name = "Mad Max",
                    ValidFrom = new DateTime(1979, 4, 12),
                    Genre = "Sci-fi (Cyberpunk)",
                    Price = 2.51M,
                },
                new Movie
                {
                    Name = "The Road Warrior",
                    ValidFrom = new DateTime(1981, 12, 24),
                    Genre = "Sci-fi (Cyberpunk)",
                    Price = 2.78M,
                },
                new Movie
                {
                    Name = "Mad Max: Beyond Thunderdome",
                    ValidFrom = new DateTime(1985, 7, 10),
                    Genre = "Sci-fi (Cyberpunk)",
                    Price = 3.55M,
                },
                new Movie
                {
                    Name = "Mad Max: Fury Road",
                    ValidFrom = new DateTime(2015, 5, 15),
                    Genre = "Sci-fi (Cyberpunk)",
                    Price = 8.43M,
                },
                new Movie
                {
                    Name = "Furiosa: A Mad Max Saga",
                    ValidFrom = new DateTime(2024, 5, 24),
                    Genre = "Sci-fi (Cyberpunk)",
                    Price = 13.49M,
                });

            context.SaveChanges();
        }
    }
}