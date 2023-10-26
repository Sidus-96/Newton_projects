﻿namespace TravelPal_App.Models
{
    public class Pack_Item
    {
        public int Id { get; set; }
        public string PackItem { get; set; }
        public string PackItemQuantity { get; set; }
        public string PackItemIsRequired { get; set; }
        public Pack_Item()
        {

        }
        public Pack_Item(int id, string packitem, string packItemquantity, string packItemIsRequired)
        {
            Id = id;
            PackItem = packitem;
            PackItemQuantity = packItemquantity;
            PackItemIsRequired = packItemIsRequired;
        }
    }
}
