using ASpecCore.Infrastructure;
using ASpecCore.Infrastructure.Commands;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using ASpecCore.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public partial class ArmatureViewModel : ViewModel
    {
        public ArmatureViewModel()
        {
            Title = "Арматура";
            using (NPConDataModel db = new NPConDataModel())
            {
                _AllArmatures = new ObservableCollection<view_arm_all>(db.view_arm_all);
            }

            FilteredArmatures = _AllArmatures;
            ArmatureCreateEditCommand = new RelayCommand(OnArmatureCreateEditCommandExecuted, CanArmatureCreateEditCommandExecute);
        }

        #region ArmatureCreateEditCommand
        public ICommand ArmatureCreateEditCommand { get; }
        private void OnArmatureCreateEditCommandExecuted(object p)
        {
            ArmatureCreateEditView winArmCreate = new ArmatureCreateEditView();
            ArmatureCreateEditViewModel vm = winArmCreate.DataContext as ArmatureCreateEditViewModel;
            vm.CurrentMode = Infrastructure.Enums.EditMode.EditMode;
            vm.CurrentArm = SelectedArmature;
            winArmCreate.ShowDialog();
            // ToDo Вызов окна добавления новой арматуры
        }
        private bool CanArmatureCreateEditCommandExecute(object p)
        {
            return !SqlUserRole.IsUserReadOnly;
        }
        #endregion

        public view_arm_all SelectedArmature
        {
            get { return _SelectedArmature; }
            set
            {
                Set(ref _SelectedArmature, value);
            }
        }

        public ObservableCollection<view_arm_all> FilteredArmatures
        {
            get { return _FilteredArmature; }
            private set
            {
                Set(ref _FilteredArmature, value);
            }
        }

        private ObservableCollection<view_arm_all> _AllArmatures;
        private ObservableCollection<view_arm_all> _FilteredArmature;
        private view_arm_all _SelectedArmature;
    }
}
