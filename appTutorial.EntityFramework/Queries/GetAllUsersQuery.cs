using appTutorial.Domain.Models;
using appTutorial.Domain.Queries;
using appTutorial.EntityFramework.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework.Queries
{
    public class GetAllUsersQuery : IGetAllUsersQuery
    {
        private readonly UsersDbContextFactory _contextFactory;

        public GetAllUsersQuery(UsersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<IEnumerable<User>> Execute()
        {
            using(UsersDbContext context = _contextFactory.Create())
            {
               IEnumerable<UserDto> userDtos = await context.Users.ToListAsync();

                return userDtos.Select(x => new User(x.UserID, 
                    x.Username, 
                    x.UserSurname, 
                    x.UserLogin, 
                    x.UserPassword, 
                    x.UserStanding, 
                    x.UserStatus));
            }
        }
    }
}
