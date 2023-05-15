using appTutorial.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Commands
{
    public class LoadUsersCommand : AsyncCommandBase
    {

        private readonly UsersStore _usersStore;

        public LoadUsersCommand(UsersStore usersStore)
        {
            _usersStore = usersStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await _usersStore.Load();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
