using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietPhong : Form
    {    
        public ChiTietPhong()
        {
            InitializeComponent();
        }
        public ChiTietPhong(ThongTinKhachSan kSan)
        {
            InitializeComponent();
            txtTenKhachSan.Text = kSan.TenKhachSan;
            txtDiaDiem.Text = kSan.DiaDiemKhachSan;
            txtLoaiPhong.Text = kSan.Loai;
            richTextBoxMoTa.Text = kSan.MoTa;
        }  
        private void linklbDanhGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {          
            DanhGia f = new DanhGia();
            f.ShowDialog();      
        }
        private void btnXemPhongTrong_Click(object sender, EventArgs e)
        {           
            XemPhongCuaKhachSan f = new XemPhongCuaKhachSan();
            f.ShowDialog();          
        }      
    }
}
