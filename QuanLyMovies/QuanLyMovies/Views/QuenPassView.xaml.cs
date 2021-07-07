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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!txtPass.Password.Equals(txtConPass.Password))
            {
                MessageBox.Show("ngu");
            }
            else
            {
                bool check = false;
                var item = txtEmail.Text;
                using (var qlnd = new QuanLyPhimEntities5())
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
                    var wdn = new DangNhapView();
                    wdn.Show();
                }
                else
                {
                    MessageBox.Show("doot");
                }
            }
        }
    }
}
