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
    public class AddTestCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TestsStore _testsStore;
        private readonly AddTestViewModel _addTestViewModel;

        public AddTestCommand(AddTestViewModel addTestViewModel, TestsStore testStore, ModalNavigationStore modalNavigationStore)
        {
            _addTestViewModel = addTestViewModel;
            _testsStore = testStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            
            TestDitailsFormViewModel formViewModel = _addTestViewModel.TestDitailsFormViewModel;
            Test test = new Test(Guid.NewGuid(), formViewModel.Testname, formViewModel.TestDiscription, formViewModel.TestTime, formViewModel.AutorID);

            try
            {
                
                await _testsStore.Add(test);
               
                _modalNavigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
