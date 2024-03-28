using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThemPhongKhachSan : Form
    {
        SqlConnection cnnStr = new SqlConnection(Properties.Settings.Default.cnnStr);
        ThongTinPhongCuaKhachSanDAO kSanDAO = new ThongTinPhongCuaKhachSanDAO();
        DataConnection dB = new DataConnection();
        public ThemPhongKhachSan()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinPhongCuaKhachSan kSan = new ThongTinPhongCuaKhachSan(lblTenPhong.Text, txtKichThuocPhong.Text, txtGiaPhong.Text, chkTrongPhongTam1.Text, chkTrongPhongTam2.Text, chkTrongPhongTam3.Text, chkTrongPhongTam4.Text, chkHuongTamNhin1.Text, chkHuongTamNhin2.Text, chkTienNghi1.Text, chkTienNghi2.Text, chkTienNghi3.Text, chkTienNghi4.Text, chkTienNghi5.Text, chkTienNghi6.Text, chkHutThuoc1.Text, chkHutThuoc2.Text, null, null);
            {
                kSanDAO.Them(kSan, dB);
            }
        }
    }
}
