using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace appTutorial.ViewModels
{
    public class UserDitailsFormViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(CanUserSubmit));
            }
        }

        private string _userSurname;
        public string UserSurname
        {
            get
            {
                return _userSurname;
            }
            set
            {
                _userSurname = value;
                OnPropertyChanged(nameof(UserSurname));
            }
        }

        private string _userLogin;
        public string UserLogin
        {
            get
            {
                return _userLogin;
            }
            set
            {
                _userLogin = value;
                OnPropertyChanged(nameof(UserLogin));
            }
        }

        private string _userPassword;
        public string UserPassword
        {
            get
            {
                return _userPassword;
            }
            set
            {
                _userPassword = value;
                OnPropertyChanged(nameof(UserPassword));
            }
        }

        private string _userStanding;
        public string UserStanding
        {
            get
            {
                return _userStanding;
            }
            set
            {
                _userStanding = value;
                OnPropertyChanged(nameof(UserStanding));
            }
        }


        private bool _userStatus;
        public bool UserStatus
        {
            get
            {
                return _userStatus;
            }
            set
            {
                _userStatus = value;
                OnPropertyChanged(nameof(UserStatus));
            }
        }

        public bool CanUserSubmit => !string.IsNullOrEmpty(Username);

        public ICommand SubmitUserCommand { get; }
        public ICommand CancelUserCommand { get; }

        public UserDitailsFormViewModel(ICommand submitUserCommand, ICommand cancelUserCommand)
        {
            SubmitUserCommand = submitUserCommand;
            CancelUserCommand = cancelUserCommand;
        }

    }
}
