using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class ThongTinPhongCuaKhachSanDAO
    {
        SqlConnection cnnStr = new SqlConnection(Properties.Settings.Default.cnnStr);
        public void Them(ThongTinKhachSan kSan, DataConnection db)
        {
            //string SQL = string.Format(//"INSERT INTO ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", kSan.TenKhachSan, kSan.DiaDiemKhachSan, kSan.Loai, kSan.MoTa, kSan.HinhAnh1, kSan.HinhAnh2, kSan.HinhAnh3, kSan.HinhAnh4);
            //db.ThucThi(SQL);
        }
    }
}
