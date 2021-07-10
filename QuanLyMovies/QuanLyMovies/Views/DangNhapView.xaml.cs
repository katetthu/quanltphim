using QuanLyMovies.Models;
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
            if ((txtemail.Text.Equals("admin@gmail.com") && txtpass.Password.Equals("admin")))
            {
                var wdn1 = new AdminView();
                wdn1.Show();
            }
            else
            {
                using (var qlp = new QuanLyPhimEntities7())
                {
                    var list = new List<TAIKHOAN>(qlp.TAIKHOANs.ToList());
                    bool check = false;
                    var ten = "";
                    foreach (var i in list)
                    {
                        if (i.EMAIL.Equals(txtemail.Text) && i.PASS.Equals(txtpass.Password))
                        {
                            check = true;
                            ten = i.TENNGUOIDUNG;
                            break;
                        }

                    }
                    if (check)
                    {
                        var tt = new TrangChuView(txtemail.Text,ten);
                        tt.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu hoặc tài khoản", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }

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
