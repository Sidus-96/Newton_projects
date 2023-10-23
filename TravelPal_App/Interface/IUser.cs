namespace TravelPal_App.Interface
{
    public interface IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        void Iuser(string username, string password, string country);


        //public IUser(string username, string password, string country)
        //{
        //    Username = username;
        //    Password = password;
        //    Country = country;
        //}
    }




}
