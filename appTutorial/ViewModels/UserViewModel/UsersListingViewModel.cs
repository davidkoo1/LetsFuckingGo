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
        private readonly UsersStore _usersStore;
        private readonly ModalNavigationStore _modalNavigationStore;
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


        public ICommand LoadUsersCommand { get; }

        public UsersListingViewModel(UsersStore usersStore, SelectedUserStore selectedUserStore, ModalNavigationStore modalNavigationStore)
        {
            _usersStore = usersStore;
            _selectedUserStore = selectedUserStore;
            _modalNavigationStore = modalNavigationStore;
            _usersListingItemViewModels = new ObservableCollection<UsersListingItemViewModel>();

            LoadUsersCommand = new LoadUsersCommand(usersStore);

            _usersStore.UsersLoaded += UsersStore_UsersLoaded;
            _usersStore.UserAdded += UsersStore_UserAdded;
            _usersStore.UserUpdated += UsersStore_UserUpdated;
            /*
            AddUser(new User(1, "Alex", "David", "LoginD", "PasswordD", "Student", true), modalNavigationStore);
            AddUser(new User(2, "Sean", "Oye", "LoginS", "PasswordS", "Admin", true), modalNavigationStore);
            AddUser(new User(3, "Alan", "IdotKnow", "LoginA", "PasswordA", "Teacher", false), modalNavigationStore);
            */
        }

        private void UsersStore_UsersLoaded()
        {
            _usersListingItemViewModels.Clear();

            foreach (User user in _usersStore.Users)
            {
                AddUser(user);
            }
        }

        public static UsersListingViewModel LoadViewModel(UsersStore usersStore, SelectedUserStore selectedUserStore, ModalNavigationStore modalNavigationStore)
        {
            UsersListingViewModel userViewModel = new UsersListingViewModel(usersStore, selectedUserStore, modalNavigationStore);

            userViewModel.LoadUsersCommand.Execute(null);

            return userViewModel;
        }

        protected override void Dispose()
        {
            _usersStore.UsersLoaded -= UsersStore_UsersLoaded;
            _usersStore.UserUpdated -= UsersStore_UserUpdated;
            _usersStore.UserAdded -= UsersStore_UserAdded;
            

            base.Dispose();
        }
        private void UsersStore_UserUpdated(User user)
        {
            UsersListingItemViewModel userViewModel = _usersListingItemViewModels.FirstOrDefault(x => x.User.UserID == user.UserID);

            if (userViewModel != null)
                userViewModel.Update(user);
        }

        private void UsersStore_UserAdded(User user)
        {
            AddUser(user);
        }

        private void AddUser(User user)
        {

            UsersListingItemViewModel item = new UsersListingItemViewModel(user, _usersStore, _modalNavigationStore);
            _usersListingItemViewModels.Add(item);
        }
    }
}
