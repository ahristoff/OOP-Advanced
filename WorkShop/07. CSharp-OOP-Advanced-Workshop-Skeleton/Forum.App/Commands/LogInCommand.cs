using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Commands
{
    using Contracts;

    public class LogInCommand : Contracts.ICommand
    {
        private const string errorMessage = "Invalid username or password!";
        private IUserService userService;
        private IMenuFactory menuFactory;

        public LogInCommand(IUserService userService, IMenuFactory menuFactory)
        {
            this.userService = userService;
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string username = args[0];
            string password = args[1];

            bool validUsername = !string.IsNullOrEmpty(username) && username.Length >= 4;
            bool validPassword = !string.IsNullOrEmpty(password) && password.Length >= 4;

            if (!validPassword || !validUsername)
            {
                throw new ArgumentException(errorMessage);
            }

            bool userLogIn = this.userService.TryLogInUser(username, password);

            if (!userLogIn)
            {
                throw new InvalidOperationException(errorMessage);
            }

            return this.menuFactory.CreateMenu("MainMenu");
        }
    }
}
