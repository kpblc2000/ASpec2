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
    /// Логика взаимодействия для UserView.xaml
    /// </summary>
    public partial class UserView : Window
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            UserAddEditView win = new UserAddEditView();
            win.ShowDialog();
        }

        private void OnEditButtonClick(object sender, RoutedEventArgs e)
        {
            UserAddEditView win = new UserAddEditView();
            win.ShowDialog();
        }
    }
}
