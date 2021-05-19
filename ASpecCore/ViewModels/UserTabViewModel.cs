using ASpecCore.Infrastructure;
using ASpecCore.Infrastructure.Commands;
using ASpecCore.Models;
using ASpecCore.ViewModels.Base;
using ASpecCore.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ASpecCore.ViewModels
{
    public class UserTabViewModel : ViewModel
    {

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
            Title = "Пользователи";

            var lst = Enumerable.Range(1, 10)
                .Select(i => new User
                {
                    Id = i,
                    Domain = $"server{i}.com",
                    FirstName = $"FirstName-{i}",
                    LastName = $"LastName-{i}",
                    MiddleName = $"MidName{i}",
                    Login = $"login{i}",
                    IsDeveloper = i % 4 == 0
                })
                .ToList();

            Users = new ObservableCollection<User>(lst);

            EraseUserCommand = new RelayCommand(OnEraseUserCommandExecuted, CanEraseUserCommandExecute);
            CreateUserCommand = new RelayCommand(OnCreateUserCommandExecuted, CanCreateUserCommandExecute);
        }

        #region UserCommands

        #region EraseUserCommand
        public ICommand EraseUserCommand { get; }

        private void OnEraseUserCommandExecuted(object param)
        {
            User curUser = param as User;
            if (curUser != null && Users.Contains(curUser))
            {
                Users.Remove(curUser);
            }
        }

        private bool CanEraseUserCommandExecute(object p)
        {
            return p is User curUser && Users.Contains(curUser);
        }
        #endregion
        #region CreateUserCommand

        public ICommand CreateUserCommand { get; }

        private void OnCreateUserCommandExecuted(object p)
        {
            int idx = Users.Count + 1;
            User item = new User
            {
                Id = idx,
                FirstName = $"fn_{idx}",
                MiddleName = $"mn{idx}",
                LastName = $"ln{idx}",
                Domain = $"dom{idx}",
                Login = $"log{idx}",
                IsDeveloper = idx % 7 == 0
            };
            Users.Add(item);
        }

        private bool CanCreateUserCommandExecute(object p) => true; 
        #endregion

        #endregion

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
        #endregion

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
    }
}
