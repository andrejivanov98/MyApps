using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Models.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
    }
    public enum Genre
    {
        Thriller = 1,
        Crime,
        Comedy,
        Romance,
        Horror,
        Documentary
    }
}
