using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using SupportTicketSystem.Command.App;
using SupportTicketSystem.Command.Base;
using SupportTicketSystem.Data.Base;
using SupportTicketSystem.Model.App;
using SupportTicketSystem.Model.Base;

namespace SupportTicketSystem.ViewModel.Base
{
    public abstract class PageViewModelAppBase<T, TDataViewModel> : PageViewModelBase<T, TDataViewModel>
        where T : IDomainClass, new()
        where TDataViewModel : class, IDataViewModel<T>, new()
    {

        private Dictionary<PageViewModelStatus, Dictionary<string, CommandBase>> _allCommands;

        public PageViewModelAppBase()
        {
            
            CommandBase deleteCmd = new ClosedCommand<T, TDataViewModel>(_catalog, this);
            CommandBase createCmd = new CreateCommand<T, TDataViewModel>(_catalog, this);
            CommandBase updateCmd = new UpdateCommand<T, TDataViewModel>(_catalog, this);

            
            CommandBase setReadDeleteViewStateCmd = new SetViewStatusCommand<TDataViewModel>(this, PageViewModelStatus.Open);
            CommandBase setCreateViewStateCmd = new SetViewStatusCommand<TDataViewModel>(this, PageViewModelStatus.Create);
            CommandBase setUpdateViewStateCmd = new SetViewStatusCommand<TDataViewModel>(this, PageViewModelStatus.Update);

            
            Dictionary<string, CommandBase> readDeleteCommands = new Dictionary<string, CommandBase>();
            readDeleteCommands.Add("Create...", setCreateViewStateCmd);
            readDeleteCommands.Add("Update...", setUpdateViewStateCmd);
            readDeleteCommands.Add("Delete", deleteCmd);

           
            Dictionary<string, CommandBase> createCommands = new Dictionary<string, CommandBase>();
            createCommands.Add("Read/Delete...", setReadDeleteViewStateCmd);
            createCommands.Add("New", setCreateViewStateCmd);
            createCommands.Add("Save", createCmd);

            
            Dictionary<string, CommandBase> updateCommands = new Dictionary<string, CommandBase>();
            updateCommands.Add("Read/Delete...", setReadDeleteViewStateCmd);
            updateCommands.Add("Create...", setCreateViewStateCmd);
            updateCommands.Add("Update", updateCmd);

           
            _allCommands = new Dictionary<PageViewModelStatus, Dictionary<string, CommandBase>>();
            _allCommands.Add(PageViewModelStatus.Open, readDeleteCommands);
            _allCommands.Add(PageViewModelStatus.Create, createCommands);
            _allCommands.Add(PageViewModelStatus.Update, updateCommands);

    
            _viewStatusChanged += OnViewStateHasChanged;

     
            SetStatus(PageViewModelStatus.Open);
        }

        public override void SetStatus(PageViewModelStatus open)
        {
            SetState(open);
        }

        public List<string> ViewCommandsDesc
        {
            get { return CurrentCommands.Keys.ToList(); }
        }

        public List<CommandBase> ViewCommandsObj
        {
            get { return CurrentCommands.Values.ToList(); }
        }

        
        public string ViewStateDesc
        {
            get
            {
                string header = "Tilstand: ";
                if (_status == PageViewModelStatus.Open) header += "Read/Delete";
                if (_status == PageViewModelStatus.Create) header += "Create";
                if (_status == PageViewModelStatus.Update) header += "Update";
                return header;
            }
        }


        public Dictionary<string, CommandBase> CurrentCommands
        {
            get { return _allCommands[_status]; }
        }
        public List<CommandBase> CurrentCommandsObj
        {
            get { return CurrentCommands.Values.ToList(); }
        }

        public ICommand CreateCommandObj
        {
            get { return new CreateCommand<T, TDataViewModel>(_catalog, this); }
        }


        protected override ICatalog<T> GetCatalog()
        {
            return DomainModel.GetCatalog<T>();
        }

        protected override void NotifyCommands()
        {
            foreach (var cmd in CurrentCommands.Values)
            {
                cmd.RaiseCanExecuteChanged();
            }
        }

        private void OnViewStateHasChanged(PageViewModelStatus newState)
        {
            OnPropertyChanged(nameof(ViewCommandsDesc));
            OnPropertyChanged(nameof(ViewCommandsObj));
            OnPropertyChanged(nameof(ViewStateDesc));
        }
    }
}