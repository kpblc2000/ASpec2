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
                EndProducts = new ObservableCollection<view_endproduct_cut>(db.view_endproduct_cut
                                                .Where(o =>
                                                        !o.name_alb.ToUpper().Contains("ALLPLAN")
                                                        && !o.name_alb.ToUpper().Contains("INTERACTIV")
                                                        )
                                                );
            }
        }

        public ObservableCollection<view_end_prod_consist> ProductContent
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
                    res = new ObservableCollection<view_end_prod_consist>(db.view_end_prod_consist
                            .Where(o => o.id_endprod_ver == _SelectedProduct.id_endprod_ver)
                            );
                }
                return res;
            }
        }

        public ObservableCollection<view_endproduct_cut> EndProducts
        {
            get { return _EndProducts; }
            set { Set(ref _EndProducts, value); }
        }
        public view_endproduct_cut SelectedProduct
        {
            get { return _SelectedProduct; }
            set
            {
                if (Set(ref _SelectedProduct, value))
                {
                    OnPropertyChanged(nameof(ProductContent));
                }
            }
        }

        private ObservableCollection<view_endproduct_cut> _EndProducts;
        private view_endproduct_cut _SelectedProduct;
    }
}
