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
    /// Логика взаимодействия для UserAddEdit.xaml
    /// </summary>
    public partial class UserAddEdit : Window
    {

       
        public UserAddEdit(User UserToProceed)
        {
            InitializeComponent();
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
