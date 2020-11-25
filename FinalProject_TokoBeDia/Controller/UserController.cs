using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.Controller
{
    public class UserController
    {
        public static string ValidateNewUser(String name, String email, String password1, String password2, String gender)
        {
            String Message = "";
            Boolean cekEmail = UserHandler.cekEmail(email);

            if(email.Equals("") || !cekEmail)
            {
                Message = "Email must be filled and unique";
            }
            else if (name.Equals(""))
            {
                Message = "Name must be filled";
            }
            else if (password1.Equals(""))
            {
                Message = "Password must be filled";
            }
            else if (password1 != password2)
            {
                Message = "Must be same with password";
            }
            else if (gender.Equals(""))
            {
                Message = "Gender must be chosen";
            }
            else
            {
                UserHandler.RegisterUser(name, email, password1, gender);      
            }

            return Message;
        }

        public static string ValidateUser(String email, String pass)
        {
            String Message = "";
            Boolean cekEmail = UserHandler.cekEmail(email);
            Boolean cekPass = UserHandler.cekPass(pass, email);

            if (cekEmail || email.Equals("")) Message = "Email must be filled and appropriate with the data in the database";
            else if (cekPass || pass.Equals("")) Message = "Password must be filled and appropriate with the data in the database";
           
            return Message;

        }

        public static string ValidateUpdateUser(String name, String emailBefore, String emailAfter, String gender)
        {
            String Message = "";
            Boolean cekEmail = UserHandler.cekEmail(emailAfter);
            if (name.Equals(""))
            {
                Message = "Name must be filled";
            }
            else if (!cekEmail || emailAfter.Equals(""))
            {
                Message = "Email must be filled and unique";
            }
            else if (gender.Equals(""))
            {
                Message = "Gender must be chosen";
            }
            else
            {
                UserHandler.UpdateUser(name, emailBefore, emailAfter, gender);
                Message = "Profile successfully updated!";
            }

            return Message;
        }
        public static string ValidateChangePassword(String email, String oldPassword, String newPassword, String confirmPassword)
        {
            String Message = "";
            Boolean cekPass = UserHandler.cekPass(oldPassword, email);
            if (oldPassword.Equals("")|| cekPass)
            {
                Message = "Must be same with current password";
            }
            else if (newPassword == oldPassword || newPassword.Equals(""))
            {
                Message = "New password Must be filled and cannot be the same with old password";
            }
            else if (newPassword != confirmPassword)
            {
                Message = "Confirm Pasword must be same with New Password";
            }
            
            else
            {
                Message = "Password successfully changed";
                UserHandler.changePassword(email, newPassword);
            }


            return Message;
        }
    }
}