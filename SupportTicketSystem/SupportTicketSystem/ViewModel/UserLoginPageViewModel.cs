using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using SupportTicketSystem.Model;

namespace SupportTicketSystem
{
    public class UserLoginPageViewModel : INotifyPropertyChanged
    {
        public static Frame TheRootFrame;

        private UserLoginCatalog _userCatalog;
        private string _user;
        private string _password;
        private LoginCommand _loginCommand;


        public UserLoginPageViewModel()
        {
            _password = "";
            _user = "";
            _userCatalog = new UserLoginCatalog();
            _loginCommand = new LoginCommand(TheRootFrame, _userCatalog, this);

            
        }

       


        public string UserName
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
                _loginCommand.RaiseCanExecuteChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
                _loginCommand.RaiseCanExecuteChanged();
            }
        }


        

        public ICommand LoginCommandObj
        {
            get { return _loginCommand; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}