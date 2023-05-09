using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework
{
    public class TestsDbContextFactory
    {
        private readonly DbContextOptions _options;

        public TestsDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }
        public TestsDbContext Create()
        {
           
            return new TestsDbContext(_options);
        }
    }
}
