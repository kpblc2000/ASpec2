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
    public class EndProductViewModel : ViewModel
    {
        public EndProductViewModel()
        {
            using (NPConDataModel db = new NPConDataModel())
            {
                EndProductList = new ObservableCollection<view_endproduct_cut>(db.view_endproduct_cut.
                                                                                    Where(o => !o.name_alb.ToUpper().StartsWith("ALLPLAN")
                                                                                            && !o.name_alb.ToUpper().StartsWith("INTER"))
                        );
                // _EndProductConsistList = new ObservableCollection<view_end_prod_consist>(db.view_end_prod_consist);
                SelectedProduct = EndProductList[0];
            }
            AlbumVM = new AlbumViewModel();
        }

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
            get { return _EndProductList; }
            private set { Set(ref _EndProductList, value); }
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

        public album SelectedAlbum
        {
            get { return _AlbumVM.SelectedAlbum; }
            set
            {
                _AlbumVM.SelectedAlbum = value;
                OnPropertyChanged(nameof(SelectedAlbum));
            }
        }

        private view_endproduct_cut _SelectedProduct;
        private ObservableCollection<view_endproduct_cut> _EndProductList;
        private ObservableCollection<view_end_prod_consist> _EndProductConsistList;
        private AlbumViewModel _AlbumVM;

    }
}
