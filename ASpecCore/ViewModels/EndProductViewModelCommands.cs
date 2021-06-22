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
        public delegate bool MatchToCurrentDwgHandler(view_endproduct_cut CurrentEndProduct);

        #region MathToCurrentDwgCommand
        public ICommand MathToCurrentDwgCommand { get; }
        private void OnMathToCurrentDwgCommandExecuted ( object p)
        {
            if (_Handler == null)
            {
                Messages.ErrorMessage("Не зарегистрировано действие");
            }
            else
            {
                _Handler.Invoke(SelectedProduct);
            }
        }

        private bool CanMathToCurrentDwgCommandExecute(object p)
        {
            return SelectedProduct != null;
        }
        #endregion

        #region DelegateRegisters
        public void RegisterMatchToCurrentDwgHandler(MatchToCurrentDwgHandler Value)
        {
            _Handler = Value;
        }

        //public void RegisterMatchToCurrentDwgHandler(Func<view_endproduct_cut, bool> matchSelEndProd)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private MatchToCurrentDwgHandler _Handler;
    }
}
