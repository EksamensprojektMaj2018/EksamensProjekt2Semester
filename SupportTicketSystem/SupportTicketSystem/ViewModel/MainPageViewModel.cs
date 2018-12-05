using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using SupportTicketSystem.Command.App;
using SupportTicketSystem.View;

namespace SupportTicketSystem.ViewModel
{
    public class MainPageViewModel
    {
        private static Frame _appFrame;
        private static Dictionary<string, NavigationCommand> _navigationCommands;
        private NavigationViewItem _selectedItem;
        public MainPageViewModel()
        {
            _selectedItem = null;
        }

        public NavigationViewItem SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value;
                if (_selectedItem == null) return;
                string tag = _selectedItem.Tag.ToString();
                if (!_navigationCommands.ContainsKey(tag))
                {
                    throw new ArgumentException(NoNavCommandMsg(tag));
                }

                _navigationCommands[tag].Execute(null);


            }
        }

        public static void SetAppFrame(Frame appFrame)
        {
            _appFrame = appFrame;
            _navigationCommands = new Dictionary<string, NavigationCommand>();
            AddCommands();
        }

        private static void AddCommands()
        {
            _navigationCommands.Add("OpenAllTicketView", CreateNavigationCommand(typeof(ShowAllTickets)));
            _navigationCommands.Add("OpenAllUserView", CreateNavigationCommand(typeof(ShowAllUsers)));
        }

        private static NavigationCommand CreateNavigationCommand(Type viewType)
        {
            return new NavigationCommand(_appFrame, viewType);
        }
        private static string NoNavCommandMsg(string tag)
        {
            return $"No nav command associated with Tag {tag}";
        }
    }
}