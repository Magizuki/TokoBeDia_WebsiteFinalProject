using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Repository;
using FinalProject_TokoBeDia.Factory;

namespace FinalProject_TokoBeDia.Handler
{
    public class UserHandler
    {
        public static void RegisterUser(String name, String email, String password, String gender)
        {
            UserRepository.RegisterUser(UserFactory.CreateNewUser(name, email, password, gender));
        }

        public static Boolean cekEmail (String email)
        {
            return UserRepository.cekEmail(email);
        }

        public static Boolean cekPass(String pass, String email)
        {
            return UserRepository.cekPass(pass,email);
        }

        public static String getName(String email)
        {
            return UserRepository.getName(email);
        }

        public static int getUserID(String email)
        {
            return UserRepository.getUserID(email);
        }

        public static int getRoleID(String email)
        {
            return UserRepository.getRoleID(email);
        }

        public static String getRoleName(String email)
        {
            return UserRepository.getRoleName(email);
        }

        public static String getStatus(String email)
        {
            return UserRepository.getStatus(email);
        }

        public static String getGender(String email)
        {
            return UserRepository.getGender(email);
        }

        public static object GetAllUserData(String email)
        {
            return UserRepository.GetAllUserData(email);
        }

        public static void ChangeStatusToActive(String email)
        {
            UserRepository.ChangeStatusToActive(email);
        }

        public static void ChangeStatusToBlocked(String email)
        {
            UserRepository.ChangeStatusToBlocked(email);
        }

        public static void ChangeRoleToAdmin(String email)
        {
            UserRepository.ChangeRoleToAdmin(email);
        }

        public static void ChangeRoleToMember(String email)
        {
            UserRepository.ChangeRoleToMember(email);
        }

        public static void UpdateUser(String name, String emailBefore, String emailAfter, String gender)
        {
            UserRepository.updateUser(name, emailBefore, emailAfter, gender);
        }
        public static void changePassword(String email, String newPassword)
        {
            UserRepository.changePassword(email, newPassword);
        }

    }
}