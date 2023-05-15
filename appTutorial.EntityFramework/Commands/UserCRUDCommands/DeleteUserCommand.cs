using appTutorial.Domain.Commands;
using appTutorial.EntityFramework.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework.Commands
{
    public class DeleteUserCommand : IDeleteUserCommand
    {
        private readonly UsersDbContextFactory _contextFactory;

        public DeleteUserCommand(UsersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Guid UserID)
        {
            using (UsersDbContext context = _contextFactory.Create())
            {
                UserDto userDto = new UserDto()
                {
                    UserID = UserID
                };

                context.Users.Remove(userDto);
                await context.SaveChangesAsync();

            }
        }
    }
}
