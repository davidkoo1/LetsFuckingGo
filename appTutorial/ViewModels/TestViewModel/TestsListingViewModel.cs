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
        private readonly TestsStore _testsStore;
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

        public ICommand LoadTestsCommand { get; }

        public TestsListingViewModel(TestsStore testsStore, SelectedTestStore selectedTestStore, ModalNavigationStore modalNavigationStore)
        {
            _testsStore = testsStore;
            _selectedTestStore = selectedTestStore;
            _modalNavigationStore = modalNavigationStore;
            _testsListingItemViewModels = new ObservableCollection<TestsListingItemViewModel>();

            LoadTestsCommand = new LoadTestsCommand(testsStore);

            _testsStore.TestsLoaded += TestsStore_TestsLoaded;
            _testsStore.TestAdded += TestStore_TestAdded;
            _testsStore.TestUpdated += TestStore_TestUpdated;
            _testsStore.TestDeleted += TestsStore_TestDeleted;

            /*AddTest(new Test(1, "Test1", "Disc1", 10, 1), modalNavigationStore);
            AddTest(new Test(2, "Test2", "Disc2", -1, 2), modalNavigationStore);
            AddTest(new Test(3, "Test3", "Disc3", 6000, 1), modalNavigationStore);*/
        }

        private void TestsStore_TestDeleted(Guid TestID)
        {
            TestsListingItemViewModel itemTestViewModel = _testsListingItemViewModels.FirstOrDefault(x => x.Test?.TestID == TestID);

            if (itemTestViewModel != null)
                _testsListingItemViewModels.Remove(itemTestViewModel);
        }

        public static TestsListingViewModel LoadTestViewModel(TestsStore testsStore, SelectedTestStore selectedTestStore, ModalNavigationStore modalNavigationStore)
        {
            TestsListingViewModel testsViewModel = new TestsListingViewModel(testsStore, selectedTestStore, modalNavigationStore);

            testsViewModel.LoadTestsCommand.Execute(null);

            return testsViewModel;
        }
        protected override void Dispose()
        {
            _testsStore.TestAdded -= TestStore_TestAdded;
            _testsStore.TestAdded -= TestStore_TestUpdated;
            _testsStore.TestsLoaded -= TestsStore_TestsLoaded;
            _testsStore.TestDeleted -= TestsStore_TestDeleted;

            base.Dispose();
        }

        private void TestsStore_TestsLoaded()
        {
            _testsListingItemViewModels.Clear();

            foreach (Test test in _testsStore.Tests)
            {
                AddTest(test);
            }
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
            TestsListingItemViewModel itemViewModel = new TestsListingItemViewModel(test, _testsStore, _modalNavigationStore);
            _testsListingItemViewModels.Add(itemViewModel);


        }
    }
}
