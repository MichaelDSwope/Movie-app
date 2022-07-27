using System;
using System.Collections.Generic;






namespace MovieDatabase
{
    class program
    {
        static Dictionary<string, string> movieOptions = new Dictionary<string, string>();

        public static void MovieOption()
        {
            MovieInfo movie0 = new MovieInfo()
            
            {

                title = "StarWars",
                category = "Sci-Fi",
            };
            MovieInfo movie1 = new MovieInfo()
            {
               title = "Matrix",
               category = "Sci-Fi",
            };
            MovieInfo movie2 = new MovieInfo()
            {
                title = "Sweeney Todd",
                category = "Horror",
            };
            MovieInfo movie3 = new MovieInfo()
            {
                title = "Halloween",
                category = "Horror"
            };
            MovieInfo movie4 = new MovieInfo()
            {
                title = "Grandma's Boy",
               category = "Comedy"
            };
            MovieInfo movie5 = new MovieInfo()
            {  
                title = "Hubie's Halloween",
                category = "Comedy"
            };
            MovieInfo movie6 = new MovieInfo()
            {  
                title = "Forest Gump",
                category = "Drama"
            };
            MovieInfo movie7 = new MovieInfo()
            {   
                title = "GodFather",
                category = "Drama",
            };
            MovieInfo movie8 = new MovieInfo()
            {
                title = "Gladiator",
                category = "Historic",
            };
            MovieInfo movie9 = new MovieInfo()
            {
                title = "Troy",
                category = "Historic",
            };




            movieOptions.Add(movie0.title, movie0.category);
            movieOptions.Add(movie1.title, movie1.category);
            movieOptions.Add(movie2.title, movie2.category);
            movieOptions.Add(movie3.title, movie3.category);
            movieOptions.Add(movie4.title, movie4.category);
            movieOptions.Add(movie5.title, movie5.category);
            movieOptions.Add(movie6.title, movie6.category);
            movieOptions.Add(movie7.title, movie7.category);
        }

        public static void DisplayMovies()
        {
            foreach (var movie in movieOptions)
            {
                Console.WriteLine("{0} ---- ${1}", movie.Key, movie.Value);
            }
        }

        public static bool movieChoices(string userEntry)
        {
            
            foreach (var Movies in movieOptions)
            {
                if (Movies.Key == userEntry)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Main(string[] args)
        {
            MovieOption();
            DisplayMovies();


            List<string> movieList = new List<string>();
            bool addMoreMovies = true;
            decimal totalPrice = 0m;
            while (addMoreMovies)
            {

                

                bool movieChoices = false;
                while (!movieChoices)
                {
                    Console.WriteLine("Welcome to the Movies Application.");
                    Console.WriteLine("There are 10 movies in this list.");
                    Console.WriteLine("What category are you interested in?");
                   
                    string userEntry = Console.ReadLine()

                    
                    movieChoices = program.movieChoices(userEntry);
                    
                    if (!movieChoices)
                    {
                        Console.WriteLine("Sorry; That choice is unavailable!");
                    }
                    else
                    {
                        movieList.Add(userEntry);
                    }
                }

            } Console.WriteLine("Continue?:  y/n");
            addMoreMovies = Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase);
        }
        public class MovieInfo
        {
            public string category { get; set; }
            public string title { get; set; }
        }
    }
}