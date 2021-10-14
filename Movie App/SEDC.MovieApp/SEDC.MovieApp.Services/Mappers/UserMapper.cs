using SEDC.MovieApp.DataModels;
using SEDC.MovieApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Mappers
{
    public static class UserMapper
    {
        public static UserModel UserToUserModel(User user)
        {
            return new UserModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                FullName = user.FullName,
                Password = user.Password,
                Username = user.Username,
                FavoriteGenre = (Genre)user.FavoriteGenre,
                Subscription = (Subscription)user.Subscription
            };
        }

        public static User UserModelToUser(UserModel userModel)
        {
            return new User
            {
                Id = userModel.Id,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                FullName = userModel.FullName,
                Password = userModel.Password,
                Username = userModel.Username,
                FavoriteGenre = (DataModels.Enums.Genre)userModel.FavoriteGenre,
                Subscription = (DataModels.Enums.Subscription)userModel.Subscription

            };
        }
        public static List<UserModel> UserToUserModels(List<User> users)
        {
            List<UserModel> userModels = new List<UserModel>();
            foreach(User user in users)
            {
                userModels.Add(
                new UserModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    FullName = user.FullName,
                    Password = user.Password,
                    Username = user.Username,
                    FavoriteGenre = (Genre)user.FavoriteGenre,
                    Subscription = (Subscription)user.Subscription
                });
                
            };
            return userModels;
        }

    }
}
