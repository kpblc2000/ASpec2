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
                EndProducts = new ObservableCollection<view_endproduct_cut>(db.view_endproduct_cut);
            }
        }

        public ObservableCollection<view_endproduct_cut> EndProducts
        {
            get { return _EndProducts; }
            set { Set(ref _EndProducts, value); }
        }

        private ObservableCollection<view_endproduct_cut> _EndProducts;

    }
}
