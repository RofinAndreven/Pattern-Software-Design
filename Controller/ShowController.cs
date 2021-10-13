using ProjectPSD.Handler;
using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controller
{
    public class ShowController
    {
        public static List<Show> GetShowList()
        {
            return ShowHandler.GetShowList();
        }

        public static Show GetShowById(int id)
        {
            return ShowHandler.GetShowDetailById(id);
        }

        public static Show GetShowListByName(string name)
        {
            return ShowHandler.GetShowDetailByName(name);
        }

        public static Show GetShowByToken(string token)
        {
            return ShowHandler.GetShowDetailByToken(token);
        }
        public static string CheckInsert(string name, string url, string description, string strprice, int sellerid)
        {
            string response = "";
            Uri validateUri;
            int price;

            if (response == "")
            {
                if (name == "")
                {
                    response = "Name must be filled";
                }
                else if (url == "")
                {
                    response = "URL must be filled";
                }
                else if (!Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out validateUri))
                {
                    response = "URL must be valid";
                }
                else if (strprice == "")
                {
                    response = "Price cannot be empty";
                }
                //else if(int.TryParse(strprice, out price))
                //{
                //    response = "price must be numeric!";
                //}
                else if (int.Parse(strprice) < 1000)
                {
                    response = "Price must be more than 1000";
                }
                else if (description == "")
                {
                    response = "Description must be filled";
                }
                else
                {
                    if(int.TryParse(strprice, out price))
                    {
                        if (ShowHandler.Insert(name, url, price, description, sellerid))
                        {
                            response = "";
                        }
                        else
                        {
                            response = "Failed to insert show!";
                        }
                    }
                    
                }
            }
            return response;
        }

        public static string CheckUpdate(int id, string name, string url, string description, int price, int sellerid)
        {
            string response = "";
            Uri validateUri;

            if (response == "")
            {
                if (name == "")
                {
                    response = "Name must be filled";
                }
                else if (url == "")
                {
                    response = "URL must be filled";
                }
                else if (!Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out validateUri))
                {
                    response = "URL must be valid";
                }
                else if (price.ToString() == "")
                {
                    response = "Price cannot be empty";
                }
                else if (price < 1000)
                {
                    response = "Price must be more than 1000";
                }
                else if (description == "")
                {
                    response = "Description must be filled";
                }
                else
                {
                    if (ShowHandler.Update(id, name, url, price, description, 1))
                    {
                        response = "";
                    }
                    else
                    {
                        response = "Failed to update show!";
                    }
                }
            }
            return response;
        }
        
        
        
        public static string reviewinsertcheck(string review, string description, int transactiondetail)
        {
            string response = "";
            int parsedvalude;
            if (response == "")
            {
                if(review == "")
                {
                    response = "Review cannot be empty";
                }
                else if(!int.TryParse(review, out parsedvalude))
                {
                    response = "Review must be numerical";
                }
                else if(description == "")
                {
                    response = "Description cannot be empty";
                }
                else
                {
                    if (int.TryParse(review, out parsedvalude))
                    {
                        if (ShowHandler.reviewinsert(parsedvalude, description, transactiondetail))
                        {
                            response = "";
                        }
                        else
                        {
                            response = "Failed to insert show!";
                        }
                    }
                }

            }
            return response;
        }
    }
}