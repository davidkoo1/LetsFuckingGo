using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework
{
    public class UsersDesignTimeDbContextFactory : IDesignTimeDbContextFactory<UsersDbContext>
    {

        public UsersDbContext CreateDbContext(string[] args = null)
        {
            
            return new UsersDbContext(new DbContextOptionsBuilder().UseSqlite("Data Source=appTutotial.db").Options);
        }
    }
}
