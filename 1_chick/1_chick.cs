using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_chick
{
    class Program
    {
        
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine(user.LogIn("usama", "012345").ToString());
        }
    }
    class User
    {
        public static string[,] user = { { "usama", "012345", "user" }, { "sami", "6789", "superAdmin" }, { "maair", "13579", "admin" } };
        private string _password;
        private string _userName;
        private bool _isLogin;
        private UserPermission _userPermission;
        private enum UserPermission { user, admin, superAdmin }
        public Enum LogIn(string userName, string password)
        {
            for (int i = 0; i < user.GetLength(0); i++)
            {
                if (userName == user[i, 0] && password == user[i, 1])
                {
                    _userName = userName;
                    _password = password;
                    _userPermission = (UserPermission)Enum.Parse(typeof(UserPermission), user[i, 2]);
                    break;
                }
            }
            return _userPermission;
        }
        public static void Logout(User user)
        {
            user._isLogin = false;
        }
    }
}
