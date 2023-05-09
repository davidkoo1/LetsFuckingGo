using appTutorial.Commands;
using appTutorial.Domain.Models;
using appTutorial.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appTutorial.ViewModels
{
    public class TestsListingItemViewModel : ViewModelBase
    {
        public Test Test { get; private set; }

        public string Testname => Test.Testname;

        public ICommand EditTestCommand { get; }
        public ICommand DeleteTestCommand { get; }


        public TestsListingItemViewModel(Test test, TestsStore testStore, ModalNavigationStore modalNavigationStore)
        {
            Test = test;

            EditTestCommand = new OpenEditTestCommand(this, testStore, modalNavigationStore);
        }

        public void Update(Test test)
        {
            Test = test;

            OnPropertyChanged(nameof(Testname));
        }
    }
}