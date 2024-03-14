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
    public partial class DanhGia : Form
    {
        public DanhGia()
        {
            InitializeComponent();
        }
        private void flpDanhGia_Paint(object sender, PaintEventArgs e)
        {           
           
        }
        private void DanhGia_Load(object sender, EventArgs e)
        {
            UCDanhGia uc1 = new UCDanhGia();
            flpDanhGia.Controls.Add(uc1);
            UCDanhGia uc2 = new UCDanhGia();
            flpDanhGia.Controls.Add(uc2);
            UCDanhGia uc3 = new UCDanhGia();
            flpDanhGia.Controls.Add(uc3);
        }
    }
}
