using System;
using System.Collections.Generic;
using TravelPal_App.Models;

namespace TravelPal_App.Managers
{
    public class TravelManager
    {

        public static List<Travel> Travelsadded { get; set; } = new()
        {

              new Travel { User = "user",Id= 1,NumberOfTravelers=1, Country= "Sweden",City ="Stockholm", TypeOfTravel= "Vacation",Allinclusive= "yes",WorkDetails= " ",FromDate= "2023-10-25",ToDate= "2023-11-25"},
              new Travel { User = "user",Id= 2,NumberOfTravelers=8, Country= "Denmark",TypeOfTravel= "Work",Allinclusive= "no",WorkDetails= "Möte om något viktigt",FromDate= "2023-12-24",ToDate= "2023-12-30"},

        };
        public static Travel? SelectedId { get; set; }
        public static List<Pack_Item> Pack_Items { get; set; } = new()
        {
            new Pack_Item {Id = 1, PackItem ="Skjorta", PackItemQuantity = "2", PackItemIsRequired=" "},
            new Pack_Item {Id = 1, PackItem ="byxor", PackItemQuantity = "3", PackItemIsRequired=" "},
            new Pack_Item {Id = 2, PackItem ="Anteckningar", PackItemQuantity = "1", PackItemIsRequired=" "},
            new Pack_Item {Id = 2, PackItem ="Festplan för AW", PackItemQuantity = "1", PackItemIsRequired=" "},

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
        public static Travel? AddTravel(string country, string city, string typeOfTravel, int numberOfTravelers, bool allInClusive_bool, string workdetails, string fromdate, string todate)
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
            Travel newTravel = new(user, id, country, city, typeOfTravel, numberOfTravelers, allinclusive_text, workdetails, fromdate, todate);
            Travelsadded.Add(newTravel);
            return newTravel;
        }
        public static int IdCheck() //Ta fram ett unikt id för varje resa och så att man kan koppla ihop packitems till varje resa. 
        {
            int id = 0;
            foreach (var travel in Travelsadded) //Sak till framtiden, här kan vi "filtera" per användare så att flera användare kan vara inloggade och lägga till resor.
            {
                id = Math.Max(travel.Id, 0);
            }
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
