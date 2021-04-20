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
    public partial class UserView : Window
    {
        private UserViewModel _UserViewModel;
        public UserView()
        {
            InitializeComponent();
            _UserViewModel = new UserViewModel();
            DataContext = _UserViewModel;
        }

        private void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            ObservableCollection<User> lst = _UserViewModel.Users;
            Close();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            User newUser = new User();
            UserAddEditView win = new UserAddEditView(newUser);
            win.ShowDialog();
        }

        private void OnEditButtonClick(object sender, RoutedEventArgs e)
        {
            User user = UsersDataGrid.SelectedItem as User;

            if (user!=null)
            {
                UserAddEditView win = new UserAddEditView(user);
                win.ShowDialog();
                bool? res = win.DialogResult;
                if (res == true)
                {
                    user.FirstName = win.CurrentUser.FirstName;
                    user.MiddleName = win.CurrentUser.MiddleName;
                    user.LastName = win.CurrentUser.LastName;
                    user.Domain = win.CurrentUser.Domain;
                    user.Login = win.CurrentUser.Login;
                    user.IsDeveloper = win.CurrentUser.IsDeveloper;
                }
            }
        }
    }
}
