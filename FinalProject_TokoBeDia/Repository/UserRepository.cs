using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_TokoBeDia.Model;


namespace FinalProject_TokoBeDia.Repository
{
    public class UserRepository
    {
        static FinalProject_TokoBeDiaEntities db = new FinalProject_TokoBeDiaEntities();

        public static Boolean cekEmail(String email)
        {
            User user = (from x in db.Users where x.UserEmail == email select x).FirstOrDefault();

            if (user == null)
            {
                return true;
            }

            return false;

        }

        public static Boolean cekPass(String pass, String email)
        {
            User user = (from x in db.Users where x.UserPassword == pass && x.UserEmail == email select x).FirstOrDefault();

            if (user == null)
            {
                return true;
            }

            return false;

        }

        public static object GetAllUserData(String email)
        {
            var user = (from x in db.Users
                        join y in db.Roles on x.RoleID equals y.RoleID
                        where x.UserEmail != email
                        select new
                        {
                            x.UserName,
                            x.UserEmail,
                            x.UserStatus,
                            y.RoleName
                        }
                        ).ToList();

            return user;
        }

        public static void ChangeStatusToActive(String email)
        {
            User user = (from x in db.Users where x.UserEmail == email select x).FirstOrDefault();
            user.UserStatus = "Active";
            db.SaveChanges();

        }

        public static void ChangeStatusToBlocked(String email)
        {
            User user = (from x in db.Users where x.UserEmail == email select x).FirstOrDefault();
            user.UserStatus = "Blocked";
            db.SaveChanges();
        }

        public static void ChangeRoleToAdmin(String email)
        {
            User user = (from x in db.Users where x.UserEmail == email select x).FirstOrDefault();
            user.RoleID = 1;
            db.SaveChanges();
        }

        public static void ChangeRoleToMember(String email)
        {
            User user = (from x in db.Users where x.UserEmail == email select x).FirstOrDefault();
            user.RoleID = 2;
            db.SaveChanges();
        }

        public static void RegisterUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static String getName(String email)
        {
            return db.Users.Where(User => User.UserEmail == email).Select(User => User.UserName).FirstOrDefault();
        }

        public static int getUserID(String email)
        {
            return db.Users.Where(User => User.UserEmail == email).Select(User => User.UserID).FirstOrDefault();
        }

        public static int getRoleID(String email)
        {
            return db.Users.Where(User => User.UserEmail == email).Select(User => User.RoleID).FirstOrDefault();
        }

        public static String getRoleName(String email)
        {
            return (from x in db.Users join y in db.Roles on x.RoleID equals y.RoleID where x.UserEmail == email select y.RoleName).FirstOrDefault();
               
        }

        public static String getStatus(String email)
        {
            return db.Users.Where(User => User.UserEmail == email).Select(User => User.UserStatus).FirstOrDefault();
        }

        public static String getGender(String email)
        {
            return db.Users.Where(User => User.UserEmail == email).Select(User => User.UserGender).FirstOrDefault();
        }

        public static void updateUser(string name, string emailBefore, string emailAfter, string gender)
        {
            User updateUser = getUser(emailBefore);
            updateUser.UserEmail = emailAfter;
            updateUser.UserName = name;
            updateUser.UserGender = gender;
            db.SaveChanges();
        }
        public static void changePassword(string email, string newPassword)
        {
            User updateUser = getUser(email);
            updateUser.UserPassword = newPassword;
            db.SaveChanges();
        }

        public static User getUser(String email)
        {
            return db.Users.Where(User => User.UserEmail == email).FirstOrDefault();
        }

    }
}