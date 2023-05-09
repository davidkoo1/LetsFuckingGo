using appTutorial.Domain.Commands;
using appTutorial.EntityFramework.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.EntityFramework.Commands
{
    public class DeleteTestCommand : IDeleteTestCommand
    {
        private readonly TestsDbContextFactory _contextFactory;

        public DeleteTestCommand(TestsDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Guid TestID)
        {
            using (TestsDbContext context = _contextFactory.Create())
            {
                TestDto testDto = new TestDto()
                {
                    TestID = TestID
                };

                context.Tests.Remove(testDto);
                await context.SaveChangesAsync();

            }
        }
    }
}
