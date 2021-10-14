using SEDC.MovieApp.DataAccess.IRepository;
using SEDC.MovieApp.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly MoviesDb _db;
        public UserRepository(MoviesDb db)
        {
            _db = db;
        }
        public void Add(User entity)
        {
            if (entity != null)
            {
                _db.Users.Add(entity);
                _db.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            return _db.Users.ToList();
        }

        public User GetById(int id)
        {
            return _db.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}
