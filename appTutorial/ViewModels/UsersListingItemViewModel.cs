using appTutorial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appTutorial.ViewModels
{
    public class UsersListingItemViewModel : ViewModelBase
    {
        public User User { get; }

        public string Username => User.Username;

        public ICommand EditUserCommand { get; }
        public ICommand DeleteUserCommand { get; }


        public UsersListingItemViewModel(User user, ICommand editUserCommand)
        {
            User = user;
            EditUserCommand = editUserCommand;
        }
    }
}
