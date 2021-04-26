using ASpecCore.Infrastrucure;
using ASpecCore.Models;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    internal class UserAddEditViewModel : ViewModel
    {
        #region User
        private User _User;

        public User User
        {
            get
            {
                return _User;
            }
            set
            {
                Set(ref _User, value, nameof(User));
            }
        }
        #endregion

        private string _Title;

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                Set(ref _Title, StaticData.MakeDialogTitle(value), nameof(Title));
            }
        }
    }
}
