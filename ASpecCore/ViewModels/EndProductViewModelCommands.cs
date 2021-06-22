using ASpecCore.Models.Data;
using ASpecCore.ViewModels.Base;
using ASpecCore.Views.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public partial class EndProductViewModel : ViewModel
    {
        public delegate bool MatchToCurrentDwgHadler(view_endproduct_cut CurrentEndProduct);

        #region MatchToCurrentDwgCommand
        public ICommand MatchToCurrentDwgCommand { get; }
        private void OnMatchToCurrentDwgCommandExecuted(object p)
        {
            view_endproduct_cut obj = p as view_endproduct_cut;
            if (obj != null)
            {
                if (_MatchToCurrentDwgHadler == null)
                {
                    Messages.ErrorMessage("Не зарегистрировано действие");
                }
                else
                {
                    _MatchToCurrentDwgHadler.Invoke(obj);
                }
            }
        }

        private bool CanMatchToCurrentDwgCommandExecute(object p)
        {
            view_endproduct_cut obj = p as view_endproduct_cut;
            return obj != null;
        }
        #endregion

        public void RegisterMatchToCurrentDwgHadler (MatchToCurrentDwgHadler Handler)
        {
            _MatchToCurrentDwgHadler += Handler;
        }
        public void UnregisterMatchToCurrentDwgHadler(MatchToCurrentDwgHadler Handler)
        {
            _MatchToCurrentDwgHadler -= Handler;
        }

        private MatchToCurrentDwgHadler _MatchToCurrentDwgHadler;
    }
}
