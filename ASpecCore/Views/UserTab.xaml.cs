using ASpecCore.Data;
using ASpecCore.Models;
using ASpecCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ASpecCore.Views
{
    /// <summary>
    /// Логика взаимодействия для UserView.xaml
    /// </summary>
    public partial class UserTab : Window
    {
        private UserTabViewModel vm;

        public UserTab()
        {
            InitializeComponent();
            vm = (UserTabViewModel)this.DataContext;
        }

        #region ButtonClicks

        private void OnEraseButtonClick(object sender, RoutedEventArgs e)
        {

            vm.Users.Remove(vm.SelectedUser);
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            User user = new User();
            UserAddEdit win = new UserAddEdit(user);
            win.ShowDialog();
            if (win.DialogResult == true)
            {
                vm.Users.Add(win.CurUser);
            }
        }

        private void OnEditButtonClick(object sender, RoutedEventArgs e)
        {
            User user = vm.SelectedUser;
            UserAddEdit win = new UserAddEdit(user);
            win.ShowDialog();
            if (win.DialogResult == true)
            {
                User selUser = vm.Users.ElementAt(vm.Users.IndexOf(user));
                vm.Users[vm.Users.IndexOf(user)] = win.CurUser;
            }
        }
        #endregion


    }
}
