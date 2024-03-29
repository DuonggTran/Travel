﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ThongTinKhachSan
    {
        public string tenKhachSan;
        public string diaDiemKhachSan;
        public string loai;
        public byte[] hinhAnh1;
        public byte[] hinhAnh2;
        public byte[] hinhAnh3;
        public byte[] hinhAnh4;
        public ThongTinKhachSan() { }
        public ThongTinKhachSan(string tenKhachSan, string diaDiemKhachSan, string loai,byte[] hinhAnh1, byte[] hinhAnh2, byte[] hinhAnh3, byte[] hinhAnh4)
        {
            this.tenKhachSan = tenKhachSan;
            this.diaDiemKhachSan = diaDiemKhachSan;
            this.loai = loai;
            this.hinhAnh1 = hinhAnh1;
            this.hinhAnh2= hinhAnh2;
            this.hinhAnh3 = hinhAnh3;
            this.hinhAnh4 = hinhAnh4;
        }
        public string TenKhachSan{
            get {return tenKhachSan;}
            set {tenKhachSan = value;} 
        }
        public string DiaDiemKhachSan
        {
            get { return diaDiemKhachSan; }
            set { diaDiemKhachSan = value; }
        }
        public string Loai { 
            get {  return loai; } 
            set { loai = value; } 
        }  
        public byte[] HinhAnh1
        {
            get { return hinhAnh1; }
            set { hinhAnh1 = value;}
        }
        public byte[] HinhAnh2
        {
            get { return hinhAnh2; }
            set { hinhAnh2 = value; }
        }
        public byte[] HinhAnh3
        {
            get { return hinhAnh3; }
            set { hinhAnh3 = value; }
        }
        public byte[] HinhAnh4
        {
            get { return hinhAnh4; }
            set { hinhAnh4 = value; }
        }
    }
}
