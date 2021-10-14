using SEDC.MovieApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.IServices
{
    public interface IUserService
    {
        void Add(UserModel user);
        List<UserModel> GetAll();
        UserModel GetById(int id);
    }
}
