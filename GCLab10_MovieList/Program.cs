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
            //Fill the empty list with movies from the GetMovieList function.
            
            Movie screen = new Movie();
            List<Movie> movies = screen.GetMovieList(); 
            
            //sort the movies alphabetically by title
                     
            IEnumerable<Movie> sortedMovies = movies.OrderBy(movie => movie.Title);
            int movieCategory = 0;
            string input = "";
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("\nThere are " + movies.Count() + " movies in this list.");
            do
            {
                Console.WriteLine("What category are you interested in?");
                Console.WriteLine("1: animated \n2: drama \n3: horror \n4: scifi");
                try
                {
                    movieCategory = int.Parse(Console.ReadLine());
                    if (movieCategory < 1 || movieCategory > 4)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter 1, 2, 3, or 4.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please enter 1, 2, 3, or 4.");
                }
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
                        break;
                }
            } while (movieCategory < 1 || movieCategory > 4);

            {
                foreach (Movie m in sortedMovies)
                {
                    if (m.Category.Equals(input))
                    {
                        Console.WriteLine(m.Title);
                    }
                }
            }
            Console.ReadLine();        
        }      
    }
}
