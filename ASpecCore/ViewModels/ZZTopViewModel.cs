using ASpecCore.Infrastructure.Commands;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public class ZZTopViewModel : ViewModel
    {
        public ZZTopViewModel()
        {
            _AlbumVM = new AlbumViewModel();
            _EndProdVM = new EndProductViewModel();
            _BaseProducts = new ObservableCollection<view_endproduct_cut>(_EndProdVM.EndProducts);
            // _AlbumVM.SelectedAlbum = _AlbumVM.FilteredAlbums.Where(object => object.id_alb == 101212).FirstOrDefault();
            CheckResultCommand = new RelayCommand(OnCheckResultCommandExecuted, CanCheckResultCommandExecute);
            FilterByAlbumCommand = new RelayCommand(OnFilterByAlbumCommandExecuted, CanFilterByAlbumCommandExecute);
            ClearFilterCommand = new RelayCommand(OnClearFilterCommandExecuted, CanClearFilterCommandExecute);
        }

        #region CheckResultCommand

        public ICommand CheckResultCommand { get; }
        private void OnCheckResultCommandExecuted(object obj)
        {
            MessageBox.Show($"{Name} : {_AlbumVM.SelectedAlbum.name_alb}");
        }

        private bool CanCheckResultCommandExecute(object arg) => true;
        #endregion

        #region FilterByAlbumCommand
        public ICommand FilterByAlbumCommand { get; }

        private void OnFilterByAlbumCommandExecuted(object p)
        {
            if (_AlbumVM.SelectedAlbum != null)
            {
                _EndProdVM.EndProducts = new ObservableCollection<view_endproduct_cut>(_BaseProducts.Where(o => o.name_alb == _AlbumVM.SelectedAlbum.name_alb));
                _IsFiltered = true;
            }
        }

        private bool CanFilterByAlbumCommandExecute(object p)
        {
            return _AlbumVM.SelectedAlbum != null;
        }
        #endregion

        #region ClearFilterCommand
        public ICommand ClearFilterCommand { get; }
        private void OnClearFilterCommandExecuted(object p)
        {
            _EndProdVM.EndProducts = _BaseProducts;
            _IsFiltered = false;
        }
        private bool CanClearFilterCommandExecute(object p)
        { return _IsFiltered; }
        #endregion

        #region Public Properties
        public AlbumViewModel AlbumVM
        { get { return _AlbumVM; } }

        public EndProductViewModel EndProdVM
        { get { return _EndProdVM; } }

        public string Name
        {
            get { return _Name; }
            set { Set(ref _Name, value); }
        } 
        #endregion

        private string _Name;
        private AlbumViewModel _AlbumVM;
        private EndProductViewModel _EndProdVM;
        private ObservableCollection<view_endproduct_cut> _BaseProducts;
        private bool _IsFiltered;
    }
}
