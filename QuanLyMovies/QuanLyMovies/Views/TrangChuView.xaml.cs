using QuanLyMovies.Models;
using QuanLyMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for TrangChuView.xaml
    /// </summary>
    public partial class TrangChuView : Window
    {
        UtilViewModel vm;
        String email = "";
        ObservableCollection<PHIM> _listPhim = new ObservableCollection<PHIM>();

        public TrangChuView(String tk, String ten)
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.Manual;


            vm = new UtilViewModel();
            DataContext = vm;
            TenTxt.Text = ten;
            email = tk;

        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            var grid = sender as Grid;
            var me = grid.FindName("video") as MediaElement;
            me?.Play();
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            var grid = sender as Grid;
            var me = grid.FindName("video") as MediaElement;
            me?.Stop();
        }

        private void btDangXuat(object sender, RoutedEventArgs e)
        {
            var wdn = new ManHinhChinh();
            wdn.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var wdn = new ChinhSuaThongTin(email);
            wdn.Show();
        }
        private void AddMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var index1 = ListFavorite.SelectedIndex;

            if (index1 != -1)
            {
                var item2 = ListFavorite.SelectedItem;
                _listPhim.Add(item2 as PHIM);
            }
        }
        private void RemoveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var index2 = ListItMe.SelectedIndex;

            if (index2 != -1)
            {
                _listPhim.RemoveAt(index2);
            }
        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            ListItMe.ItemsSource = _listPhim;
        }
    }
}
