using ASpecCore.Infrastructure.Commands;
using ASpecCore.Infrastructure.Enums;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using ASpecCore.Views;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public class NormDocViewModel : ViewModel
    {
        public NormDocViewModel()
        {
            Title = "Нормативные документы";
            using (NPConDataModel db = new NPConDataModel())
            {
                DocList = db.normdocs.ToList();
            }
            CreateNormDocCommand = new RelayCommand(OnCreateNormDocCommandExecuted, CanCreateNormDocCommandExecute);
            EditNormDocCommand = new RelayCommand(OnEditNormDocCommandExecuted, CanEditNormDocCommandExecute);
        }

        #region Commands

        #region CreateNormDocCommand
        public ICommand CreateNormDocCommand { get; }
        private void OnCreateNormDocCommandExecuted(object p)
        {
            CreateEditNormDocViewModel vm = new CreateEditNormDocViewModel(DocList, EditMode.CreateMode);

            CreateEditNormDocView winCreate = new CreateEditNormDocView();
            winCreate.DataContext = vm;
            // CreateEditNormDocViewModel vm = winCreate.DataContext as CreateEditNormDocViewModel;
            vm.CurrentMode = EditMode.CreateMode;
            winCreate.ShowDialog();
        }
        private bool CanCreateNormDocCommandExecute(object p) => true;
        #endregion
        public ICommand EditNormDocCommand { get; }

        private void OnEditNormDocCommandExecuted(object p)
        {
            CreateEditNormDocViewModel vm = new CreateEditNormDocViewModel(DocList, EditMode.EditMode);
            
            CreateEditNormDocView winCreate = new CreateEditNormDocView();
            winCreate.DataContext = vm;
            //CreateEditNormDocViewModel vm = winCreate.DataContext as CreateEditNormDocViewModel;
            vm.CurrentMode = EditMode.EditMode;
            winCreate.ShowDialog();
        }
        private bool CanEditNormDocCommandExecute(object p) => SelectedDoc != null;
        #endregion

        #region Public properties
        public List<normdoc> DocList
        {
            get { return _DocList; }
            private set { Set(ref _DocList, value); }
        }

        public normdoc SelectedDoc
        {
            get { return _SelectedDoc; }
            set { Set(ref _SelectedDoc, value); }
        } 
        #endregion

        private List<normdoc> _DocList;
        private normdoc _SelectedDoc;
    }
}
