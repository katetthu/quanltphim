using QuanLyMovies.Models;
using System;
using System.Collections.Generic;
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
            DSMovieProperty = DependencyProperty.Register("DSMovie", typeof(IList<Movie>), typeof(UtilViewModel));
        }
        public IList<Movie> DSMovie
        {
            get => (IList<Movie>)GetValue(DSMovieProperty);
            set => SetValue(DSMovieProperty, value);
        }
        public UtilViewModel()
        {
            DSMovie = Enumerable.Range(0, 100).Select(i => new Movie()).ToList();
        }
    }
}
