using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
public     class ASpecMainViewModel : ViewModel
    {
        public ASpecMainViewModel()
        {
            Title = "Работа с объектами";
            EndProdVM = new EndProductViewModel();
        }

        public EndProductViewModel EndProdVM
        {
            get { return _EndProdVM; }
            private set { Set(ref _EndProdVM, value); }
        }

        private EndProductViewModel _EndProdVM;

        
    }
}
