using ASpecCore.Infrastructure.Commands;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public class EndProductViewModel : ViewModel
    {
        public EndProductViewModel()
        {
            using (NPConDataModel db = new NPConDataModel())
            {
                _EndProductList = new ObservableCollection<view_endproduct_cut>(db.view_endproduct_cut.
                                                                                    Where(o => !o.name_alb.ToUpper().StartsWith("ALLPLAN")
                                                                                            && !o.name_alb.ToUpper().StartsWith("INTER"))
                        );
                SelectedProduct = _EndProductList[0];
            }
            _FilteredEndProductList = _EndProductList;
            AlbumVM = new AlbumViewModel();
            _IsFiltered = false;

            FilterProductByAlbumCommand = new RelayCommand(OnFilterProductByAlbumCommandExecuted, CanFilterProductByAlbumCommandExecute);
            CancelFilterByAlbumCommand = new RelayCommand(OnCancelFilterByAlbumCommandExecuted, CanCancelFilterByAlbumCommandExecute);
        }



        #region CancelFilterByAlbumCommand
        public ICommand CancelFilterByAlbumCommand { get; }
        private void OnCancelFilterByAlbumCommandExecuted(object obj)
        {
            _FilteredEndProductList = _EndProductList;
            _IsFiltered = false;
            OnPropertyChanged(nameof(EndProductList));
        }
        private bool CanCancelFilterByAlbumCommandExecute(object arg)
        {
            return _IsFiltered;
        }
        #endregion

        #region FilterProductByAlbumCommand
        public ICommand FilterProductByAlbumCommand { get; }
        private void OnFilterProductByAlbumCommandExecuted(object p)
        {
            if (_AlbumVM.SelectedAlbum != null)
            {
                _FilteredEndProductList = new ObservableCollection<view_endproduct_cut>(_EndProductList.Where(o => o.name_alb.Contains(_AlbumVM.SelectedAlbum.name_alb)));
                _IsFiltered = true;

                SelectedProduct = _FilteredEndProductList == null ? null : _FilteredEndProductList[0];
                OnPropertyChanged(nameof(EndProductList));
            }
        }
        private bool CanFilterProductByAlbumCommandExecute(object p)
        {
            return _AlbumVM.SelectedAlbum != null;
        }
        #endregion

        #region Public properties
        public view_endproduct_cut SelectedProduct
        {
            get { return _SelectedProduct; }
            set
            {
                if (Set(ref _SelectedProduct, value))
                {
                    OnPropertyChanged(nameof(ProductContentBySelectedProduct));
                }
            }
        }
        public ObservableCollection<view_endproduct_cut> EndProductList
        {
            get { return _FilteredEndProductList; }
            private set { Set(ref _FilteredEndProductList, value); }
        }

        public ObservableCollection<view_end_prod_consist> ProductContentBySelectedProduct
        {
            get
            {
                if (_SelectedProduct == null)
                {
                    return null;
                }
                ObservableCollection<view_end_prod_consist> res;
                using (NPConDataModel db = new NPConDataModel())
                {
                    res = new ObservableCollection<view_end_prod_consist>(db.view_end_prod_consist.Where(o => o.id_endprod_ver == _SelectedProduct.id_endprod_ver));
                }
                return res;
            }
        }

        public AlbumViewModel AlbumVM
        {
            get { return _AlbumVM; }
            set { Set(ref _AlbumVM, value); }
        }
        #endregion

        private view_endproduct_cut _SelectedProduct;
        private ObservableCollection<view_endproduct_cut> _EndProductList;
        private ObservableCollection<view_endproduct_cut> _FilteredEndProductList;
        private AlbumViewModel _AlbumVM;
        private bool _IsFiltered;
    }
}
