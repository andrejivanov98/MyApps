using SEDC.MovieApp.DataModels;
using SEDC.MovieApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Mappers
{
    public static class MovieMapper
    {
        public static MovieModel MovieToMovieModel(Movie movie)
        {
            return new MovieModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Year = movie.Year,
                Genre = (Genre)movie.Genre

            };
        }

        public static List<MovieModel> MoviesToMovieModels(List<Movie> movies)
        {
            List<MovieModel> movieModels = new List<MovieModel>();
            foreach(var movie in movies)
            {
                movieModels.Add(new MovieModel
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Description = movie.Description,
                    Year = movie.Year,
                    Genre = (Genre)movie.Genre
                });
            }
            return movieModels; 
        }
    }
}
