using SEDC.MovieApp.DataModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.DataModels
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Genre FavoriteGenre { get; set; }
      
        public Subscription Subscription { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
