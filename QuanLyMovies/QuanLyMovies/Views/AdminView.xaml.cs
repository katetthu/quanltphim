
using QuanLyMovies.ViewModels;
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

namespace QuanLyMovies.Views
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        public AdminView()
        {
            UtilViewModel vm;
            InitializeComponent();
            this.SizeToContent = SizeToContent.Manual;
            vm = new UtilViewModel();
            DataContext = vm;
        }

        private void btTrangChu(object sender, RoutedEventArgs e)
        {
            var wdn = new TrangChuView();
            wdn.Show();
        }

    }
}
