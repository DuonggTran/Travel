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
        public UCThongTinPhong()
        {
            InitializeComponent();
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {         
            ChiTietPhong f = new ChiTietPhong();
            f.ShowDialog();           
        }
    }
}
