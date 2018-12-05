using System.Windows.Input;

namespace SupportTicketSystem.Command.Base
{
    public interface INotifiableCommand : ICommand
    {
            void RaiseCanExecuteChanged();
    }
}