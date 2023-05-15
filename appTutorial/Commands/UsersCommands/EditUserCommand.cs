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
    public class EditUserCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly UsersStore _usersStore;
        private readonly EditUserViewModel _editUserViewModel;

        public EditUserCommand(EditUserViewModel editUserViewModel, UsersStore usersStore, ModalNavigationStore modalNavigationStore)
        {
            _editUserViewModel = editUserViewModel;
            _usersStore = usersStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            UserDitailsFormViewModel formViewModel = _editUserViewModel.UserDitailsFormViewModel;
            User user = new User(_editUserViewModel.UserID,
                formViewModel.Username,
                formViewModel.UserSurname,
                formViewModel.UserLogin,
                formViewModel.UserPassword,
                formViewModel.UserStanding,
                formViewModel.UserStatus);

            try
            {
                await _usersStore.Updated(user);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
