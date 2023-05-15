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
    public class AddUserViewModel : ViewModelBase
    {
        
        public UserDitailsFormViewModel UserDitailsFormViewModel { get; }

        public AddUserViewModel(UsersStore usersStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitUserCommand = new AddUserCommand(this, usersStore, modalNavigationStore);
            ICommand cancelUserCommand = new CloseModalCommand(modalNavigationStore);
            UserDitailsFormViewModel = new UserDitailsFormViewModel(submitUserCommand, cancelUserCommand);
        }
    }
}
