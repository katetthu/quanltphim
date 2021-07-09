
using Microsoft.Win32;
using QuanLyMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyMovies.Views
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        public AdminView()
        {
            UtilViewModel vm;
            InitializeComponent();
            this.SizeToContent = SizeToContent.Manual;
            vm = new UtilViewModel();
            DataContext = vm;
        }

        private void btTrangChu(object sender, RoutedEventArgs e)
        {
            var wdn = new TrangChuView();
            wdn.Show();
        }

        private void btBrowse(object sender, RoutedEventArgs e)
        {
            var screen = new OpenFileDialog();
            if (screen.ShowDialog() == true)
            {
                string imageTemp = "";
                var info = new FileInfo(screen.FileName);
                var folder = AppDomain.CurrentDomain.BaseDirectory;
                var foderSub  = folder.Substring(0, folder.Length-11);

                foderSub += "\\ImageMovies\\";
                string fileN = screen.FileName;
                var temp = info.Name;
                //File.Copy(fileN, foderSub + temp);
                imageTemp = "../ImageMovies/" + temp;
                dataImage.Text = imageTemp;
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btBrowseVideo(object sender, RoutedEventArgs e)
        {
            var screen = new OpenFileDialog();
            if (screen.ShowDialog() == true)
            {
                string imageTemp = "";
                var info = new FileInfo(screen.FileName);
                var folder = AppDomain.CurrentDomain.BaseDirectory;
                var foderSub = folder.Substring(0, folder.Length - 11);

                foderSub += "\\VideoMovies\\";
                string fileN = screen.FileName;
                var temp = info.Name;
                //File.Copy(fileN, foderSub + temp);
                imageTemp = "../VideoMovies/" + temp;
                dataVideo.Text = imageTemp;
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btBrowseInfo(object sender, RoutedEventArgs e)
        {
            var screen = new OpenFileDialog();
            if (screen.ShowDialog() == true)
            {
                string imageTemp = "";
                var info = new FileInfo(screen.FileName);
                var folder = AppDomain.CurrentDomain.BaseDirectory;
                var foderSub = folder.Substring(0, folder.Length - 11);

                foderSub += "\\InfoMovies\\";
                string fileN = screen.FileName;
                var temp = info.Name;
                //File.Copy(fileN, foderSub + temp);
                imageTemp = "../InfoMovies/" + temp;
                dataInfo.Text = imageTemp;
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
