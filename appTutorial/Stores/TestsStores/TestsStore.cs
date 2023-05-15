using appTutorial.Domain.Commands;
using appTutorial.Domain.Models;
using appTutorial.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace appTutorial.Stores
{
    public class TestsStore
    {
        private readonly IGetAllTestsQuery _getAllTestsQuery;
        private readonly ICreateTestCommand _createTestCommand;
        private readonly IUpdateTestCommand _updateTestCommand;
        private readonly IDeleteTestCommand _deleteTestCommand;

        private readonly List<Test> _tests;

        public IEnumerable<Test> Tests => _tests;


        public event Action TestsLoaded;
        public event Action<Test> TestAdded;
        public event Action<Test> TestUpdated;
        public event Action<Guid> TestDeleted;
        public TestsStore(IGetAllTestsQuery getAllTestsQuery, 
                          ICreateTestCommand createTestCommand, 
                          IUpdateTestCommand updateTestCommand, 
                          IDeleteTestCommand deleteTestCommand)
        {
            _getAllTestsQuery = getAllTestsQuery;
            _createTestCommand = createTestCommand;
            _updateTestCommand = updateTestCommand;
            _deleteTestCommand = deleteTestCommand;

            _tests = new List<Test>();
        }


        public async Task Load()
        {
            IEnumerable<Test> tests = await _getAllTestsQuery.Execute();

            _tests.Clear();
            _tests.AddRange(tests);

            TestsLoaded?.Invoke();
        }


        public async Task Add(Test test)
        {
            await _createTestCommand.Execute(test);

            _tests.Add(test);

            TestAdded?.Invoke(test);
        }

        public async Task Update(Test test)
        {
            await _updateTestCommand.Execute(test);

            int currentIndex = _tests.FindIndex(x => x.TestID == test.TestID);

            if(currentIndex != -1)
            {
                _tests[currentIndex] = test;
            }
            else
            {
                _tests.Add(test);
            }

            TestUpdated?.Invoke(test);
        }


        public async Task Delete(Guid TestID)
        {
            await _deleteTestCommand.Execute(TestID);

            _tests.RemoveAll(x => x.TestID == TestID);

            TestDeleted?.Invoke(TestID);
        }

    }
}
