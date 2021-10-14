using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.DataModels
{
    public class MoviesDb : DbContext 
    {
        public MoviesDb(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                        .HasOne(x => x.User)
                        .WithMany(x => x.Movies)
                        .HasForeignKey(x => x.UserId);
            
        }
    }
}
