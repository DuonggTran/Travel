using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
