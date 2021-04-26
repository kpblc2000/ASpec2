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
    }
}
