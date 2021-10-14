using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.MovieApp.Models.Models;
using SEDC.MovieApp.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.MovieApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getAll")]
        public ActionResult<List<UserModel>> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpGet("getById/{id}")]
        public ActionResult<UserModel> GetById(int id)
        {
            return _userService.GetById(id);
        }
        
        [HttpPost("addUser")]
        public ActionResult<string> AddUser([FromBody]UserModel userModel)
        { 
            try
            {
                _userService.Add(userModel);
                return "The user was succesfully added!";
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

     

        [HttpPost("deleteUser/{Userid}")]
        public ActionResult<string> DeleteUser([FromBody]int userId)
        {
            List<UserModel> users = _userService.GetAll();
            UserModel user = users.FirstOrDefault(x => x.Id == userId);
            users.Remove(user);
            return "The user was removed!";
        }
    }
}
