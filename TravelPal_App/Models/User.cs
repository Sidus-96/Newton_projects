using TravelPal_App.Interface;

namespace TravelPal_App.Models
{
    public class User : IUser
    {

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Country { get; set; }


        public string IUser(string username, string password, string country)
        {
            Username = username;
            Password = password;
            Country = country;

            return (Username + "," + Password + "," + Country);
        }
    }

}
