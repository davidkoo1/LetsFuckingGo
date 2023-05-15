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
    public class UsersViewModel : ViewModelBase
    {
        public UsersListingViewModel UsersListingViewModel { get; }
        public UsersDitailsViewModel UsersDitailsViewModel { get; }
        public ICommand AddUserCommand { get; }

        public UsersViewModel(UsersStore usersStore, SelectedUserStore _selectedUserStore, ModalNavigationStore modalNavigationStore)
        {
            UsersListingViewModel = UsersListingViewModel.LoadViewModel(usersStore, _selectedUserStore, modalNavigationStore);
            UsersDitailsViewModel = new UsersDitailsViewModel(_selectedUserStore);

            AddUserCommand = new OpenAddUserCommand(usersStore, modalNavigationStore);
        }
    }
}
