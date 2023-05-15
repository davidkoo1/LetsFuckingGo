using appTutorial.Commands;
using appTutorial.Domain.Models;
using appTutorial.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appTutorial.ViewModels
{
    public class EditUserViewModel : ViewModelBase
    {

        public Guid UserID { get; }
        public UserDitailsFormViewModel UserDitailsFormViewModel { get; }

        public EditUserViewModel(User user, UsersStore usersStore, ModalNavigationStore modalNavigationStore)
        {
            UserID = user.UserID;

            ICommand submitUserCommand = new EditUserCommand(this, usersStore, modalNavigationStore);
            ICommand cancelUserCommand = new CloseModalCommand(modalNavigationStore);
            UserDitailsFormViewModel = new UserDitailsFormViewModel(submitUserCommand, cancelUserCommand)
            {
                Username = user.Username,
                UserSurname = user.UserSurname,
                UserLogin = user.UserLogin,
                UserPassword = user.UserPassword,
                UserStanding = user.UserStanding,
                UserStatus = user.UserStatus
            };
        }
    }
}
