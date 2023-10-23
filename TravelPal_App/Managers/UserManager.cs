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
        public static void RemoveUser(string username)
        {
            //Lägg till ta bort användarefunktion finns ej med i instruktionerna? 
        }
        public static void UpdateUsername(string username)
        {
            //I userdetails lägg till senare
        }

        private static void ValidateUsername(string username)
        {
            //skriv in validering för userName
        }
        public static bool SignInUser(string username, string password)
        {
            //skriv in if för inloggning
            return false;
        }

        public static void SignOutUser()
        {
            //ngt logga ut användare
        }







    }
}
