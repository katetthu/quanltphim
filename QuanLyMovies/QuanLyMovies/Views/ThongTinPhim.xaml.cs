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
    /// Interaction logic for ThongTinPhim.xaml
    /// </summary>
    public partial class ThongTinPhim : Window
    {
        String maPhim = "";
        public ThongTinPhim()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
            using (var qlp = new QuanLyPhimEntities8())
            {
                var list = new List<TAIKHOAN>(qlp.TAIKHOANs.ToList());


            }
        }
    }
}
