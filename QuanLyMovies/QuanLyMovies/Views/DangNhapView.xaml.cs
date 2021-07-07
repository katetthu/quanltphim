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
    /// Interaction logic for DangNhapView.xaml
    /// </summary>
    public partial class DangNhapView : Window
    {
        public DangNhapView()
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.Manual;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((txtemail.Text == "admin@gmail.com" || Int32.Parse(txtemail.Text) == 12345679) && txtpass.Password == "admin")
            {
                var wdn1 = new AdminView();
                wdn1.Show();
            }
            //else if (.....)
            //{
            //    var wdn2 = new TrangChuView();
            //    wdn2.Show();
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var wdn = new QuenPassView();
            wdn.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var wdn = new DangKyView("");
            wdn.Show();
        }
    }
}
