using System;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using SupportTicketSystem.Model;
using SupportTicketSystem.Model.Catalog;

namespace SupportTicketSystem
{
    public class LoginCommand : ICommand
    {
        private Frame _rootFrame;
        private UserLoginPageViewModel _pvm;
        private UserCatalog _userCatalog;


        public LoginCommand(Frame theRootFrame, UserCatalog userCatalog, UserLoginPageViewModel userLoginPageViewModel)
        {
            _rootFrame = theRootFrame;
            _userCatalog = userCatalog;
            _pvm = userLoginPageViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return _userCatalog.OkUser(_pvm.UserName, _pvm.Password);
        }

        public void Execute(object parameter)
        {
            _rootFrame.Navigate(typeof(MainPage), null);
        }

        public virtual void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }

}