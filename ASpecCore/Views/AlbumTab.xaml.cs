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
    /// Логика взаимодействия для AlbumTab.xaml
    /// </summary>
    public partial class AlbumTab : Window
    {
        private AlbumTabViewModel _ViewModel; 

        public AlbumTab()
        {
            InitializeComponent();
            _ViewModel = this.DataContext as AlbumTabViewModel;
        }

        private void OnAddAlbumButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnEditButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
