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
        public TrangChu()
        {
            InitializeComponent();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flpTrangChu.Controls.Clear();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
            connection.Open();
            string selectedDiaDiem = cboDiaDiem.Text;
            string query = "SELECT DISTINCT DiaDiem FROM ThongTinPhong WHERE DiaDiem = @DiaDiem";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DiaDiem", selectedDiaDiem);
            SqlDataReader reader = command.ExecuteReader();
            UCThongTinPhong f = new UCThongTinPhong();
            while (reader.Read())
            {
                string diaDiem = reader["DiaDiem"].ToString();
                f.loadData(flpTrangChu, diaDiem);
                break;
            }
            connection.Close();
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
            
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.ShowDialog();
        }
    }
}
