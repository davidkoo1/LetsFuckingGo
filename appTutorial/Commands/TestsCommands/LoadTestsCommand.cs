using appTutorial.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTutorial.Commands
{
    public class LoadTestsCommand : AsyncCommandBase
    {
        private readonly TestsStore _testsStore;

        public LoadTestsCommand(TestsStore testsStore)
        {
            _testsStore = testsStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await _testsStore.Load();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
