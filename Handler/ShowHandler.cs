using ProjectPSD.Factory;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handler
{
    public class ShowHandler
    {
        public static List<Show> GetShowList()
        {
            return ShowRepository.GetAllShow();
        }

        public static Show GetShowDetailById(int id)
        {
            return ShowRepository.GetShowDetailById(id);
        }

        public static Show GetShowDetailByName(string name)
        {
            return ShowRepository.GetShowDetailByName(name);
        }

        public static Show GetShowDetailByToken(string token)
        {
            return ShowRepository.getShowbyToken(token);
        }
        public static bool Insert(string name, string url, int price, string description, int sellerid)
        {
            Show s = ShowFactory.Create(name, url, description, price, sellerid);

            return ShowRepository.InsertShow(s);
        }

        public static bool Update(int id, string name, string url, int price, string description, int sellerid)
        {
            Show s = ShowRepository.GetShowById(id);
            if(s != null)
            {
                s.Name = name;
                s.URL = url;
                s.Price = price;
                s.Description = description;
                return ShowRepository.UpdateShow(s);
            }
            else
            {
                return false;
            }
        }
        public static bool reviewinsert(int review, string desription, int trnsactiondetail)
        {
            Review a = ShowFactory.insertreview(review, desription, trnsactiondetail);
            return ShowRepository.insertReview(a);
        }
    }
}