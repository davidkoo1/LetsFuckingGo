using appTutorial.Domain.Commands;
using appTutorial.Domain.Models;
using appTutorial.EntityFramework.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework.Commands
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly UsersDbContextFactory _contextFactory;

        public CreateUserCommand(UsersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(User user)
        {
            using (UsersDbContext context = _contextFactory.Create())
            {
                UserDto userDto = new UserDto()
                {
                    UserID = user.UserID,
                    Username = user.Username,
                    UserSurname = user.UserSurname,
                    UserLogin = user.UserLogin,
                    UserPassword = user.UserPassword,
                    UserStanding = user.UserStanding,
                    UserStatus = user.UserStatus,
                };

                context.Users.Add(userDto);
                await context.SaveChangesAsync();

            }
        }
    }
}
