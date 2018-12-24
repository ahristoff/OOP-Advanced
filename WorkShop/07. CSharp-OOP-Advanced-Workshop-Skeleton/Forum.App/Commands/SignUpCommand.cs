using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.App.Commands
{
    using Contracts;

    public class SignUpCommand : Contracts.ICommand
    {

        private IUserService userService;
        private IMenuFactory menuFactory;

        public SignUpCommand(IUserService userService, IMenuFactory menuFactory)
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
                throw new ArgumentException("Invalid username or password");
            }

            bool userSignUp = this.userService.TrySignUpUser(username, password);

            if (!userSignUp)
            {
                throw new InvalidOperationException("Username already taken!");
            }

            return this.menuFactory.CreateMenu("MainMenu");
        }
    }
}
