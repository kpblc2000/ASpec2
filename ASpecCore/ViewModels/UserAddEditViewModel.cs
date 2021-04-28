using ASpecCore.Models;
using ASpecCore.ViewModels.Base;

namespace ASpecCore.ViewModels
{
    public class UserAddEditViewModel : ViewModel
    {
        private User _CurrentUser;
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
                Set(ref _CurrentUser, temp);
            }
        }
    }
}
