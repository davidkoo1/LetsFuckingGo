using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework.DTOs
{
    public class UserDto
    {
        [Key]
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string UserSurname { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserStanding { get; set; }
        public bool UserStatus { get; set; }
    }
}
