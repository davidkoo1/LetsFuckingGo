using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework
{
    public class UsersDbContextFactory
    {
        private readonly DbContextOptions _options;

        public UsersDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public UsersDbContext Create()
        {
            return new UsersDbContext(_options);
        }
    }
}
