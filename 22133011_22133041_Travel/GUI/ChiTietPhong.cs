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
        public string TenKhachSan { get; set; }
        public string DiaDiem { get; set; }
        public string LoaiPhong { get; set; }
        public string PhuongTien { get; set; }
        public string GiaTien { get; set; }
        public string TienIch { get; set; }
        public string TienNghi { get; set; }
        public string AnUong { get; set; }
        public string MoTa { get; set; }     
        public ChiTietPhong()
        {
            InitializeComponent();
        }
        private void ChiTietPhong_Load(object sender, EventArgs e)
        {           
            txtTenKhachSan.Text = TenKhachSan;
            txtDiaDiem.Text = DiaDiem;
            txtLoaiPhong.Text = LoaiPhong;
            txtPhuongTien.Text = PhuongTien;
            txtGiaTien.Text = GiaTien;
            txtTienIch.Text = TienIch;
            txtTienNghi.Text = TienNghi;
            txtAnUong.Text = AnUong;
            richTextBoxMoTa.Text = MoTa;        
        }
        private void btnThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietKhachHang f = new ChiTietKhachHang();
            f.ShowDialog();
            f = null;
            this.Close();
        }
        private void linklbDanhGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DanhGia f = new DanhGia();
            f.ShowDialog();
            f = null;
            this.Close();
        }
    }
}
