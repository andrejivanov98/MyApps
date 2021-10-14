using SEDC.MovieApp.DataModels;
using System.Collections.Generic;

namespace SEDC.MovieApp.Models.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Genre FavoriteGenre { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public Subscription Subscription { get; set; }
    }
    public enum Subscription
    {
        Default = 1,
        Premium
    }
  
        
    
}
