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
            UpdateList();
            CreateNormDocCommand = new RelayCommand(OnCreateNormDocCommandExecuted, CanCreateNormDocCommandExecute);
            EditNormDocCommand = new RelayCommand(OnEditNormDocCommandExecuted, CanEditNormDocCommandExecute);
        }

        #region Commands

        #region CreateNormDocCommand
        public ICommand CreateNormDocCommand { get; }
        private void OnCreateNormDocCommandExecuted(object p)
        {
            NormDocViewCreateEdit winCreate = new NormDocViewCreateEdit();
            NormDocCreateEditViewModel vm = winCreate.DataContext as NormDocCreateEditViewModel;
            vm.DocList = DocList;
            vm.CurrentMode = EditMode.CreateMode;
            winCreate.ShowDialog();
            if (vm.NeedUpdate)
            {
                UpdateList();
            }
        }
        private bool CanCreateNormDocCommandExecute(object p) => true;
        #endregion
        #region EditNormDocCommand
        public ICommand EditNormDocCommand { get; }

        private void OnEditNormDocCommandExecuted(object p)
        {
            NormDocViewCreateEdit winCreate = new NormDocViewCreateEdit();
            NormDocCreateEditViewModel vm = winCreate.DataContext as NormDocCreateEditViewModel;
            vm.DocList = DocList;
            vm.DocToEdit = SelectedDoc;
            vm.CurrentMode = EditMode.EditMode;
            winCreate.ShowDialog();
            if (vm.NeedUpdate)
            {
                UpdateList();
            }
        }
        private bool CanEditNormDocCommandExecute(object p) => SelectedDoc != null;
        #endregion

        #endregion

        public void UpdateList()
        {
            using (NPConDataModel db = new NPConDataModel())
            {
                DocList = db.normdoc.ToList();
            }
        }

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

        public void SetDocById(int Id)
        {
            _SelectedDoc = _DocList.Where(o => o.id_normdoc == Id).FirstOrDefault();
            OnPropertyChanged(nameof(SelectedDoc));
        }
        #endregion

        private List<normdoc> _DocList;
        private normdoc _SelectedDoc;
    }
}
