namespace TravelPal_App.Models
{
    public class Travel
    {

        public Travel() //För att få listan att funka
        {
        }
        public string? User { get; set; }
        public int Id { get; set; }
        public string? Country { get; set; }
        public string TypeOfTravel { get; set; }
        public int NumberOfTravelers { get; set; }
        public string? Allinclusive { get; set; }
        public string? WorkDetails { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
        public int SelectedId { get; set; }


        public Travel(string user, int id, string country, string typeOfTravel, int numberoftravelers, string allinsluive_text, string workdetails, string fromdate, string todate)
        {
            User = user;
            Id = id;
            Country = country;
            TypeOfTravel = typeOfTravel;
            NumberOfTravelers = numberoftravelers;
            Allinclusive = allinsluive_text;
            WorkDetails = workdetails;
            FromDate = fromdate;
            ToDate = todate;
        }
        public Travel(int id)
        {
            SelectedId = id;
        }

        //public int GetSelectedId()
        //{
        //    return SelectedId;
        //   
        //}
    }
}
