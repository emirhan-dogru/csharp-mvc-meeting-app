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
            _users.Add(new UserInfo() {Id = 1, Name = "Ali", Email = "abc@gmail.com" , Phone = "1234567890" , WillAttend = true});
            _users.Add(new UserInfo() {Id = 2, Name = "Ahmet", Email = "abcd@gmail.com" , Phone = "1234567890" , WillAttend = false});
            _users.Add(new UserInfo() {Id = 3, Name = "Ece", Email = "abcde@gmail.com" , Phone = "1234567890" , WillAttend = true});
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
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetUserById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}