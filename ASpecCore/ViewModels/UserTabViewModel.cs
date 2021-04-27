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
    public class UserTabViewModel : ViewModel
    {

        #region Title
        private string _Title;
        public string Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        #endregion

        #region Users
        private ObservableCollection<User> _Users;
        public ObservableCollection<User> Users
        {
            get { return _Users; }
            set
            {
                _Users = value;
                OnPropertyChanged(nameof(Users));
            }
        }
        #endregion

        #region SelectedUser
        private User _SelectedUser;
        public User SelectedUser
        {
            get
            { return _SelectedUser; }
            set
            {
                _SelectedUser = value;
                OnPropertyChanged(nameof(SelectedUser));
            }
        }
        #endregion

        public UserTabViewModel()
        {
            Title = "Тестовое окно";

            var lst = Enumerable.Range(1, 26)
                .Select(i => new User
                {
                    Id = i + 1,
                    Domain = $"server{i}.com",
                    FirstName = $"FirstName-{i}",
                    LastName = $"LastName-{i}",
                    MiddleName = $"MidName{i}",
                    Login = $"login{i}",
                    IsDeveloper = i % 5.5 == 0
                })
                .ToList();

            Users = new ObservableCollection<User>(lst);
        }

        #region ButtonClicks
        public void RemoveUser()
        {
            Users.Remove(SelectedUser);
        }
        #endregion
    }
}
