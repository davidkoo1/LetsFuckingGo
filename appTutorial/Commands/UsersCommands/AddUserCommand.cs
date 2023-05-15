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
    public class AddUserCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly AddUserViewModel _addUserViewModel;
        private readonly UsersStore _usersStore;

        public AddUserCommand(AddUserViewModel addUserViewModel, UsersStore usersStore, ModalNavigationStore modalNavigationStore)
        {
            _addUserViewModel = addUserViewModel;
            _usersStore = usersStore;
            _modalNavigationStore = modalNavigationStore;
        }
            
        public override async Task ExecuteAsync(object parameter)
        {
            UserDitailsFormViewModel formViewModel =  _addUserViewModel.UserDitailsFormViewModel;
            User user = new User(Guid.NewGuid(), 
                formViewModel.Username, 
                formViewModel.UserSurname, 
                formViewModel.UserLogin, 
                formViewModel.UserPassword, 
                formViewModel.UserStanding, 
                formViewModel.UserStatus = false); //Status/online/offline
                        //последний параметр под вопросом, типо как его изменять если мы вошли тогда->асинхронные изменения 

            try
            {
                await _usersStore.Add(user);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
