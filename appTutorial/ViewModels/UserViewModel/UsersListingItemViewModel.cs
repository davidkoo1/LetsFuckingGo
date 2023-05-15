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
    public class UsersListingItemViewModel : ViewModelBase
    {
        public User User { get; private set; }

        public string Username => User.Username;

        public ICommand EditUserCommand { get; }
        public ICommand DeleteUserCommand { get; }
        public UsersStore UsersStore { get; }
        public ModalNavigationStore ModalNavigationStore { get; }



        public UsersListingItemViewModel(User user, UsersStore usersStore, ModalNavigationStore modalNavigationStore)
        {
            User = user;
            EditUserCommand = new OpenEditUserCommand(this, usersStore, modalNavigationStore);
        }

        public void Update(User user)
        {
            User = user;

            OnPropertyChanged(nameof(Username));
        }
    }
}
