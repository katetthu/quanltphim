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
    /// Interaction logic for DangKyView.xaml
    /// </summary>
    public partial class DangKyView : Window
    {

        public DangKyView(String txt)
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.Manual;
            if (!txt.Equals(""))
                txtEmailHien.Text = txt;

        }

        private void btnNextTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex + 1;
            if (newIndex >= tcSample.Items.Count)
                newIndex = 0;
            tcSample.SelectedIndex = newIndex;
        }

        private void btnBackTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = tcSample.Items.Count - 1;
            tcSample.SelectedIndex = newIndex;
        }

        private void btDangNhap(object sender, RoutedEventArgs e)
        {
            if (!txtPass.Password.Equals(txtConPass.Password))
            {
                MessageBox.Show("sai");
            }
            else
            {


                using (var qlnd = new QuanLyPhimEntities7())
                {
                    String[] list = txtDate.Text.Trim().Trim().Split(' ');
                    DateTime dateTime = DateTime.ParseExact(list[0], "MM/dd/yyyy", null);

                    var loai = "Basic";
                    try
                    {
                        loai = cbbTenLoaiThanhToan.SelectedItem.ToString();
                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }
                    var item = new TAIKHOAN();
                    item.EMAIL = txtEmailHien.Text;
                    item.PASS = txtConPass.Password;
                    item.NGAYHETHAN = dateTime;
                    item.PHONENUMBER = Int32.Parse(txtPhone.Text);
                    item.SOTAIKHOAN = Convert.ToDouble(txtCard.Text);
                    item.TENNGUOIDUNG = txtName.Text;
                    item.TENLOAITHANHTOAN = loai;

                    qlnd.TAIKHOANs.Add(item);
                    qlnd.SaveChanges();
                }

                var wdn = new DangNhapView();
                wdn.Show();

            }
        }
    }
}
