using appTutorial.Commands;
using appTutorial.Domain.Models;
using appTutorial.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appTutorial.ViewModels
{
    public class TestsListingViewModel : ViewModelBase
    {
        private readonly TestsStore _testStore;
        private readonly SelectedTestStore _selectedTestStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly ObservableCollection<TestsListingItemViewModel> _testsListingItemViewModels;

        public IEnumerable<TestsListingItemViewModel> TestsListingItemViewModels => _testsListingItemViewModels;

        private TestsListingItemViewModel _selectedTestListingItemViewModel;
        public TestsListingItemViewModel SelectedTestListingItemViewModel
        {
            get
            {
                return _selectedTestListingItemViewModel;
            }
            set
            {
                _selectedTestListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedTestListingItemViewModel));

                _selectedTestStore.SelectedTest = _selectedTestListingItemViewModel?.Test;
            }
        }

        public TestsListingViewModel(TestsStore testStore, SelectedTestStore selectedTestStore, ModalNavigationStore modalNavigationStore)
        {
            _testStore = testStore;
            _selectedTestStore = selectedTestStore;
            _modalNavigationStore = modalNavigationStore;
            _testsListingItemViewModels = new ObservableCollection<TestsListingItemViewModel>();

            _testStore.TestAdded += TestStore_TestAdded;
            _testStore.TestUpdated += TestStore_TestUpdated;

            /*AddTest(new Test(1, "Test1", "Disc1", 10, 1), modalNavigationStore);
            AddTest(new Test(2, "Test2", "Disc2", -1, 2), modalNavigationStore);
            AddTest(new Test(3, "Test3", "Disc3", 6000, 1), modalNavigationStore);*/
        }
        protected override void Dispose()
        {
            _testStore.TestAdded -= TestStore_TestAdded;
            _testStore.TestAdded -= TestStore_TestUpdated;

            base.Dispose();
        }
        private void TestStore_TestAdded(Test test)
        {
            AddTest(test);
        }
        private void TestStore_TestUpdated(Test test)
        {
            TestsListingItemViewModel testViewModel = _testsListingItemViewModels.FirstOrDefault(x => x.Test.TestID == test.TestID);

            if (testViewModel != null)
                testViewModel.Update(test);
        }

        private void AddTest(Test test)
        {
            TestsListingItemViewModel itemViewModel = new TestsListingItemViewModel(test, _testStore, _modalNavigationStore);
            _testsListingItemViewModels.Add(itemViewModel);


        }
    }
}
