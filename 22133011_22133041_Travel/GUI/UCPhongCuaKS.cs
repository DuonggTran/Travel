﻿using System;
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
    public partial class UCPhongCuaKS : UserControl
    {
        public UCPhongCuaKS()
        {
            InitializeComponent();
        }

        private void lbChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ChiTietPhongCuaKS f = new ChiTietPhongCuaKS();
            f.ShowDialog();                    
        }
    }
}
