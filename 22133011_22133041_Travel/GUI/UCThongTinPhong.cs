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
            ChiTietPhong f = new ChiTietPhong();
            f.Show();
        }
        public void loadData(FlowLayoutPanel flpTrangChu, string dd)
        {
            List<UCThongTinPhong> thongTinPhongList = new List<UCThongTinPhong>();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT TenKhachSan, GiaTien FROM ThongTinPhong WHERE DiaDiem = @dd";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dd", dd);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCThongTinPhong uc = new UCThongTinPhong();
                    uc.txtTenKhachSan.Text = reader[0].ToString();
                    uc.txtGiaTien.Text = reader[1].ToString();
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
        public void loadAllData(FlowLayoutPanel flpTrangChu, string dd)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT * FROM ThongTinPhong WHERE DiaDiem = @dd";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dd", dd);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCThongTinPhong uc = new UCThongTinPhong();
                    uc.txtTenKhachSan.Text = reader[0].ToString();
                    uc.txtGiaTien.Text = reader[1].ToString();
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
