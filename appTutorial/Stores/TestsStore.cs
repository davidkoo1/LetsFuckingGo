using appTutorial.Domain.Commands;
using appTutorial.Domain.Models;
using appTutorial.Domain.Queries;
using System;
using System.Threading.Tasks;

namespace appTutorial.Stores
{
    public class TestsStore
    {
        private readonly IGetAllTestsQuery _getAllTestsQuery;
        private readonly ICreateTestCommand _createTestCommand;
        private readonly IUpdateTestCommand _updateTestCommand;
        private readonly IDeleteTestCommand _deleteTestCommand;

        public TestsStore(
                          IGetAllTestsQuery getAllTestsQuery, 
                          ICreateTestCommand createTestCommand, 
                          IUpdateTestCommand updateTestCommand, 
                          IDeleteTestCommand deleteTestCommand
            )
        {
            _getAllTestsQuery = getAllTestsQuery;
            _createTestCommand = createTestCommand;
            _updateTestCommand = updateTestCommand;
            _deleteTestCommand = deleteTestCommand;
        }

        public event Action<Test> TestAdded;
        public event Action<Test> TestUpdated;
        public async Task Add(Test test)
        {
            await _createTestCommand.Execute(test);

            TestAdded?.Invoke(test);
        }

        public async Task Update(Test test)
        {
            await _updateTestCommand.Execute(test);

            TestUpdated?.Invoke(test);
        }
    }
}
