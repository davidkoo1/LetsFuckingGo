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
    public class GetAllTestsQuery : IGetAllTestsQuery
    {
        private readonly TestsDbContextFactory _contextFactory;

        public GetAllTestsQuery(TestsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Test>> Execute()
        {
            using(TestsDbContext context = _contextFactory.Create())
            {
                var testDtos = await context.Tests.ToListAsync(); 
                return testDtos.Select(x => new Test(x.TestID, x.Testname, x.TestDiscription, x.TestTime, x.AutorID));
            }
        }
    }
}
