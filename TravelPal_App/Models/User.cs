using TravelPal_App.Interface;

namespace TravelPal_App.Models
{
    public class User : IUser
    {
        public User(string username, string password, string country)
        {
            Username = username;
            Password = password;
            Country = country;
        }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Country { get; set; }



    }

}
