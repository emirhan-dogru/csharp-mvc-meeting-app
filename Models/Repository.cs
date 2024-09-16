using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Ali", Email = "abc@gmail.com" , Phone = "1234567890" , WillAttend = true});
            _users.Add(new UserInfo() { Name = "Ahmet", Email = "abcd@gmail.com" , Phone = "1234567890" , WillAttend = true});
            _users.Add(new UserInfo() { Name = "Ece", Email = "abcde@gmail.com" , Phone = "1234567890" , WillAttend = true});
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void AddUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}