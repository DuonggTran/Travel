using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Windows.Forms;
using System.Drawing;
namespace GUI
{
    internal class DataConnection
    {
        public SqlConnection cnnStr = new SqlConnection(Properties.Settings.Default.cnnStr);
        
        public void DangBai(string TenKhachSan, string DiaDiem, string LoaiPhong, string PhuongTien, string GiaTien, string TienIch, string TienNghi, string AnUong, string MoTa, Image HinhAnh1, Image HinhAnh2, Image HinhAnh3, Image HinhAnh4) 
        {
            cnnStr.Open();
            string sql = "Insert into ThongTinPhong(TenKhachSan, DiaDiem, LoaiPhong, PhuongTien, GiaTien, TienIch, TienNghi, AnUong, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4) values (N'"+TenKhachSan+ "',N'"+DiaDiem+ "',N'"+LoaiPhong+ "',N'"+PhuongTien+ "',N'"+GiaTien+ "',N'"+TienIch+ "',N'"+TienNghi+ "',N'"+AnUong+ "',N'"+MoTa+"','" + HinhAnh1+ "','"+HinhAnh2+ "','"+HinhAnh3+ "','"+HinhAnh4+"')";
            SqlCommand cmd = new SqlCommand(sql,cnnStr);
            cmd.ExecuteNonQuery();
            cnnStr.Close();
        }
    }
}
