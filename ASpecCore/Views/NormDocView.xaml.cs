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
    /// Логика взаимодействия для NormDocView.xaml
    /// </summary>
    public partial class NormDocView : Window
    {
        NormDocViewModel _ViewModel;
        public NormDocView()
        {
            InitializeComponent();
            _ViewModel = this.DataContext as NormDocViewModel;
        }

        private void OnSaveButtonClick(object sender, RoutedEventArgs e)
        {
            _ViewModel.Save();
            DialogResult = true;
            Close();
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
