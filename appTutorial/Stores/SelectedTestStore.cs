using appTutorial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appTutorial.Stores
{
    public class SelectedTestStore
    {
        private readonly TestsStore _testsStore;

        private Test _selectedTest;
        public Test SelectedTest
        {
            get
            {
                return _selectedTest;
            }
            set
            {
                _selectedTest = value;
                SelectedTestChanged?.Invoke();
            }
        }

        public event Action SelectedTestChanged;
        public SelectedTestStore(TestsStore testsStore)
        {
            _testsStore = testsStore;

            _testsStore.TestUpdated += TestsStore_TestUpdated;
        }

        private void TestsStore_TestUpdated(Test test)
        {
            if(test.TestID == SelectedTest?.TestID)
            {
                SelectedTest = test;
            }
        }
    }
}
