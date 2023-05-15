using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appTutorial.EntityFramework.DTOs;

namespace appTutorial.EntityFramework
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions options) : base(options) { }

        public DbSet<UserDto> Users { get; set; }
    }
}
