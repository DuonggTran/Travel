using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : Form
    {
        SqlConnection cnnStr = new SqlConnection(Properties.Settings.Default.cnnStr);
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        DataConnection dB = new DataConnection();
        public TrangChu()
        {
            InitializeComponent();
        }       
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy f = new DangKy();
            f.ShowDialog();
        }
        private void btnChoThue_Click(object sender, EventArgs e)
        {
            DangBai f = new DangBai();
            f.ShowDialog();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            flpTrangChu.Controls.Clear();
            UCThongTinPhong uc1 = new UCThongTinPhong();
            flpTrangChu.Controls.Add(uc1);
            UCThongTinPhong uc2 = new UCThongTinPhong();
            flpTrangChu.Controls.Add(uc2);
            UCThongTinPhong uc3 = new UCThongTinPhong();
            flpTrangChu.Controls.Add(uc3);
            UCThongTinPhong uc4 = new UCThongTinPhong();
            flpTrangChu.Controls.Add(uc4);
            UCThongTinPhong uc5 = new UCThongTinPhong();
            flpTrangChu.Controls.Add(uc5);
            UCThongTinPhong uc6 = new UCThongTinPhong();
            flpTrangChu.Controls.Add(uc6);
            UCThongTinPhong uc7 = new UCThongTinPhong();
            flpTrangChu.Controls.Add(uc7);
            UCThongTinPhong uc8 = new UCThongTinPhong();
            flpTrangChu.Controls.Add(uc8);
            UCThongTinPhong uc9 = new UCThongTinPhong();
            flpTrangChu.Controls.Add(uc9);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.ShowDialog();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flpTrangChu.Controls.Clear();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
            connection.Open();
            string selectedDiaDiem = cboDiaDiem.Text;
            string query = "SELECT DISTINCT DiaDiemKhachSan FROM ThongTinKhachSan WHERE DiaDiemKhachSan = @DiaDiemKhachSan";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DiaDiemKhachSan", selectedDiaDiem);
            SqlDataReader reader = command.ExecuteReader();
            UCThongTinPhong f = new UCThongTinPhong();
            while (reader.Read())
            {
                string diaDiem = reader["DiaDiemKhachSan"].ToString();
                f.LoadDataTimKiem(flpTrangChu, diaDiem);           
                break;
            }
            connection.Close();                       
        }
    }
}
