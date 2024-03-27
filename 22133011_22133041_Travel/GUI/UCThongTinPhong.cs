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

namespace GUI
{
    public partial class UCThongTinPhong : UserControl
    {
        public string DiaDiem { get; set; }
        public string LoaiPhong { get; set; }
        public string PhuongTien { get; set; }
        public string TienIch { get; set; }
        public string TienNghi { get; set; }
        public string AnUong { get; set; }
        public string MoTa { get; set; }       
        public UCThongTinPhong()
        {
            InitializeComponent();
        }
        public void loadData(FlowLayoutPanel flpTrangChu, string dd)
        {
            List<UCThongTinPhong> thongTinPhongList = new List<UCThongTinPhong>();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT TenKhachSan, GiaTien, DiaDiem, LoaiPhong, PhuongTien, TienIch, TienNghi, AnUong, MoTa FROM ThongTinPhong WHERE DiaDiem = @dd";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dd", dd);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCThongTinPhong uc = new UCThongTinPhong();
                    uc.txtTenKhachSan.Text = reader[0].ToString();
                    uc.txtDiaDiem.Text = reader[1].ToString();
                    uc.DiaDiem = reader[2].ToString(); // Gán giá trị cho thuộc tính DiaDiem
                    uc.LoaiPhong = reader[3].ToString();
                    uc.PhuongTien = reader[4].ToString();
                    uc.TienIch = reader[5].ToString();
                    uc.TienNghi = reader[6].ToString();
                    uc.AnUong = reader[7].ToString();
                    uc.MoTa = reader[8].ToString();                   
                   
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
        private void btnChiTiet_Click(object sender, EventArgs e)
        {           
            ChiTietPhong chiTietPhongForm = new ChiTietPhong();
            chiTietPhongForm.TenKhachSan = txtTenKhachSan.Text;
            chiTietPhongForm.GiaTien = txtDiaDiem.Text;
            chiTietPhongForm.DiaDiem = DiaDiem; 
            chiTietPhongForm.LoaiPhong = LoaiPhong;
            chiTietPhongForm.PhuongTien = PhuongTien;
            chiTietPhongForm.TienIch = TienIch;
            chiTietPhongForm.TienNghi = TienNghi;
            chiTietPhongForm.AnUong = AnUong;
            chiTietPhongForm.MoTa = MoTa;
            
            chiTietPhongForm.ShowDialog();
        }
    }
}
