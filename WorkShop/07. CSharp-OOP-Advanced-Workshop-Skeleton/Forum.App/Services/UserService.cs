﻿using System;
using System.Collections.Generic;
using System.Text;
using Forum.App.Contracts;
using Forum.DataModels;
using Forum.Data;
using System.Linq;

namespace Forum.App.Services
{
    public class UserService : IUserService
    {
        private ForumData forumData; 
        private ISession session;

        public UserService(ForumData forumData, ISession session)
        {
            this.forumData = forumData;
            this.session = session;
        }

        public User GetUserById(int userId) 
        {
            User user = this.forumData.Users
                .FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentException($"User with ID {userId} not found");
            }

            return user;
        }

        public string GetUserName(int userId) 
        {
            return this.GetUserById(userId).Username;
        }

        public bool TryLogInUser(string username, string password)
        {
            User user = this.forumData.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                return false;
            }

            this.session.Reset();
            this.session.LogIn(user);

            return true;
        }

        public bool TrySignUpUser(string username, string password)
        {
            bool userAlreadyExists = this.forumData.Users.Any(u => u.Username == username);

            if (userAlreadyExists)
            {
                return false;
            }

            int userId = this.forumData.Users.LastOrDefault()?.Id + 1 ?? 1;

            User user = new User(userId, username, password);

            this.forumData.Users.Add(user);
            forumData.SaveChanges();

            this.TryLogInUser(username, password);

            return true;
        }
    }
}
