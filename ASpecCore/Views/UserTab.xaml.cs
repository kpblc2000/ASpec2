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
    
    public partial class UserTab : Window
    {

        private UserTabViewModel _ViewModel;

        public UserTab()
        {
            InitializeComponent();
            _ViewModel = DataContext as UserTabViewModel;
        }

        #region ButtonClicks

        private void OnEraseButtonClick(object sender, RoutedEventArgs e)
        {
            if (_ViewModel == null)
            {
                MessageBox.Show("Ошибка привязки данных");
                return;
            }
            _ViewModel.RemoveUser();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
  
        }

        private void OnEditButtonClick(object sender, RoutedEventArgs e)
        {

        }
        #endregion


    }
}
