using System.Collections.Generic;
using TravelPal_App.Interface;
using TravelPal_App.Models;

namespace TravelPal_App.Managers
{
    public class UserManager
    {
        public static List<IUser> Users { get; set; } = new()
        {
            //Lägg till användare sen
        };


        public static bool AddUser(string username, string password, string country) //Borde kolla med Albin om detta är okej användning av interface
        {
            User newUser = new User();
            newUser.IUser(username, password, country);
            Users.Add(newUser);
            return true;

        }







    }
}
