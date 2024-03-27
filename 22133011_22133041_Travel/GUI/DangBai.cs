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
    public partial class DangBai : Form
    {
        public DangBai()
        {
            InitializeComponent();
        }
        private void btnThemAnh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if(opf.ShowDialog()== DialogResult.OK) 
            {
                pic_Anh1.Image = Image.FromFile(opf.FileName);
            }
        }
        private void btnThemAnh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh2.Image = Image.FromFile(opf.FileName);
            }
        }
        private void btnThemAnh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh3.Image = Image.FromFile(opf.FileName);
            }
        }
        private void btnThemAnh4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh4.Image = Image.FromFile(opf.FileName);
            }
        }
        DataConnection db = new DataConnection();
        private void btnDangBai_Click(object sender, EventArgs e)
        {
            db.DangBai(txtTenKhachSan.Text, cboDiaDiem.Text, cboLoaiPhong.Text, cboPhuongTien.Text, cboGiaTien.Text, cboTienIch.Text, cboTienNghi.Text, cboAnUong.Text, txtMoTa.Text, pic_Anh1.Image, pic_Anh2.Image, pic_Anh3.Image, pic_Anh4.Image);
            txtTenKhachSan.ResetText();
            cboDiaDiem.ResetText();
            cboLoaiPhong.ResetText();
            cboPhuongTien.ResetText();
            cboGiaTien.ResetText();
            cboTienIch.ResetText();
            cboTienNghi.ResetText();
            cboAnUong.ResetText();
            txtMoTa.ResetText();
            pic_Anh1.Image = null;
            pic_Anh2.Image = null;
            pic_Anh3.Image = null;
            pic_Anh4.Image = null;
            MessageBox.Show("Đăng Bài Thành Công");
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            this.Close();
            ThemPhongKhachSan f = new ThemPhongKhachSan();
            f.ShowDialog();
        }
    }
}
