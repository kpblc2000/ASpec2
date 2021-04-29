using ASpecCore.Infrastructure;
using ASpecCore.Models;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ASpecCore.ViewModels
{
    public class NormDocViewModel : ViewModel
    {
        public NormDocViewModel()
        {
            Title = "Добавление нового нормативного документа";
            NormDocTypeViewModel = new NormDocTypeViewModel();
        }

        private NormDocTypeViewModel _NormDocTypeViewModel;
        public NormDocTypeViewModel NormDocTypeViewModel
        {
            get { return _NormDocTypeViewModel; }
            set { Set(ref _NormDocTypeViewModel, value); }
        }

        public ObservableCollection<NormDocType> NormDocTypes => _NormDocTypeViewModel.NormDocTypes;

        private NormDocType _CurrentNormDocType;

        internal void Save()
        {
            MessageBox.Show("OnSaveClick");
        }

        public NormDocType CurrentNormDocType
        {
            get { return _CurrentNormDocType; }
            set { Set(ref _CurrentNormDocType, value); }
        }

        private NormDoc _CurrentNormDoc;
        public NormDoc CurrentNormDoc
        {
            get { return _CurrentNormDoc; }
            set { Set(ref _CurrentNormDoc, value); }
        }
    }
}
