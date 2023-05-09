using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework
{
    public class TestsDesignTimeDbContextFactory : IDesignTimeDbContextFactory<TestsDbContext>
    {

        public TestsDbContext CreateDbContext(string[] args = null)
        {
            
            return new TestsDbContext(new DbContextOptionsBuilder().UseSqlite("Data Source=appTutotial.db").Options);
        }
    }
}
