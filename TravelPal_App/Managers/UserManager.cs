using System.Collections.Generic;
using TravelPal_App.Interface;
using TravelPal_App.Models;

namespace TravelPal_App.Managers
{
    public class UserManager
    {
        public static List<User> Users { get; set; } = new()
        {
           new User("user","password","Sweden"),
        };
        public static List<Admin> Admins { get; set; } = new()
        {
            new Admin("admin","password", "Sweden")
        };
        public static IUser? SignedInUser { get; set; }

        public static bool AddUser(string username, string password, string country) //Borde fråga  Albin om detta är okej användning av interface
        {
            User newUser = new(username, password, country);
            Users.Add(newUser);
            return true;
        }

        public static bool ValidateUsername(string username)
        {
            bool isValidUsername = true;

            foreach (var user in Users)
            {
                if (user.Username == username)
                {
                    isValidUsername = false;
                }
            }

            return isValidUsername;
        }
        public static bool ValidateUsernameLength(string username)
        {
            bool isValidUsernamelength = false;
            if (username.Length >= 3)
            {
                return true;
            }

            return isValidUsernamelength;
        }
        public static bool ValidatePassword(string password)
        {
            bool isValidPassword = false;
            if (password != "" && password.Length >= 5)
            {
                isValidPassword = true;
            }
            return isValidPassword;
        }
        public static bool ValidateCountry(string country)
        {
            bool isValidCountry = false;
            if (country == "")
            {
                isValidCountry = true;
            }
            return !isValidCountry;
        }

        public static bool SignInUser(string username, string password)
        {
            foreach (var user in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    SignedInUser = user;

                    return true;
                }

            }
            foreach (var admin in Admins)
            {
                if (admin.Username == username && admin.Password == password)
                {
                    SignedInUser = admin;

                    return true;
                }

            }

            return false;
        }

        public static void SignOutUser()
        {
            SignedInUser = null;
        }
    }
}
