using appTutorial.Stores;
using appTutorial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Commands
{
    public class OpenAddUserCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly UsersStore _usersStore;

        public OpenAddUserCommand(UsersStore usersStore, ModalNavigationStore modalNavigationStore)
        {
            _usersStore = usersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel(_usersStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addUserViewModel;
        }
    }
}
