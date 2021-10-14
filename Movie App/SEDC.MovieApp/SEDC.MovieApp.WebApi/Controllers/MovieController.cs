using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.MovieApp.DataModels;
using SEDC.MovieApp.Models.Models;
using SEDC.MovieApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("getAll")]
        public ActionResult<List<MovieModel>> GetAllMovies()
        {
            return _movieService.GetAll();
        }

        [HttpGet("getById/{id}")]
        public ActionResult<MovieModel> GetById( int id)
        {
            return _movieService.GetById(id);
        }

        [HttpPost("createMovie")]
        public ActionResult<string> AddMovie([FromBody] Movie movie)
        {
            try { 
            _movieService.Add(movie);
            return ("The movie was succesfully added!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
