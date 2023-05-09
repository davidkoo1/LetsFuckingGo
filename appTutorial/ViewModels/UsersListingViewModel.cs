using appTutorial.Commands;
using appTutorial.Domain.Models;
using appTutorial.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appTutorial.ViewModels
{
    public class UsersListingViewModel : ViewModelBase
    {
        private readonly SelectedUserStore _selectedUserStore;

        private readonly ObservableCollection<UsersListingItemViewModel> _usersListingItemViewModels;

        public IEnumerable<UsersListingItemViewModel> UsersListingItemViewModels => _usersListingItemViewModels;

        private UsersListingItemViewModel _selectedUserListingItemViewModel;
        public UsersListingItemViewModel SelectedUserListingItemViewModel
        {
            get
            {
                return _selectedUserListingItemViewModel;
            }
            set
            {
                _selectedUserListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedUserListingItemViewModel));

                _selectedUserStore.SelectedUser = _selectedUserListingItemViewModel?.User;
            }
        }

        public UsersListingViewModel(SelectedUserStore selectedUserStore, ModalNavigationStore modalNavigationStore)
        {
            _selectedUserStore = selectedUserStore;
            _usersListingItemViewModels = new ObservableCollection<UsersListingItemViewModel>();

            AddUser(new User(1, "Alex", "David", "LoginD", "PasswordD", "Student", true), modalNavigationStore);
            AddUser(new User(2, "Sean", "Oye", "LoginS", "PasswordS", "Admin", true), modalNavigationStore);
            AddUser(new User(3, "Alan", "IdotKnow", "LoginA", "PasswordA", "Teacher", false), modalNavigationStore);
        }

        private void AddUser(User user, ModalNavigationStore modalNavigationStore)
        {
            ICommand editUserCommand = new OpenEditUserCommand(user, modalNavigationStore);
            _usersListingItemViewModels.Add(new UsersListingItemViewModel(user, editUserCommand));
        }
    }
}
