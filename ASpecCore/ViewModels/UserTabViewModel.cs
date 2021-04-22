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
    internal class UserTabViewModel : ViewModel
    {

        #region Title
        private string _Title = "Тестовое окно";

        public string Title
        {
            get { return _Title; }
            set
            {
                //if (_Title == value)
                //{
                //    return;
                //}
                //_Title = value;
                ////OnPropertyChanged("Title");
                //OnPropertyChanged(nameof(Title));
                Set(ref _Title, value, nameof(Title));
            }
        }
        #endregion

        #region Users

        private ObservableCollection<User> _Users;

        public ObservableCollection<User> Users
        {
            get { return _Users; }
            set {
                Set(ref _Users, value, nameof(Users));
            }
        }
        #endregion

        public UserTabViewModel()
        {
            var users = Enumerable.Range(1, 15)
                .Select(i => new User
                {
                    FirstName = $"FirstName{i}",
                    MiddleName = $"MidName{i}",
                    LastName = "$LastName-{i}",
                    Login = $"login-{i * 2}",
                    Domain = $"server{i}.com",
                    IsDeveloper = i % 4 == 0
                }
                );
            Users = new ObservableCollection<User>(users);
        }

    }
}
