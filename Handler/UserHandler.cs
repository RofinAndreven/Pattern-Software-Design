using ProjectPSD.Factory;
using ProjectPSD.Model;
using ProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Handler
{
    public class UserHandler
    {

        public static User Login(string email, string password)
        {
            return UserRepository.GetUser(email, password);
        }
        public static bool Register(string username, string password, string name, int roleId)
        {
            User u = UserFactory.Create(username, password, name, roleId);

            return UserRepository.InsertUser(u);
        }

        public static User GetUser(string username, string password)
        {
            return UserRepository.GetUser(username, password);
        }

        public static User GetUserById(int id)
        {
            return UserRepository.GetUserById(id);
        }

        public static bool Update(string name, string password, string email)
        {
            User u = UserRepository.GetUserbyemail(email);

            if(u != null)
            {
                u.Name = name;
                u.Password = password;
                u.Username = email;
                return UserRepository.updateuser(u);
            }
            else
            {
                return false;
            }
            //if (name == "" && password != null)
            //{
            //    u.Password = password;
            //    return UserRepository.updateuser(u);
            //}
            //else if(password=="" && name != null)
            //{
            //    u.Name = name;
            //    return UserRepository.updateuser(u);
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}