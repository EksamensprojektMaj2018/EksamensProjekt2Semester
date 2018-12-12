using System;
using Windows.UI.Xaml.Controls;
using SupportTicketSystem.Model;

namespace SupportTicketSystem.Command
{
    // Her bruges interfacet fra Pers SimpleRPGFromScratch
    public abstract class CommandBase : INotifiableCommand
    {
        private Frame rootFrame;
        private UserLoginPageViewModel _pvm;
        private UserLoginCatalog _catalog;

        protected CommandBase(UserLoginPageViewModel pvm, UserLoginCatalog catalog, Frame rootFrame)
        {
            _pvm = pvm;
            _catalog = catalog;
        }

        public bool CanExecute(object parameter)
        {
            return _catalog.OkUser(_pvm.UserName, _pvm.Password);
        }

        public void Execute(object parameter)
        {
            rootFrame.Navigate(typeof(MainPage), null);
        }

        protected virtual bool CanExecute()
        {
            return true;
        }

        protected abstract void Execute();

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }

  
}