using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Factory
{
    public class UserFactory
    {
        public static User Create(string username, string password, string name, int roleId)
        {
            User newUser = new User();
            newUser.Username = username;
            newUser.Password = password;
            newUser.Name = name;
            newUser.RoleId = roleId;
            return newUser;
        }
    }
}