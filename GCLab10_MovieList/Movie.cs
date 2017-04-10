using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab10_MovieList
{
    public class Movie
    {
        public string title { get; private set; }
        public string category { get; private set; }

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
    }
}
