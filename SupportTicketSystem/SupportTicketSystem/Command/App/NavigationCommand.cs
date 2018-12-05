using System;
using Windows.UI.Xaml.Controls;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SupportTicketSystem.Command.Base;


namespace SupportTicketSystem.Command.App
{
    public class NavigationCommand : CommandBase
    {
        private Frame _frame;
        private Type _pageType;
        private Func<bool> _canNavigate;

        public NavigationCommand(Frame frame, Type pageType, Func<bool> canNavigate)
        {
            _frame = frame;
            _pageType = pageType;
            _canNavigate = canNavigate;
        }
        public NavigationCommand(Frame frame, Type pageType)
            : this(frame, pageType, () => true)
        {
        }
        protected override bool CanExecute()
        {
            return _canNavigate.Invoke();
        }
        protected override void Execute()
        {
            _frame.Navigate(_pageType);
        }
    }
}