using System.Windows.Input;

namespace SupportTicketSystem.Command
{
    // Her bruges interfacet fra Pers SimpleRPGFromScratch
    public interface INotifiableCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}