using appTutorial.Commands;
using appTutorial.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appTutorial.ViewModels
{
    public class AddTestViewModel : ViewModelBase
    {

        public TestDitailsFormViewModel TestDitailsFormViewModel { get; }

        public AddTestViewModel(TestsStore testStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitTestCommand = new AddTestCommand(this, testStore, modalNavigationStore);
            ICommand cancelTestCommand = new CloseModalCommand(modalNavigationStore);
            TestDitailsFormViewModel = new TestDitailsFormViewModel(submitTestCommand, cancelTestCommand);
        }
    }
}
