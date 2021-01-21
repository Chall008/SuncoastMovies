using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SuncoastMovies
{

    //This is where the logic ties into all the other models/classes
    class Program
    {
        static void Main(string[] args)
        {

            // Get a new context which will connect to the database
            var context = new SuncoastMoviesContext();

            // Get a reference to our collection of movies.
            // NOTE: this doesn't yet access any of them, just gives
            //       us a variable that knows how.

            // var movies = context.Movies;


            var movieCount = context.Movies.Count();
            Console.WriteLine($"There are {movieCount} movies!");

            foreach (var movie in context.Movies)
            {

                Console.WriteLine($"There is a movie name {movie.Title} ");

            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Now lets go through the movies *AND* join their Ratings
            //
            //
            //
            //
            //                   GET ALL THE MOVIES
            //                      |        |       
            foreach (var movie in context.Movies.Include(movie => movie.Rating))
            {
                Console.WriteLine($"There is a movie named {movie.Title} that is the {movie.Rating.Description} ");

            }
            foreach (var movie in movies)
            {
                if (movie.Rating == null)
                {
                    Console.WriteLine($"{movie.Title} - not rated");
                }

                else
                {
                    Console.WriteLine($"{movie.Title} - {movie.Rating.Description}");
                }

                foreach (var role in movie.Roles)
                {
                    Console.WriteLine($" - {role.CharacterName} played by {role.Actor.FullName}");
                }


            }




        }



    }
}
