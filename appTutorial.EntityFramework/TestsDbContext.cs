using appTutorial.EntityFramework.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework
{
    public class TestsDbContext : DbContext
    {
        public TestsDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TestDto> Tests { get; set; }
    }
}
