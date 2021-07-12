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
            try
            {
                if (!txtPass.Password.Equals(txtConPass.Password))
                {
                    MessageBox.Show("Mật khẩu không trùng!!!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    using (var qlnd = new QuanLyPhimEntities8())
                    {
                        String[] list = txtDate.Text.Trim().Trim().Split(' ');
                        DateTime dateTime = DateTime.ParseExact(list[0], "MM/dd/yyyy", null);

                        var loai = "Basic";
                        try
                        {
                            loai = cbbTenLoaiThanhToan.SelectedItem as String;
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
                       
                        var wdn = new DangNhapView();
                        wdn.ShowDialog();

                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Thất bại", "Thất bại", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void ButtonClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btTrangDangNhap(object sender, RoutedEventArgs e)
        {

            Close();
            var mh = new DangNhapView();
            mh.ShowDialog();
        }

        private void btHome(object sender, RoutedEventArgs e)
        {
            Close();
            var mh = new ManHinhChinh();
            mh.ShowDialog();
        }
    }
}
