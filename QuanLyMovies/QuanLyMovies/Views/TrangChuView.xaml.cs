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
        public TrangChuView()
        {
            InitializeComponent();
            // Manually alter window height and width
            this.SizeToContent = SizeToContent.Manual;

            //// Automatically resize width relative to content
            //this.SizeToContent = SizeToContent.Width;

            //// Automatically resize height relative to content
            //this.SizeToContent = SizeToContent.Height;

            //// Automatically resize height and width relative to content
            //this.SizeToContent = SizeToContent.WidthAndHeight;.
                // lbds.DataContext = ocMH;
                vm = new UtilViewModel();
                DataContext = vm;

                
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
    }
}
