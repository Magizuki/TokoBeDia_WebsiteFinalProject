using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;

namespace FinalProject_TokoBeDia.Factory
{
    public class UserFactory
    {
        public static User CreateNewUser( String name, String email, String password, String gender )
        {
            User user = new User();
            user.RoleID = 2;
            user.UserName = name;
            user.UserEmail = email;
            user.UserPassword = password;
            user.UserGender = gender;
            user.UserStatus = "Active";

            return user;
        }
    }
}