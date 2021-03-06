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
using System.Windows.Shapes;

namespace QuanLyMovies.Views
{
    /// <summary>
    /// Interaction logic for ManHinhChinh.xaml
    /// </summary>
    public partial class ManHinhChinh : Window
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var wdn = new DangNhapView();
            wdn.ShowDialog();
            this.Show();
            this.Close();
        }

        private void btDangKy(object sender, RoutedEventArgs e)
        {
            
            var txt = txtEmail.Text;
            var wdn = new DangKyView(txt);
            wdn.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
