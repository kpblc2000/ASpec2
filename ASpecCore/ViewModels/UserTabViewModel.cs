using ASpecCore.Infrastructure;
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

namespace ASpecCore.ViewModels
{
    public class UserTabViewModel : ViewModel
    {

        #region Users
        
        
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

            using (NPConDataContext db = new NPConDataContext())
            {
                Users = new List<user>(db.users);
            }

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
            vm.CurrentUser = new user();

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

        public List<user> Users
        {
            get { return _Users; }
            set
            {
                _Users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        private List<user> _Users;
    }
}
