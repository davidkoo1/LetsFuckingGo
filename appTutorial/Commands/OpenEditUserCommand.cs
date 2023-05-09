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
    public class OpenEditUserCommand : CommandBase
    {
        private readonly User _user;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditUserCommand(User user,ModalNavigationStore modalNavigationStore)
        {
            _user = user;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            EditUserViewModel editUserViewModel = new EditUserViewModel(_user, _modalNavigationStore);

            _modalNavigationStore.CurrentViewModel = editUserViewModel;
        }
    }
}
