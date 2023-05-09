using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appTutorial.ViewModels
{
    public class TestDitailsFormViewModel : ViewModelBase
    {
        /*
        private Guid _testid;
        public Guid TestID
        {
            get
            {
                return _testid;
            }
            set
            {
                _testid = value;
                OnPropertyChanged(nameof(TestID));
                
            }
        }*/
        private string _testname;
        public string Testname
        {
            get
            {
                return _testname;
            }
            set
            {
                _testname = value;
                OnPropertyChanged(nameof(Testname));
                OnPropertyChanged(nameof(CanTestSubmit));
            }
        }

        private string _testDiscription;
        public string TestDiscription
        {
            get
            {
                return _testDiscription;
            }
            set
            {
                _testDiscription = value;
                OnPropertyChanged(nameof(TestDiscription));
            }
        }

        private int _testTime;
        public int TestTime
        {
            get
            {
                return _testTime;
            }
            set
            {
                _testTime = value;
                OnPropertyChanged(nameof(TestTime));
            }
        }

        private int _autorId;
        public int AutorID
        {
            get
            {
                return _autorId;
            }
            set
            {
                _autorId = value;
                OnPropertyChanged(nameof(AutorID));
            }
        }


        public bool CanTestSubmit => !string.IsNullOrEmpty(Testname);

        public ICommand SubmitTestCommand { get; }
        public ICommand CancelTestCommand { get; }

        public TestDitailsFormViewModel(ICommand submitTestCommand, ICommand cancelTestCommand)
        {
            SubmitTestCommand = submitTestCommand;
            CancelTestCommand = cancelTestCommand;
        }

    }
}
