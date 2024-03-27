using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietPhongCuaKS : Form
    {
        public ChiTietPhongCuaKS()
        {
            InitializeComponent();
        }
        private void btnThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietKhachHang f = new ChiTietKhachHang();
            f.ShowDialog();
            f = null;
            this.Close();
        }
    }
}
