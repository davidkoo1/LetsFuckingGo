using appTutorial.Domain.Models;
using appTutorial.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace appTutorial.ViewModels
{
    public class UsersDitailsViewModel : ViewModelBase 
    {
        private readonly SelectedUserStore _selectedUserStore;

        private User SelectedUser => _selectedUserStore.SelectedUser;

        public bool HasSelectedUser => SelectedUser != null;

        public string Username => SelectedUser?.Username ?? "UnknowUserName";
        public string UserSurname => SelectedUser?.UserSurname ?? "UnknowUserSurname";
        public string UserLogin => SelectedUser?.UserLogin ?? "UnknowUserLogin";
        public string UserPassword => SelectedUser?.UserPassword ?? "UnknowUserPassword";
        public string UserStanding => SelectedUser?.UserStanding ?? "UnknowUserStanding";
        public bool UserStatus => SelectedUser?.UserStatus ?? false;
        private Brush _isOnlineColor => UserStatus ? Brushes.Green : Brushes.Red;
        public Brush IsOnlineColor
        {
            get
            {
                return _isOnlineColor;
            }
            set
            {

                OnPropertyChanged(nameof(IsOnlineColor));
            }
        }

        public UsersDitailsViewModel(SelectedUserStore selectedUserStore)
        {
            _selectedUserStore = selectedUserStore;

            _selectedUserStore.SelectedUserChanged += SelectedUserStore_SelectedUserChanged;
        }

        protected override void Dispose()
        {
            _selectedUserStore.SelectedUserChanged -= SelectedUserStore_SelectedUserChanged;

            base.Dispose(); 
        }
        private void SelectedUserStore_SelectedUserChanged()
        {
            OnPropertyChanged(nameof(HasSelectedUser));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(UserSurname));
            OnPropertyChanged(nameof(UserLogin));
            OnPropertyChanged(nameof(UserPassword));
            OnPropertyChanged(nameof(UserStanding));
            OnPropertyChanged(nameof(IsOnlineColor));
        }
    }
}
