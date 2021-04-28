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
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { Set(ref _Title, GeneralFunctionality.MakeDialogTitle(value)); }
        }

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
    }
}
