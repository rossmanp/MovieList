using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10_MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fill the empty list with movies from the MovieList function.

            List<Movie> movies = MovieList();
            IEnumerable<Movie> query = movies.OrderBy(movie => movie.Title);
            int movieCategory = 0;
            string input = "";
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("\nThere are " + movies.Count() + " movies in this list.");
            do
            {
                Console.WriteLine("What category are you interested in?");
                Console.WriteLine("1: animated \n2: drama \n3: horror \n4: scifi");          
                Int32.TryParse(Console.ReadLine(), out movieCategory);
                switch (movieCategory)
                {
                    case 1:
                        input = "animated";
                        break;
                    case 2:
                        input = "drama";
                        break;
                    case 3:
                        input = "horror";
                        break;
                    case 4:
                        input = "scifi";
                        break;
                    default:
                        Console.WriteLine("That was not valid input!");
                        break;
                }
            } while (movieCategory < 1 || movieCategory > 4);

            {
                foreach (Movie m in query)
                {
                    if (m.Category.Equals(input))
                    {
                        Console.WriteLine(m.Title);
                    }
                }
            }
            Console.ReadLine();        
        }

        public static List<Movie> MovieList()
        {
            List<Movie> movieList = new List<Movie>();
            Movie show = new Movie("Up", "animated");
            movieList.Add(show);
            show = new Movie("The King's Speech", "drama");
            movieList.Add(show);
            show = new Movie("Scream", "horror");
            movieList.Add(show);
            show = new Movie("Star Wars", "scifi");
            movieList.Add(show);
            show = new Movie("Bambi", "animated");
            movieList.Add(show);
            show = new Movie("The English Patient", "drama");
            movieList.Add(show);
            show = new Movie("Friday the 13th", "horror");
            movieList.Add(show);
            show = new Movie("Star Trek", "scifi");
            movieList.Add(show);
            show = new Movie("The Lion King", "animated");
            movieList.Add(show);
            show = new Movie("Halloween", "horror");
            movieList.Add(show);

            return movieList;
        }
    }
}
