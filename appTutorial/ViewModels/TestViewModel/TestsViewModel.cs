using appTutorial.Commands;
using appTutorial.Stores;
using System.Windows.Input;

namespace appTutorial.ViewModels
{
    public class TestsViewModel : ViewModelBase
    {
        public TestsListingViewModel TestsListingViewModel { get; }
        public TestsDitailsViewModel TestsDitailsViewModel { get; }
        public ICommand AddTestCommand { get; }

        public TestsViewModel(TestsStore testStore, SelectedTestStore _selectedTestStore, ModalNavigationStore modalNavigationStore)
        {
            TestsListingViewModel = TestsListingViewModel.LoadTestViewModel(testStore, _selectedTestStore, modalNavigationStore);
            TestsDitailsViewModel = new TestsDitailsViewModel(_selectedTestStore);

            AddTestCommand = new OpenAddTestCommand(testStore, modalNavigationStore);
        }
    }
}
