using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAccessModifiers1
{
    class User
    {
        public static User[] users = new User[3]
        {
            new User
            {
                _userName = "usama",
                _password = "12345",
                _userPermission = UserPermission.user,
                _isLogin = false
            },
            new User
            {
                _userName = "sami",
                _password = "67890",
                _userPermission = UserPermission.admin,
                _isLogin = false
            },
            new User
            {
                _userName = "mair",
                _password = "15975",
                _userPermission = UserPermission.superAdmin,
                _isLogin = false
            }
        };        
        private string _password;
        private string _userName;
        private bool _isLogin;
        private UserPermission _userPermission;
        private enum UserPermission {user, admin, superAdmin}
        public static Enum LogIn(string userName, string password)
        {
            for(int i = 0; i < users.Length; i++)
            {
                if (userName.ToLower() == users[i]._userName && password == users[i]._password)
                {
                    users[i]._isLogin = true;
                    return users[i]._userPermission;
                }
            }
            return null;
        }
        public static void Logout(User user)
        {
            user._isLogin = false;
        }
    }
}
