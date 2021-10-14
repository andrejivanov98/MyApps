using SEDC.MovieApp.DataModels;
using SEDC.MovieApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services
{
    public interface IMovieService
    {
        void Add(Movie movie);
        List<MovieModel> GetAll();
        MovieModel GetById(int id);
    }
}
