using QuanLyMovies.Models;
using QuanLyMovies.Views;
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
        public static readonly DependencyProperty NguoiDungPeoperty;
        public static readonly DependencyProperty TheLoaiPeoperty;
        public static readonly DependencyProperty PhimPeoperty;

        static UtilViewModel()
        {
            DSMovieProperty = DependencyProperty.Register("DSMovie", typeof(IList<PHIM>), typeof(UtilViewModel));
            NguoiDungPeoperty = DependencyProperty.Register("NguoiDung", typeof(ObservableCollection<TAIKHOAN>), typeof(UtilViewModel));
            TheLoaiPeoperty = DependencyProperty.Register("TheLoai", typeof(ObservableCollection<THELOAI>), typeof(UtilViewModel));
            PhimPeoperty = DependencyProperty.Register("Phim", typeof(ObservableCollection<PHIM>), typeof(UtilViewModel));
        }
        public IList<PHIM> DSMovie
        {
            get => (IList<PHIM>)GetValue(DSMovieProperty);
            set => SetValue(DSMovieProperty, value);
        }
        public ObservableCollection<TAIKHOAN> DSNguoiDung
        {
            get => (ObservableCollection<TAIKHOAN>)GetValue(NguoiDungPeoperty);
            set => SetValue(NguoiDungPeoperty, value);
        }
        public ObservableCollection<THELOAI> DSTheLoai
        {
            get => (ObservableCollection<THELOAI>)GetValue(TheLoaiPeoperty);
            set => SetValue(TheLoaiPeoperty, value);
        }
        public ObservableCollection<PHIM> DSPhim
        {
            get => (ObservableCollection<PHIM>)GetValue(PhimPeoperty);
            set => SetValue(PhimPeoperty, value);
        }
        public TAIKHOAN NguoiDung
        {
            get => (TAIKHOAN)GetValue(NguoiDungPeoperty);
            set => SetValue(NguoiDungPeoperty, value);
        }
        public THELOAI TheLoai
        {
            get => (THELOAI)GetValue(TheLoaiPeoperty);
            set => SetValue(TheLoaiPeoperty, value);
        }
        public PHIM Phim
        {
            get => (PHIM)GetValue(PhimPeoperty);
            set => SetValue(PhimPeoperty, value);
        }
        public UtilViewModel()
        {
            using (var qlp = new QuanLyPhimEntities3())
            {
                var list = new List<PHIM>(qlp.PHIMs.ToList());
                DSMovie = Enumerable.Range(0, list.Count()).Select(i => list[i]).ToList();

                DSNguoiDung = new ObservableCollection<TAIKHOAN>(qlp.TAIKHOANs.ToList());
                DSTheLoai = new ObservableCollection<THELOAI>(qlp.THELOAIs.ToList());
                DSPhim = new ObservableCollection<PHIM>(qlp.PHIMs.ToList());
            }

        }
    }
}
