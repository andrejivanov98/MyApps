using SEDC.MovieApp.DataAccess.IRepository;
using SEDC.MovieApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly MoviesDb _db;
        public MovieRepository(MoviesDb db)
        {
            _db = db;
        }
        public void Add(Movie entity)
        {
            if (entity != null)
            {
                _db.Movies.Add(entity);
                _db.SaveChanges();
            }
        }

        public List<Movie> GetAll()
        {
            return _db.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return _db.Movies.FirstOrDefault(x => x.Id == id);
        }
    }
}
