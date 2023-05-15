using appTutorial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Stores
{
    public class SelectedUserStore
    {
        private readonly UsersStore _usersStore;

        private User _selectedUser;
        public User SelectedUser
        {
            get
            {
                return _selectedUser;
            }
            set
            {
                _selectedUser = value;
                SelectedUserChanged?.Invoke();
            }
        }

        public event Action SelectedUserChanged;

        public SelectedUserStore(UsersStore usersStore)
        {
            _usersStore = usersStore;

            _usersStore.UserUpdated += UsersStore_UserUpdated;
        }

        private void UsersStore_UserUpdated(User user)
        {
            if (user.UserID == SelectedUser?.UserID)
                SelectedUser = user;
        }
    }
}
