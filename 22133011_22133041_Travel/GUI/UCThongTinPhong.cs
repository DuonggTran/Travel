using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace GUI
{
    public partial class UCThongTinPhong : UserControl
    {      
        public UCThongTinPhong()
        {
            InitializeComponent();
        }      
        private void btnChiTiet_Click(object sender, EventArgs e)          
        {
            ThongTinKhachSan kSan = new ThongTinKhachSan();
            kSan.TenKhachSan = txtTenKhachSan.Text;
            kSan.DiaDiemKhachSan = txtDiaDiem.Text;
            kSan.Loai = loai;
            kSan.MoTa = mota;
            ChiTietPhong f = new ChiTietPhong(kSan);
            f.ShowDialog();          
        }
        public string loai,mota;
        public void LoadDataTimKiem(FlowLayoutPanel flpTrangChu, string dd)
        {
            List<UCThongTinPhong> thongTinPhongList = new List<UCThongTinPhong>();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT TenKhachSan, DiaDiemKhachSan, Loai, MoTa FROM ThongTinKhachSan WHERE DiaDiemKhachSan = @dd";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dd", dd);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCThongTinPhong uc = new UCThongTinPhong();                                                       
                    uc.txtTenKhachSan.Text = reader[0].ToString();
                    uc.txtDiaDiem.Text = reader[1].ToString();
                    uc.loai = reader[2].ToString();
                    uc.mota = reader[3].ToString();                   
                    thongTinPhongList.Add(uc);
                }
                reader.Close();
                connection.Close();
                foreach (UCThongTinPhong uc in thongTinPhongList)
                {
                    flpTrangChu.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }          
    }
}
