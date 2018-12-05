using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using SupportTicketSystem.Annotations;
using SupportTicketSystem.Command;
using SupportTicketSystem.Model;

namespace SupportTicketSystem
{
    public class UserLoginPageViewModel : INotifyPropertyChanged
    {
        private UserLoginCatalog _catalog;
        private string _user;
        private string _password;
        private ICommand _createCommand;


        public UserLoginPageViewModel(string password)
        {
            Password = password;
            _catalog = new UserLoginCatalog();
            //_createCommand = new CreateCommandBase<User>(_catalog, newUser);
        }

        public UserLoginPageViewModel()
        {
            throw new System.NotImplementedException();
        }


        public string UserName
        {
            get { return _user; }
            set
            {
                UserName = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        //public void isEnabled
        //{

        //}

        public ICommand CreateComandObj
        {
            get { return _createCommand; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}