using SEDC.MovieApp.DataAccess.IRepository;
using SEDC.MovieApp.DataModels;
using SEDC.MovieApp.Models.Models;
using SEDC.MovieApp.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Services
{
    public class MovieService : IMovieService
    {
        public readonly IRepository<Movie> _movieRepository;
        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void Add(Movie movie)
        {
            _movieRepository.Add(movie);
        }

        public List<MovieModel> GetAll()
        {
            return MovieMapper.MoviesToMovieModels(_movieRepository.GetAll());
        }

        public MovieModel GetById(int id)
        {
            return MovieMapper.MovieToMovieModel(_movieRepository.GetById(id));
        }
    }
}
