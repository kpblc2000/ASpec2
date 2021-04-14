using ASpecCore.Models;
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
    /// Логика взаимодействия для UserAddEditView.xaml
    /// </summary>
    public partial class UserAddEditView : Window
    {
        public User CurrentUser { get; }
        public UserAddEditView(User UserToProceed)
        {
            InitializeComponent();

            CurrentUser = new User();

            if (UserToProceed != null)
            {
                CurrentUser.Domain = UserToProceed.Domain;
                CurrentUser.Login = UserToProceed.Login;
                CurrentUser.FirstName = UserToProceed.FirstName;
                CurrentUser.MiddleName = UserToProceed.MiddleName;
                CurrentUser.LastName = UserToProceed.LastName;
                CurrentUser.IsDeveloper = UserToProceed.IsDeveloper;
            }
            DataContext = CurrentUser;
        }

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
    }
}
