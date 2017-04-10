﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10_MovieList
{
    public class Movie
    {
        public string Title { get; }
        public string Category { get;}

        public Movie(string title, string category)
        {
            this.Title = title;
            this.Category = category;
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
            show = new Movie("The English Patient", "scifi");
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
