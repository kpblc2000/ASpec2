using ASpecCore.Models;
using ASpecCore.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для UserAddEdit.xaml
    /// </summary>
    public partial class UserAddEdit : Window
    {

        private UserAddEditViewModel vm;

        #region Текущий пользователь
        private User _CurUser;

        public User CurUser
        {
            get
            {
                return _CurUser;
            }
            set
            {
                _CurUser = new User();
                if (value == null)
                {
                    return;
                }
                _CurUser.Domain = value.Domain;
                _CurUser.Login = value.Login;
                _CurUser.FirstName = value.FirstName;
                _CurUser.MiddleName = value.MiddleName;
                _CurUser.LastName = value.LastName;
                _CurUser.Domain = value.Domain;
                _CurUser.IsDeveloper = value.IsDeveloper;
            }
        }
        #endregion

        public UserAddEdit(User UserToProceed)
        {
            InitializeComponent();
            vm = (UserAddEditViewModel)this.DataContext;
            CurUser = UserToProceed;
            vm.User = CurUser;
        }

        #region Button clicks
        private void OnAcceptButtonClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            Close();
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }
        #endregion
    }
}
