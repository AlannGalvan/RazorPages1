using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesPelicula.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesMovieContext>>()))
        {
            if (context == null || context.Pelicula == null)
            {
                throw new ArgumentNullException("Null RazorPagesPeliculaContext");
            }

            // Look for any Peliculas.
            if (context.Pelicula.Any())
            {
                return;   // DB has been seeded
            }

            context.Pelicula.AddRange(
                new Movie
                {
                    Titulo = "When Harry Met Sally",
                    FechaDeLanzamiento = DateTime.Parse("1989-2-12"),
                    Genero = "Romantic Comedy",
                    Precio = 7.99M,
                    Rating = "R"
                },

                new Movie
                {
                    Titulo = "Ghostbusters ",
                    FechaDeLanzamiento = DateTime.Parse("1984-3-13"),
                    Genero = "Comedy",
                    Precio = 8.99M,
                    Rating = "R"
                },

                new Movie
                {
                    Titulo = "Ghostbusters 2",
                    FechaDeLanzamiento = DateTime.Parse("1986-2-23"),
                    Genero = "Comedy",
                    Precio = 9.99M,
                    Rating = "R"
                },

                new Movie
                {
                    Titulo = "Rio Bravo",
                    FechaDeLanzamiento = DateTime.Parse("1959-4-15"),
                    Genero = "Western",
                    Precio = 3.99M,
                    Rating = "R"
                }
            );
            context.SaveChanges();
        }
    }
}