using ASpecCore.Infrastructure;
using ASpecCore.Models;
using ASpecCore.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class UserAddEditViewModel : ViewModel
    {
        
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set
            {
                User temp = new User();
                temp.FirstName = value.FirstName;
                temp.MiddleName = value.MiddleName;
                temp.LastName = value.LastName;
                temp.Domain = value.Domain;
                temp.Login = value.Login;
                temp.IsDeveloper = value.IsDeveloper;
                //_CurrentUser = value;
                //OnPropertyChanged(nameof(CurrentUser));
                Set(ref _CurrentUser, temp);
            }
        }

        private User _CurrentUser;
    }
}
