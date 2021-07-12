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
    /// Interaction logic for QuenPassView.xaml
    /// </summary>
    public partial class QuenPassView : Window
    {
        public QuenPassView()
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.Manual;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!txtPass.Password.Equals(txtConPass.Password))
            {
                MessageBox.Show("Password không trùng nhau!!","ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                bool check = false;
                var item = txtEmail.Text;
                using (var qlnd = new QuanLyPhimEntities8())
                {

                    foreach (var i in qlnd.TAIKHOANs)
                    {
                        if (i.EMAIL.Equals(item))
                        {
                            i.PASS = txtPass.Password;
                            check = true;
                        }
                    }
                    qlnd.SaveChanges();
                }
                if (check)
                {
                    this.Close();
                    var wdn = new DangNhapView();
                    wdn.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Email không tồn tại hoặc sai Password !!!","ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
