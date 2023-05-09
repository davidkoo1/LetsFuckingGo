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
    public class OpenEditTestCommand : CommandBase
    {
        private readonly TestsListingItemViewModel _testsListingItemViewModel;
        private readonly TestsStore _testsStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditTestCommand(TestsListingItemViewModel testsListingItemViewModel, TestsStore testsStore, ModalNavigationStore modalNavigationStore)
        {
            _testsListingItemViewModel = testsListingItemViewModel;
            _testsStore = testsStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            Test test = _testsListingItemViewModel.Test;

            EditTestViewModel editTestViewModel = new EditTestViewModel(test, _testsStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editTestViewModel;
        }
    }
}
