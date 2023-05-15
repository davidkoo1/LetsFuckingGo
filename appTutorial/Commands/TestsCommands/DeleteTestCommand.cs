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
    public class DeleteTestCommand : AsyncCommandBase
    {
        private readonly TestsListingItemViewModel _testsListingItemViewModel;
        private readonly TestsStore _testsStore;

        public DeleteTestCommand(TestsListingItemViewModel testsListingItemViewModel, TestsStore testsStore)
        {
            _testsListingItemViewModel = testsListingItemViewModel;
            _testsStore = testsStore;
           
        }

        public override async Task ExecuteAsync(object parameter)
        {
            Test test = _testsListingItemViewModel.Test;

            try
            {
                await _testsStore.Delete(test.TestID);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
