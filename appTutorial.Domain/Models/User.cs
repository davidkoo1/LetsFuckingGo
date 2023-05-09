using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Domain.Models
{
    public class User
    {
        public int UserID { get; }
        public string Username { get; }
        public string UserSurname { get; }
        public string UserLogin { get; }
        public string UserPassword { get; }
        public string UserStanding { get; }
        public bool UserStatus { get; }

        public User(int UserID, string Username, string UserSurname, string UserLogin, string UserPassword, string UserStanding, bool UserStatus)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.UserSurname = UserSurname;
            this.UserLogin = UserLogin;
            this.UserPassword = UserPassword;
            this.UserStanding = UserStanding;
            this.UserStatus = UserStatus;
        }
    }
}
