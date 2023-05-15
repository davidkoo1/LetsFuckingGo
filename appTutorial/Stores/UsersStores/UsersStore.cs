using appTutorial.Domain.Commands;
using appTutorial.Domain.Models;
using appTutorial.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Stores
{
    public class UsersStore
    {

        private readonly IGetAllUsersQuery _getAllUsersQuery;
        private readonly ICreateUserCommand _createUserCommand;
        private readonly IUpdateUserCommand _updateUserCommand;
        private readonly IDeleteUserCommand _deleteUserCommand;

        private readonly List<User> _users;
        public IEnumerable<User> Users => _users;

        public event Action UsersLoaded;
        public event Action<User> UserAdded;
        public event Action<User> UserUpdated;
//        public event Action<Guid> UserDeleted;


        public UsersStore(IGetAllUsersQuery getAllTestsQuery,
                  ICreateUserCommand createTestCommand,
                  IUpdateUserCommand updateUserCommand,
                  IDeleteUserCommand deleteUserCommand)
        {
            _getAllUsersQuery = getAllTestsQuery;
            _createUserCommand = createTestCommand;
            _updateUserCommand = updateUserCommand;
            _deleteUserCommand = deleteUserCommand;

            _users = new List<User>();
        }

        public async Task Load()
        {
            IEnumerable<User> users = await _getAllUsersQuery.Execute();

            _users.Clear();
            _users.AddRange(users);

            UsersLoaded?.Invoke();
        }

        public async Task Add(User user)
        {
            await _createUserCommand.Execute(user);

             _users.Add(user);

            UserAdded?.Invoke(user);
        }

        public async Task Updated(User user)
        {
            await _updateUserCommand.Execute(user);

            int currentUserIndex = _users.FindIndex(x => x.UserID == user.UserID);

            if (currentUserIndex != -1)
                _users[currentUserIndex] = user;
            else
                _users.Add(user);

            UserUpdated?.Invoke(user);
        }
        
    }
}
