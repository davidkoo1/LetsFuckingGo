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
        
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly UsersListingItemViewModel _usersListingItemViewModel;
        private readonly UsersStore _usersStore;


        public OpenEditUserCommand(UsersListingItemViewModel usersListingItemViewModel, UsersStore usersStore, ModalNavigationStore modalNavigationStore)
        {
            _usersListingItemViewModel = usersListingItemViewModel;
            _usersStore = usersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object parameter)
        {
            User user = _usersListingItemViewModel.User;

            EditUserViewModel editUserViewModel = new EditUserViewModel(user, _usersStore, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editUserViewModel;
        }
    }
}
