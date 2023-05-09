using appTutorial.Stores;
using appTutorial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Commands
{
    public class OpenAddTestCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TestsStore _testStore;

        public OpenAddTestCommand(TestsStore testStore, ModalNavigationStore modalNavigationStore)
        {
            _testStore = testStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            AddTestViewModel addTestViewModel = new AddTestViewModel(_testStore, _modalNavigationStore);

            _modalNavigationStore.CurrentViewModel = addTestViewModel;
        }
    }
}
