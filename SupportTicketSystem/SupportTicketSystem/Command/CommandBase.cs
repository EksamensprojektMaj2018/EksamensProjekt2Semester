using System;
using System.Windows.Input;
using SupportTicketSystem.Model;

namespace SupportTicketSystem.Command
{
    // Her bruges interfacet fra Pers SimpleRPGFromScratch
    public abstract class CommandBase : INotifiableCommand
    {
        private UserLoginPageViewModel _pvm;
        private UserLoginCatalog _catalog;

        protected CommandBase(UserLoginPageViewModel pvm, UserLoginCatalog catalog)
        {
            _pvm = pvm;
            _catalog = catalog;
        }

        public bool CanExecute(object parameter)
        {
            return CanExecute();
        }

        public void Execute(object parameter)
        {
            Execute();
            // User u = _pvm.NewUser;
            // _catalog.Create(u);
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