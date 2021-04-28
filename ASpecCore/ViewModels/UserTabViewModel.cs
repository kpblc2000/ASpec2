using ASpecCore.Models;
using ASpecCore.ViewModels.Base;
using ASpecCore.Views;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace ASpecCore.ViewModels
{
    public class UserTabViewModel : ViewModel
    {
        #region Users
        private ObservableCollection<User> _Users;
        public ObservableCollection<User> Users
        {
            get { return _Users; }
            set { Set(ref _Users, value); }
        }
        #endregion

        #region SelectedUser
        private User _SelectedUser;
        public User SelectedUser
        {
            get { return _SelectedUser; }
            set { Set(ref _SelectedUser, value); }
        }
        #endregion

        public UserTabViewModel()
        {
            Title = "Управление пользователями";

            var lst = Enumerable.Range(1, 10)
                .Select(i => new User
                {
                    Id = i + 1,
                    Domain = $"server{i}.com",
                    FirstName = $"FirstName-{i}",
                    LastName = $"LastName-{i}",
                    MiddleName = $"MidName{i}",
                    Login = $"login{i}",
                    IsDeveloper = i % 4 == 0
                })
                .ToList();

            Users = new ObservableCollection<User>(lst);
        }

        #region ButtonClicks
        public void RemoveUser()
        {
            Users.Remove(SelectedUser);
        }

        public void AddUser()
        {
            UserAddEdit win = new UserAddEdit();
            UserAddEditViewModel vm = win.DataContext as UserAddEditViewModel;

            if (vm == null)
            {
                MessageBox.Show("Ошибка привязки данных");
                return;
            }
            vm.Title = "Добавление нового пользователя";
            vm.CurrentUser = new User();

            win.ShowDialog();
            if (win.DialogResult == true)
            {
                Users.Add(vm.CurrentUser);
            }
        }

        public void EditUser()
        {
            UserAddEdit win = new UserAddEdit();
            UserAddEditViewModel vm = win.DataContext as UserAddEditViewModel;

            if (vm == null)
            {
                MessageBox.Show("Ошибка привязки данных");
                return;
            }
            vm.Title = "Редактирование пользователя";
            vm.CurrentUser = SelectedUser;

            int idx = Users.IndexOf(SelectedUser);

            win.ShowDialog();
            if (win.DialogResult == true)
            {
                Users[idx] = vm.CurrentUser;
            }
        }

        #endregion

    }
}
