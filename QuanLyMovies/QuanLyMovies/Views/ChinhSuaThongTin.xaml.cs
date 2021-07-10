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
    /// Interaction logic for ChinhSuaThongTin.xaml
    /// </summary>
    public partial class ChinhSuaThongTin : Window
    {
        String email = "";
        String pass = "";
        public ChinhSuaThongTin(String em)
        {
            InitializeComponent();
            email = em;
            using (var qlp = new QuanLyPhimEntities7())
            {
                var list = new List<TAIKHOAN>(qlp.TAIKHOANs.ToList());
                var tk = new TAIKHOAN();
                foreach (var i in list)
                {
                    if (em.Equals(i.EMAIL))
                    {
                        tk = i;
                    }
                }
                pass = tk.PASS;
                txtCard.Text = tk.SOTAIKHOAN.ToString();
                txtName.Text = tk.TENNGUOIDUNG;
                txtPhone.Text = tk.PHONENUMBER.ToString();
                txtDate.Text = tk.NGAYHETHAN.ToString();
                txtGoi.Text = tk.TENLOAITHANHTOAN;
            }
        }

        private void btnBackTab_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            using (var qlp = new QuanLyPhimEntities7())
            {
                if (txtConPass.Password.Equals(pass))
                {
                    using (var qlps = new QuanLyPhimEntities7())
                    {
                        var list = new List<TAIKHOAN>(qlp.TAIKHOANs.ToList());
                        var ndCur1 = qlps.TAIKHOANs.Single(ng => ng.EMAIL == email);
                        ndCur1.TENNGUOIDUNG = txtName.Text.Trim();

                        qlps.SaveChanges();
                        MessageBox.Show("Update thành công", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Information);

                        Close();

                        var mh = new TrangChuView(email,txtName.Text.Trim());
                        mh.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            var mh = new ManHinhChinh();
            mh.ShowDialog();
        }
    }
}
