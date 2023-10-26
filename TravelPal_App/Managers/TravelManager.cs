using System.Collections.Generic;
using TravelPal_App.Models;

namespace TravelPal_App.Managers
{
    public class TravelManager
    {

        public static List<Travel> Travelsadded { get; set; } = new()
        {

              new Travel { User = "test",Id= 1,NumberOfTravelers=1, Country= "Sweden",TypeOfTravel= "Vaccation",Allinclusive= "yes",WorkDetails= " ",FromDate= "2023-10-25",ToDate= "2023-11-25"},
               new Travel { User = "User not found",Id= 2,NumberOfTravelers=3, Country= "Sweden",TypeOfTravel= "Vaccation",Allinclusive= "yes",WorkDetails= " ",FromDate= "2023-10-25",ToDate= "2023-11-25"},
                new Travel { User = "User not found",Id= 3,NumberOfTravelers=5, Country= "Denmark",TypeOfTravel= "Work",Allinclusive= "",WorkDetails= " ta med anteckningar",FromDate= "2023-10-25",ToDate= "2023-11-25"},
                    new Travel { User = "User not found",Id= 4,NumberOfTravelers=7, Country= "Norway",TypeOfTravel= "Vaccation",Allinclusive= "no",WorkDetails= " ",FromDate= "2023-10-25",ToDate= "2023-11-25"},
        };
        public static Travel? SelectedId { get; set; }
        public static List<Pack_Item> Pack_Items { get; set; } = new()
        {


        };
        public static Pack_Item? AddPackItem(string packItemName, string quantity, string isrequired)
        {
            if (ValidatePackItemName(packItemName))
            {
                int id = IdCheck();
                if (isrequired == "")
                {
                    isrequired = " ";
                }

                Pack_Item newpackItem = new(id, packItemName, quantity, isrequired);

                Pack_Items.Add(newpackItem);

                return newpackItem;
            }

            return null;
        }
        private static bool ValidatePackItemName(string packItemName)
        {
            bool contentExist = false;

            if (!string.IsNullOrEmpty(packItemName))

            {
                contentExist = true;
            }


            return contentExist;
        }
        public static Travel? AddTravel(string country, string typeOfTravel, int numberOfTravelers, bool allInClusive_bool, string workdetails, string fromdate, string todate)
        {
            string user = UserManager.SignedInUser.Username;
            string allinclusive_text = "";
            if (allInClusive_bool == true)
            { allinclusive_text = "yes"; }
            else
            {
                allinclusive_text = "no";
            }
            int id = IdCheck();
            Travel newTravel = new(user, id, country, typeOfTravel, numberOfTravelers, allinclusive_text, workdetails, fromdate, todate);
            Travelsadded.Add(newTravel);
            return newTravel;
        }
        public static int IdCheck()
        {
            int id = Travelsadded.Count;
            id++;
            return id;

        }

        public static void SetSelectedId(int Selectid)
        {
            //I userdetails lägg till senare
            Travel newId = new(Selectid);
            SelectedId = newId;


        }
    }
}
