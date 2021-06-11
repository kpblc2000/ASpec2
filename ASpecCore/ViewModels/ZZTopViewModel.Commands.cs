using ASpecCore.Views;
using ASpecCore.Views.Messages;
using ASpecCore.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public partial class ZZTopViewModel
    {
        #region CheckResultCommand

        public ICommand CheckResultCommand { get; }
        private void OnCheckResultCommandExecuted(object obj)
        {
            Messages.InfoMessage($"{Name} : {_AlbumVM.SelectedAlbum.name_alb}");
        }

        private bool CanCheckResultCommandExecute(object arg) => true;
        #endregion

        #region SetDocumentCommand
        public ICommand SetDocumentCommand { get; }
        private void OnSetDocumentCommandExecuted(object p)
        {
            ContentControl obj = p as ContentControl;
            if (obj != null)
            {
                obj.Content = new NormDocUserControl();
                obj.DataContext = new NormDocViewModel();
            }
        }
        private bool CanSetDocumentCommandExecute(object p)
        {
            return true;
        }
        #endregion

        #region SetAlbumCommand
        public ICommand SetAlbumCommand { get; }
        private void OnSetAlbumCommandExecuted(object p)
        {
            ContentControl obj = p as ContentControl;
            if (obj != null)
            {
                obj.Content = new AlbumUserControl();
                obj.DataContext = new AlbumViewModel();
            }
        }
        private bool CanSetAlbumCommandExecute(object p)
        {
            return true;
        }
        #endregion

        #region SetEndProductCommand
        public ICommand SetEndProductCommand { get; }
        private void OnSetEndProductCommandExecuted(object p)
        {
            ContentControl obj = p as ContentControl;
            if (obj != null)
            {
                obj.Content = new EndProductUserControl();
                obj.DataContext = new EndProductViewModel();
            }
        }
        private bool CanSetEndProductCommandExecute(object p)
        {
            return true;
        }
        #endregion
    }
}
