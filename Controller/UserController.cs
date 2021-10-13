using ProjectPSD.Handler;
using ProjectPSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ProjectPSD.Controller
{
    public class UserController
    {
        public static User GetUserById(int id)
        {
            return UserHandler.GetUserById(id);
        }

        public static string CheckRegister(string name, string username, string password,string confirm, string roleId)
        {
            string response = "";

            if (response == "")
            {
                if (name == "")
                {
                    response = "Name must be filled!";
                }
                else if (name.Length < 1 || name.Length > 30)
                {
                    response = "Name length must be between 1 and 30";
                }
                else if (username == "")
                {
                    response = "Userame must be filled!";
                }
                else if (username.Length < 6 || username.Length > 30)
                {
                    response = "Username length must be between 6 and 30";
                }
                else if (password == "")
                {
                    response = "Password must be filled!";
                }
                else if (password.Length < 6)
                {
                    response = "Password length must be at least 6 character";
                }
                else if (confirm != password)
                {
                    response = "Confirm password must be the same with password";
                }
                else if (roleId == "") 
                {
                    response = "Role must be chosen";
                }
                else if (roleId.Equals("Seller"))
                {

                    if (UserHandler.Register(username, password, name, 1))
                    {
                        response = "";
                    }
                    else
                    {
                        response = "Failed to register!";
                    }
                }
                else if (roleId.Equals("Buyer"))
                {
                    if (UserHandler.Register(username, password, name, 2))
                    {
                        response = "";
                    }
                    else
                    {
                        response = "Failed to register!";
                    }
                }
            }
            return response;
        }

        public static string CheckLogin(string email, string password)
        {
            string response = "";

            if(email == "")
            {
                response = "Username must be filled!";
            }
            else if(password == "")
            {
                response = "Password must be filled!";
            }
            else
            {
                User currUser = UserHandler.Login(email, password);

                if (currUser == null){
                    response = "User not found!";
                }
            }
            return response;
        }


        public static string Checkupdate(string name, string oldpassword, string newpassword, string confirmpassword, string password, string email)
        {
            string response = "";

            if(name.Length > 29 || name.Length < 2)
            {
                response = "Name must be between 1 - 30 alphabet with space";
            }
            
            else if(oldpassword != password && oldpassword != null)
            {
                response = "Old password must match current password";
            }
            else if(newpassword.Length < 6 && oldpassword != null)
            {
                response = "Password must be at least 6 characters";
            }
            else if(confirmpassword != newpassword && newpassword != null)
            {
                response = "Confirm your password to match input";
            }
            else
            {
                
                if(UserHandler.Update(name,newpassword, email))
                {
                    response = "";
                }
                else
                {
                    response = "Update Failed";
                }
            }
            return response;
        }


        public static User GetUser(string username, string password)
        {
            return UserHandler.GetUser(username, password);
        }
    }
}