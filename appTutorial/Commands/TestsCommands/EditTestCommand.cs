using appTutorial.Domain.Models;
using appTutorial.Stores;
using appTutorial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Commands
{
    public class EditTestCommand : AsyncCommandBase
    {
        private readonly TestsStore _testStore;
        private readonly EditTestViewModel _editTestViewModel;
        private readonly ModalNavigationStore _modalNavigationStore;

        public EditTestCommand(EditTestViewModel editTestViewModel, TestsStore testsStore, ModalNavigationStore modalNavigationStore)
        {
            _editTestViewModel = editTestViewModel;
            _testStore = testsStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            TestDitailsFormViewModel formViewModel = _editTestViewModel.TestDitailsFormViewModel;
            Test test = new Test(_editTestViewModel.TestID, formViewModel.Testname, formViewModel.TestDiscription, formViewModel.TestTime, formViewModel.AutorID);

            try
            {
                await _testStore.Update(test);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
