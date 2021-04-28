using ASpecCore.Infrastructure;
using ASpecCore.Models;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class NormDocTypeViewModel : ViewModel
    {

        private ObservableCollection<NormDocType> _NormDocTypes;
        public ObservableCollection<NormDocType> NormDocTypes
        {
            get { return _NormDocTypes; }
            set { Set(ref _NormDocTypes, value); }
        }

        private NormDocType _SelectedNormDocType;
        public NormDocType SelectedNormDocType
        {
            get { return _SelectedNormDocType; }
            set { Set(ref _SelectedNormDocType, value); }
        }

        public NormDocTypeViewModel()
        {
            var temp = new List<NormDocType>
            {
                new NormDocType{Id=1, Name="ТУ"},
                new NormDocType{Id=2, Name="ГОСТ"}
            };

            NormDocTypes = new ObservableCollection<NormDocType>(temp);
        }
    }
}
