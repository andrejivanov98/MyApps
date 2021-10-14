using SEDC.MovieApp.DataAccess.IRepository;
using SEDC.MovieApp.DataModels;
using SEDC.MovieApp.Models.Models;
using SEDC.MovieApp.Services.IServices;
using SEDC.MovieApp.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(UserModel userModel)
        {
            _userRepository.Add(UserMapper.UserModelToUser(userModel));
        }

        public List<UserModel> GetAll()
        {
            return UserMapper.UserToUserModels(_userRepository.GetAll());
        }

        public UserModel GetById(int id)
        {
            return UserMapper.UserToUserModel(_userRepository.GetById(id));
        }
    }
}
