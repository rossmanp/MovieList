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
            List<Movie> movies = new List<Movie>();
            Movie show = new Movie("Up", "animated");
            movies.Add(show);
            show = new Movie("The King's Speech", "drama");
            movies.Add(show);
            show = new Movie("Scream", "horror");
            movies.Add(show);
            show = new Movie("Star Wars", "scifi");
            movies.Add(show);
            show = new Movie("Bambi", "animated");
            movies.Add(show);
            show = new Movie("The English Patient", "scifi");
            movies.Add(show);
            show = new Movie("Friday the 13th", "horror");
            movies.Add(show);
            show = new Movie("Star Trek", "scifi");
            movies.Add(show);
            show = new Movie("The Lion King", "animated");
            movies.Add(show);
            show = new Movie("Halloween", "horror");
            movies.Add(show);
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("\nThere are " + movies.Count() + " movies in this list.");
            Console.WriteLine("What category are you interested in?");
            Console.WriteLine("1: animated \n2: drama \n3: horror \n4: scifi");
            int movieCategory = 0;
            string input = "";
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
            {
                foreach (Movie m in movies)
                {
                    if (m.category.Equals(input))
                    {
                        Console.WriteLine(m.title);
                    }
                }
            }
            Console.ReadLine();        
        }
    }
}
