
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Microsoft.Win32;
using QuanLyMovies.Models;
using QuanLyMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            NameAddress.Items.Add("2019");
            NameAddress.Items.Add("2020");

        }
      
        public Random rd = new Random();

        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection1 { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        private void btTrangChu(object sender, RoutedEventArgs e)
        {
            var wdn = new TrangChuView("","");
            wdn.ShowDialog();
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

        private void CakeLive_Loaded(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();

            using (var qlnd = new QuanLyPhimEntities8())
            {
                ObservableCollection<THELOAI> spends = new ObservableCollection<THELOAI>(qlnd.THELOAIs.ToList());
                SeriesCollection = new SeriesCollection() { };
                foreach (var spend in spends)
                {
                    var pieSersies = new PieSeries
                    {
                        Title = spend.TENTHELOAI ,
                        Values = new ChartValues<ObservableValue> { new ObservableValue(rd.Next(100,999)) },
                        DataLabels = true
                    };
                    SeriesCollection.Add(pieSersies);
                }

            Chart.DataContext = this;
            }
        }
        private void Chart_DataClick(object sender, ChartPoint chartPoint)
        {
            var chart = chartPoint.ChartView as PieChart;
            foreach (PieSeries series in chart.Series)
            {
                series.PushOut = 0;
            }
            var selectedSeries = chartPoint.SeriesView as PieSeries;
            selectedSeries.PushOut = 15;
        }
        private void DoangThu_Loaded()
        {
            DateTime now = DateTime.Now;
            int second = now.Second;
            second = second /10;
           
            SeriesCollection1 = new SeriesCollection
            {
                new ColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                        new ObservableValue(rd.Next(second,9)),
                    },
                    DataLabels = true,
                }
            };

            Labels = new[]
            {
                "Tháng 1",
                "Tháng 2",
                "Tháng 3",
                "Tháng 4",
                "Tháng 5",
                "Tháng 6",
                "Tháng 7",
                "Tháng 8",
                "Tháng 9",
                "Tháng 10",
                "Tháng 11",
                "Tháng 12"
            };

            Formatter = value => value + "0M";

            DataContext = this;
        }
        private void Chart_OnDataClick(object sender, ChartPoint point)
        {

            MessageBox.Show("You clicked " + point.X + ", " + point.Y);

        }
        private void NameAddress_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = NameAddress.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Empty.", "Empty",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                    DoangThu_Loaded();
                  
            }
        }
    }
}
