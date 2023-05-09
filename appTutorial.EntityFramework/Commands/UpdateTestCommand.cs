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
    public class UpdateTestCommand : IUpdateTestCommand
    {
        private readonly TestsDbContextFactory _contextFactory;

        public UpdateTestCommand(TestsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Test test)
        {
            using (TestsDbContext context = _contextFactory.Create())
            {
                TestDto testDto = new TestDto()
                {
                    TestID = test.TestID,
                    Testname = test.Testname,
                    TestDiscription = test.TestDiscription,
                    TestTime = test.TestTime,
                    AutorID = test.AutorID,
                };

                context.Tests.Update(testDto);
                await context.SaveChangesAsync();

            }
        }
    }
}
