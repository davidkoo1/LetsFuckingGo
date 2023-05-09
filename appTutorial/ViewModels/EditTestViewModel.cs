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
    public class EditTestViewModel : ViewModelBase
    {
        public Guid TestID { get; }
        public TestDitailsFormViewModel TestDitailsFormViewModel { get; }

        public EditTestViewModel(Test test, TestsStore testsStore, ModalNavigationStore modalNavigationStore)
        {
            TestID = test.TestID;

            ICommand submitTestCommand = new EditTestCommand(this, testsStore, modalNavigationStore);
            ICommand cancelTestCommand = new CloseModalCommand(modalNavigationStore);
            TestDitailsFormViewModel = new TestDitailsFormViewModel(submitTestCommand, cancelTestCommand)
            {             
                Testname = test.Testname,
                TestDiscription = test.TestDiscription,
                TestTime = test.TestTime,
                AutorID = test.AutorID
            };
        }
    }
}
