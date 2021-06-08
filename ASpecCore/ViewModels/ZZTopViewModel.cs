using ASpecCore.Infrastructure.Commands;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
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
            // _AlbumVM.SelectedAlbum = _AlbumVM.FilteredAlbums.Where(object => object.id_alb == 101212).FirstOrDefault();
            CheckResultCommand = new RelayCommand(OnCheckResultCommandExecuted, CanCheckResultCommandExecute);
        }

        #region CheckResultCommand
        private void OnCheckResultCommandExecuted(object obj)
        {
            MessageBox.Show($"{Name} : {_AlbumVM.SelectedAlbum.name_alb}");
        }

        private bool CanCheckResultCommandExecute(object arg) => true;

        public ICommand CheckResultCommand { get; } 
        #endregion

        public AlbumViewModel AlbumVM
        { get { return _AlbumVM; } }

        public string Name
        {
            get { return _Name; }
            set { Set(ref _Name, value); }
        }

        private string _Name;
        private AlbumViewModel _AlbumVM;
    }
}
