using QuanLyMovies.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyMovies.ViewModels
{
    public class UtilViewModel : DependencyObject
    {
        public static readonly DependencyProperty DSMovieProperty;

        static UtilViewModel()
        {
            DSMovieProperty = DependencyProperty.Register("DSMovie", typeof(IList<PHIM>), typeof(UtilViewModel));
        }
        public IList<PHIM> DSMovie
        {
            get => (IList<PHIM>)GetValue(DSMovieProperty);
            set => SetValue(DSMovieProperty, value);
        }
        public UtilViewModel()
        {
            using (var qlsv = new QuanLyPhimEntities())
            {
                var ocMH = new List<PHIM>(qlsv.PHIMs.ToList());
                DSMovie = Enumerable.Range(0, ocMH.Count()).Select(i => ocMH[i]).ToList();
            }

        }
    }
}
