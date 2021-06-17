using ASpecCore.Infrastructure.Commands;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public class FactoryViewModel : ViewModel
    {
        public FactoryViewModel()
        {
            Title = "Заводы";

            using (NPConDataModel db = new NPConDataModel())
            {
                Factories = new ObservableCollection<factory>(db.factory);
            }
            ClearSelectedFacrotyCommand = new RelayCommand(OnClearSelectedFacrotyCommandExecuted, CanClearSelectedFacrotyCommandExecute);
        }

        #region ClearSelectedFacrotyCommand
        public ICommand ClearSelectedFacrotyCommand { get; }
        private void OnClearSelectedFacrotyCommandExecuted(object p)
        {
            _SelectedFactory = null;
            ComboBox cmb = p as ComboBox;
            if(cmb!=null)
            {
                cmb.SelectedIndex = -1;
            }
        }
        private bool CanClearSelectedFacrotyCommandExecute(object p)
        {
            return _SelectedFactory != null;
        }
        #endregion
        public ObservableCollection<factory> Factories
        {
            get { return _Factories; }
            set { Set(ref _Factories, value); }
        }

        public factory SelectedFactory
        {
            get { return _SelectedFactory; }
            set { Set(ref _SelectedFactory, value); }
        }

        public factory GetFactoryById(int? Id)
        {
            if (Id != null)
            {
                return _Factories.Where(o => o.id_fact == Id).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        private ObservableCollection<factory> _Factories;
        private factory _SelectedFactory;
    }
}
