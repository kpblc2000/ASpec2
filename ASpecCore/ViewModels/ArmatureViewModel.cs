using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

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
