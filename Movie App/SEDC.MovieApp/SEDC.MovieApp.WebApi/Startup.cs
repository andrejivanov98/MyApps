using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SEDC.MovieApp.DataAccess.IRepository;
using SEDC.MovieApp.DataAccess.Repositories;
using SEDC.MovieApp.DataModels;
using SEDC.MovieApp.Services;
using SEDC.MovieApp.Services.IServices;
using SEDC.MovieApp.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.MovieApp.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IRepository<Movie>, MovieRepository>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IUserService, UserService>();

            services.AddDbContext<MoviesDb>(x => x.UseSqlServer("Server=.;Database=MoviesDb;Trusted_Connection=True"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
