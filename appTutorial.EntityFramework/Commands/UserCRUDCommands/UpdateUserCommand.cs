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
    public class UpdateUserCommand : IUpdateUserCommand
    {
        private readonly UsersDbContextFactory _contextFactory;

        public UpdateUserCommand(UsersDbContextFactory contextFactory)
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

                context.Users.Update(userDto);
                await context.SaveChangesAsync();

            }
        }
    }
}
