//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyMovies.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public partial class TAIKHOAN
    {
        string email;
        int phonenumber;
        double stk;
        string pass;
        string name;
        string tenloaithanhtoan;
        Nullable<System.DateTime> ngayhethan;

        public string EMAIL
        {
            get => email;
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged();
                }
            }
        }
        public int PHONENUMBER
        {
            get => phonenumber;
            set
            {
                if (phonenumber != value)
                {
                    phonenumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public double SOTAIKHOAN
        {
            get => stk;
            set
            {
                if (stk != value)
                {
                    stk = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TENNGUOIDUNG
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public Nullable<System.DateTime> NGAYHETHAN
        {
            get => ngayhethan;
            set
            {
                if (ngayhethan != value)
                {
                    ngayhethan = value;
                    OnPropertyChanged();
                }
            }
        }
        public string PASS
        {
            get => pass;
            set
            {
                if (pass != value)
                {
                    pass = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TENLOAITHANHTOAN
        {
            get => tenloaithanhtoan;
            set
            {
                if (tenloaithanhtoan != value)
                {
                    tenloaithanhtoan = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool OnPropertyChanged<T>(ref T backingField, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
                return false;

            backingField = value;
            OnPropertyChanged(propertyName);
            return true;
        }

    }
}
