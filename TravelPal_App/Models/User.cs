using TravelPal_App.Interface;

namespace TravelPal_App.Models
{
    public class User : IUser
    {
        public User(string username, string password, string country, bool welcomemsg)
        {
            Username = username;
            Password = password;
            Country = country;
            Welcomemsg = welcomemsg;
        }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Country { get; set; }
        public bool Welcomemsg { get; set; }



    }

}
