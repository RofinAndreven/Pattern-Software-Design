using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class ProductFactory
    {
        public static Show Create(string name, string url, string description, int price, int seller)
        {
            Show newShow = new Show();
            newShow.Name = name;
            newShow.Price = price;
            newShow.Description = description;
            newShow.SellerId = seller;
            newShow.URL = url;
            return newShow;

        }
    }
}