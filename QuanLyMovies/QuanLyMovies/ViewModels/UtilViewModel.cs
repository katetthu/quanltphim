using QuanLyMovies.Command;
using QuanLyMovies.Models;
using QuanLyMovies.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyMovies.ViewModels
{
    public class UtilViewModel : DependencyObject
    {
        public static readonly DependencyProperty DSMovieProperty;
        public static readonly DependencyProperty TheLoaiPeoperty;
        public static readonly DependencyProperty PhimPeoperty;
        public static readonly DependencyProperty NguoiDungPeoperty;
        public static readonly DependencyProperty ItemNguoiDungPeoperty;
        public static readonly DependencyProperty ItemPhimPeoperty;
        public static readonly DependencyProperty ItemTheLoaiPeoperty;
        public static readonly DependencyProperty DSVienTuongProperty;
        public static readonly DependencyProperty DSTinhCamProperty;
        public static readonly DependencyProperty DSHanhDongProperty;
        public static readonly DependencyProperty DSPhieuLuuProperty;
        public static readonly DependencyProperty DSAmNhacProperty;
        public static readonly DependencyProperty DSHaiHuocProperty;
        public static readonly DependencyProperty DSHoatHinhProperty;
        public static readonly DependencyProperty DSKinhDiProperty;

        public RelayCommand<string> CmdUpdateNguoiDung { get; }
        public RelayCommand<string> CmdAddNguoiDung { get; }
        public RelayCommand<string> CmdDeleteNguoiDung { get; }
        public RelayCommand<string> CmdUpdateVideo { get; }
        public RelayCommand<string> CmdDeleteVideo { get; }
        public RelayCommand<string> CmdUpdateTheLoai { get; }
        public RelayCommand<string> CmdAddTheLoai { get; }
        public RelayCommand<string> CmdDeleteTheLoai { get; }
        public RelayCommand<string> CmdAddVideo { get; }

        static UtilViewModel()
        {
            DSAmNhacProperty = DependencyProperty.Register("DSPhimAmNhac", typeof(IList<PHIM>), typeof(UtilViewModel));
            DSHaiHuocProperty = DependencyProperty.Register("DSPhimHaiHuoc", typeof(IList<PHIM>), typeof(UtilViewModel));
            DSHoatHinhProperty = DependencyProperty.Register("DSPhimHoatHinh", typeof(IList<PHIM>), typeof(UtilViewModel));
            DSKinhDiProperty = DependencyProperty.Register("DSPhimKinhDi", typeof(IList<PHIM>), typeof(UtilViewModel));
            DSPhieuLuuProperty = DependencyProperty.Register("DSPhimPhieuLuu", typeof(IList<PHIM>), typeof(UtilViewModel));
            DSHanhDongProperty = DependencyProperty.Register("DSPhimHanhDong", typeof(IList<PHIM>), typeof(UtilViewModel));
            DSTinhCamProperty = DependencyProperty.Register("DSPhimTinhCam", typeof(IList<PHIM>), typeof(UtilViewModel));
            DSVienTuongProperty = DependencyProperty.Register("DSPhimVienTuong", typeof(IList<PHIM>), typeof(UtilViewModel));
            DSMovieProperty = DependencyProperty.Register("DSMovie", typeof(IList<PHIM>), typeof(UtilViewModel));
            NguoiDungPeoperty = DependencyProperty.Register("NguoiDung", typeof(ObservableCollection<TAIKHOAN>), typeof(UtilViewModel));
            TheLoaiPeoperty = DependencyProperty.Register("TheLoai", typeof(ObservableCollection<THELOAI>), typeof(UtilViewModel));
            PhimPeoperty = DependencyProperty.Register("Phim", typeof(ObservableCollection<PHIM>), typeof(UtilViewModel));
            ItemNguoiDungPeoperty = DependencyProperty.Register("ItemNguoiDung", typeof(TAIKHOAN), typeof(UtilViewModel));
            ItemPhimPeoperty = DependencyProperty.Register("ItemPhim", typeof(PHIM), typeof(UtilViewModel));
            ItemTheLoaiPeoperty = DependencyProperty.Register("ItemTheLoai", typeof(THELOAI), typeof(UtilViewModel));

        }
        public IList<PHIM> DSMovie
        {
            get => (IList<PHIM>)GetValue(DSMovieProperty);
            set => SetValue(DSMovieProperty, value);
        }
        public IList<PHIM> DSPhimVienTuong
        {
            get => (IList<PHIM>)GetValue(DSVienTuongProperty);
            set => SetValue(DSVienTuongProperty, value);
        }
        public IList<PHIM> DSPhimTinhCam
        {
            get => (IList<PHIM>)GetValue(DSTinhCamProperty);
            set => SetValue(DSTinhCamProperty, value);
        }
        public IList<PHIM> DSPhimPhieuLuu
        {
            get => (IList<PHIM>)GetValue(DSPhieuLuuProperty);
            set => SetValue(DSPhieuLuuProperty, value);
        }
        public IList<PHIM> DSPhimHanhDong
        {
            get => (IList<PHIM>)GetValue(DSHanhDongProperty);
            set => SetValue(DSHanhDongProperty, value);
        }
        public IList<PHIM> DSPhimHaiHuoc
        {
            get => (IList<PHIM>)GetValue(DSHaiHuocProperty);
            set => SetValue(DSHaiHuocProperty, value);
        }
        public IList<PHIM> DSPhimKinhDi
        {
            get => (IList<PHIM>)GetValue(DSKinhDiProperty);
            set => SetValue(DSKinhDiProperty, value);
        }
        public IList<PHIM> DSPhimAmNhac
        {
            get => (IList<PHIM>)GetValue(DSAmNhacProperty);
            set => SetValue(DSAmNhacProperty, value);
        }
        public IList<PHIM> DSPhimHoatHinh
        {
            get => (IList<PHIM>)GetValue(DSHoatHinhProperty);
            set => SetValue(DSHoatHinhProperty, value);
        }
        public ObservableCollection<TAIKHOAN> DSNguoiDung
        {
            get => (ObservableCollection<TAIKHOAN>)GetValue(NguoiDungPeoperty);
            set => SetValue(NguoiDungPeoperty, value);
        }
        //public TAIKHOAN NguoiDung
        //{
        //    get => (TAIKHOAN)GetValue(NguoiDungPeoperty);
        //    set => SetValue(NguoiDungPeoperty, value);
        //}
        public TAIKHOAN ItemNguoiDung
        {
            get => (TAIKHOAN)GetValue(ItemNguoiDungPeoperty);
            set => SetValue(ItemNguoiDungPeoperty, value);
        }
        public PHIM ItemPhim
        {
            get => (PHIM)GetValue(ItemPhimPeoperty);
            set => SetValue(ItemPhimPeoperty, value);
        }
        public THELOAI ItemTheLoai
        {
            get => (THELOAI)GetValue(ItemTheLoaiPeoperty);
            set => SetValue(ItemPhimPeoperty, value);
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
            CmdUpdateNguoiDung = new RelayCommand<string>(UpdateNguoiDung);
            CmdAddNguoiDung = new RelayCommand<string>(AddNguoiDung);
            CmdDeleteNguoiDung = new RelayCommand<string>(DeleteNguoiDung);

            CmdUpdateVideo = new RelayCommand<string>(UpdateVideo);
            CmdAddVideo = new RelayCommand<string>(AddVideo);
            CmdDeleteVideo = new RelayCommand<string>(DeleteVideo);

            CmdUpdateTheLoai = new RelayCommand<string>(UpdateTheLoai);
            CmdAddTheLoai = new RelayCommand<string>(AddTheLoai);
            CmdDeleteTheLoai = new RelayCommand<string>(DeleteTheLoai);

            using (var qlp = new QuanLyPhimEntities5())
            {
                var list = new List<PHIM>(qlp.PHIMs.ToList());
                DSMovie = Enumerable.Range(0, list.Count()).Select(i => list[i]).ToList();
             
                var array= xuatPhim(list, "Viễn tưởng");
                DSPhimVienTuong = Enumerable.Range(0, array.Count()).Select(i => array[i]).ToList();
                var array1 = xuatPhim(list, "Tình cảm");
                DSPhimTinhCam = Enumerable.Range(0, array1.Count()).Select(i => array1[i]).ToList();
                var array2 = xuatPhim(list, "Hành động");
                DSPhimHanhDong = Enumerable.Range(0, array2.Count()).Select(i => array2[i]).ToList();
                var array3 = xuatPhim(list, "Phiêu Lưu");
                DSPhimPhieuLuu = Enumerable.Range(0, array3.Count()).Select(i => array3[i]).ToList();
                var array4 = xuatPhim(list, "Âm nhạc");
                DSPhimAmNhac = Enumerable.Range(0, array4.Count()).Select(i => array4[i]).ToList();
                var array5 = xuatPhim(list, "Hài hước");
                DSPhimHaiHuoc = Enumerable.Range(0, array5.Count()).Select(i => array5[i]).ToList();
                var array6 = xuatPhim(list, "Hoạt hình");
                DSPhimHoatHinh = Enumerable.Range(0, array6.Count()).Select(i => array6[i]).ToList();
                var array7 = xuatPhim(list, "Kinh dị");
                DSPhimKinhDi = Enumerable.Range(0, array7.Count()).Select(i => array7[i]).ToList();

                DSTheLoai = new ObservableCollection<THELOAI>(qlp.THELOAIs.ToList());
                DSPhim = new ObservableCollection<PHIM>(qlp.PHIMs.ToList());
                DSNguoiDung = new ObservableCollection<TAIKHOAN>(qlp.TAIKHOANs.ToList());
            }
        }
        public List<PHIM> xuatPhim(List<PHIM> list,String str)
        {
            List<PHIM> array = new List<PHIM>();
            foreach (var i in list)
            {
                if (i.TENTHELOAI.Equals(str))
                {
                    array.Add(i);
                }
            }
            return array;
        }
        public void Refresh()
        {
            using (var qlp = new QuanLyPhimEntities5())
            {
                DSNguoiDung = new ObservableCollection<TAIKHOAN>(qlp.TAIKHOANs.ToList());
                DSPhim = new ObservableCollection<PHIM>(qlp.PHIMs.ToList());
                DSTheLoai = new ObservableCollection<THELOAI>(qlp.THELOAIs.ToList());

            }
        }
        void UpdateNguoiDung(string name)
        {
            using (var qlnd = new QuanLyPhimEntities5())
            {
                var ndCur = DSNguoiDung.Single(ng => ng.EMAIL == ItemNguoiDung.EMAIL);
                convertNd(ndCur, ItemNguoiDung);
                var ndCur1 = qlnd.TAIKHOANs.Single(ng => ng.EMAIL == ItemNguoiDung.EMAIL);
                convertNd(ndCur1, ItemNguoiDung);

                qlnd.SaveChanges();
            }
        }
        void AddNguoiDung(string name)
        {
            using (var qlnd = new QuanLyPhimEntities5())
            {
                qlnd.TAIKHOANs.Add(ItemNguoiDung);
                qlnd.SaveChanges();
                Refresh();
            }
        }
        void DeleteNguoiDung(string name)
        {
            var item = (string)name;
            using (var qlnd = new QuanLyPhimEntities5())
            {
                var nd = new TAIKHOAN();

                foreach (var i in DSNguoiDung)
                {
                    if (i.EMAIL.Equals(item))
                    {
                        nd = i;
                    }
                }
                DSNguoiDung.Remove(nd);
                qlnd.Entry(nd).State = System.Data.Entity.EntityState.Deleted;
                qlnd.SaveChanges();
            }
        }
        void convertNd(TAIKHOAN ndCur1, TAIKHOAN ItemNguoiDung)
        {
            ndCur1.PHONENUMBER = ItemNguoiDung.PHONENUMBER;
            ndCur1.SOTAIKHOAN = ItemNguoiDung.SOTAIKHOAN;
            ndCur1.PASS = ItemNguoiDung.PASS;
            ndCur1.TENNGUOIDUNG = ItemNguoiDung.TENNGUOIDUNG;
            ndCur1.TENLOAITHANHTOAN = ItemNguoiDung.TENLOAITHANHTOAN;
            ndCur1.NGAYHETHAN = ItemNguoiDung.NGAYHETHAN;
        }
        void UpdateVideo(string name)
        {
            using (var qlnd = new QuanLyPhimEntities5())
            {
                var ndCur = DSPhim.Single(ng => ng.MAPHIM == ItemPhim.MAPHIM);
                convertVd(ndCur, ItemPhim);
                var ndCur1 = qlnd.PHIMs.Single(ng => ng.MAPHIM == ItemPhim.MAPHIM);
                convertVd(ndCur1, ItemPhim);

                qlnd.SaveChanges();
            }
        }
        void AddVideo(string name)
        {
            using (var qlnd = new QuanLyPhimEntities5())
            {
                qlnd.PHIMs.Add(ItemPhim);
                qlnd.SaveChanges();
                Refresh();
            }
        }
        void DeleteVideo(string name)
        {
            var item = (string)name;
            using (var qlnd = new QuanLyPhimEntities5())
            {
                var nd = new PHIM();

                foreach (var i in DSPhim)
                {
                    if (i.MAPHIM.Equals(item))
                    {
                        nd = i;
                    }
                }
                DSPhim.Remove(nd);
                qlnd.Entry(nd).State = System.Data.Entity.EntityState.Deleted;
                qlnd.SaveChanges();
            }
        }
        void convertVd(PHIM ndCur1, PHIM ItemNguoiDung)
        {
            ndCur1.TENTHELOAI = ItemNguoiDung.TENTHELOAI;
            ndCur1.TENPHIM = ItemNguoiDung.TENPHIM;
            ndCur1.VIDEO = ItemNguoiDung.VIDEO;
            ndCur1.HINHANH = ItemNguoiDung.HINHANH;
            ndCur1.INFO = ItemNguoiDung.INFO;
        }
        void UpdateTheLoai(string name)
        {
            using (var qlnd = new QuanLyPhimEntities5())
            {
                var ndCur = DSTheLoai.Single(ng => ng.MATHELOAI == ItemTheLoai.MATHELOAI);
                convertTl(ndCur, ItemTheLoai);
                var ndCur1 = qlnd.THELOAIs.Single(ng => ng.MATHELOAI == ItemTheLoai.MATHELOAI);
                convertTl(ndCur1, ItemTheLoai);

                qlnd.SaveChanges();
            }
        }
        void AddTheLoai(string name)
        {
            using (var qlnd = new QuanLyPhimEntities5())
            {
                qlnd.THELOAIs.Add(ItemTheLoai);
                qlnd.SaveChanges();
                Refresh();
            }
        }
        void DeleteTheLoai(string name)
        {
            var item = (string)name;
            using (var qlnd = new QuanLyPhimEntities5())
            {
                var nd = new THELOAI();

                foreach (var i in DSTheLoai)
                {
                    if (i.MATHELOAI.Equals(item))
                    {
                        nd = i;
                    }
                }
                DSTheLoai.Remove(nd);
                qlnd.Entry(nd).State = System.Data.Entity.EntityState.Deleted;
                qlnd.SaveChanges();
            }
        }
        void convertTl(THELOAI ndCur1, THELOAI ItemNguoiDung)
        {
            ndCur1.MATHELOAI = ItemNguoiDung.MATHELOAI;
            ndCur1.TENTHELOAI = ItemNguoiDung.TENTHELOAI;
        }
    }
}
