﻿namespace GUI
{
    partial class ChiTietPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietPhong));
            this.txtTenKhachSan = new System.Windows.Forms.Label();
            this.richTextBoxMoTa = new System.Windows.Forms.RichTextBox();
            this.linklbDanhGia = new System.Windows.Forms.LinkLabel();
            this.btnXemPhongTrong = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtDiaDiem = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.Label();
            this.pictureBoxLoaiPhong = new System.Windows.Forms.PictureBox();
            this.pictureBoxDiaDiem = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnh1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiaDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnh1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenKhachSan
            // 
            this.txtTenKhachSan.AllowDrop = true;
            this.txtTenKhachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachSan.Location = new System.Drawing.Point(2, -1);
            this.txtTenKhachSan.Name = "txtTenKhachSan";
            this.txtTenKhachSan.Size = new System.Drawing.Size(863, 71);
            this.txtTenKhachSan.TabIndex = 21;
            this.txtTenKhachSan.Text = "Tên Khách Sạn";
            this.txtTenKhachSan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxMoTa
            // 
            this.richTextBoxMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMoTa.Location = new System.Drawing.Point(12, 390);
            this.richTextBoxMoTa.Name = "richTextBoxMoTa";
            this.richTextBoxMoTa.ReadOnly = true;
            this.richTextBoxMoTa.Size = new System.Drawing.Size(839, 129);
            this.richTextBoxMoTa.TabIndex = 26;
            this.richTextBoxMoTa.Text = resources.GetString("richTextBoxMoTa.Text");
            // 
            // linklbDanhGia
            // 
            this.linklbDanhGia.AutoSize = true;
            this.linklbDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbDanhGia.LinkColor = System.Drawing.Color.Black;
            this.linklbDanhGia.Location = new System.Drawing.Point(653, 571);
            this.linklbDanhGia.Name = "linklbDanhGia";
            this.linklbDanhGia.Size = new System.Drawing.Size(111, 20);
            this.linklbDanhGia.TabIndex = 53;
            this.linklbDanhGia.TabStop = true;
            this.linklbDanhGia.Text = "Xem đánh giá";
            this.linklbDanhGia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbDanhGia_LinkClicked);
            // 
            // btnXemPhongTrong
            // 
            this.btnXemPhongTrong.Animated = true;
            this.btnXemPhongTrong.AutoRoundedCorners = true;
            this.btnXemPhongTrong.BorderRadius = 21;
            this.btnXemPhongTrong.BorderThickness = 1;
            this.btnXemPhongTrong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemPhongTrong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemPhongTrong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemPhongTrong.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemPhongTrong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemPhongTrong.FillColor = System.Drawing.Color.White;
            this.btnXemPhongTrong.FillColor2 = System.Drawing.Color.White;
            this.btnXemPhongTrong.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnXemPhongTrong.ForeColor = System.Drawing.Color.Black;
            this.btnXemPhongTrong.Location = new System.Drawing.Point(328, 626);
            this.btnXemPhongTrong.Name = "btnXemPhongTrong";
            this.btnXemPhongTrong.Size = new System.Drawing.Size(212, 45);
            this.btnXemPhongTrong.TabIndex = 54;
            this.btnXemPhongTrong.Text = "Xem phòng trống";
            this.btnXemPhongTrong.Click += new System.EventHandler(this.btnXemPhongTrong_Click);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Location = new System.Drawing.Point(73, 539);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(141, 52);
            this.txtDiaDiem.TabIndex = 98;
            this.txtDiaDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhong.Location = new System.Drawing.Point(346, 539);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(141, 52);
            this.txtLoaiPhong.TabIndex = 100;
            this.txtLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLoaiPhong
            // 
            this.pictureBoxLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLoaiPhong.Image = global::GUI.Properties.Resources._42c98447061cab42f20d;
            this.pictureBoxLoaiPhong.Location = new System.Drawing.Point(285, 539);
            this.pictureBoxLoaiPhong.Name = "pictureBoxLoaiPhong";
            this.pictureBoxLoaiPhong.Size = new System.Drawing.Size(55, 52);
            this.pictureBoxLoaiPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoaiPhong.TabIndex = 80;
            this.pictureBoxLoaiPhong.TabStop = false;
            // 
            // pictureBoxDiaDiem
            // 
            this.pictureBoxDiaDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDiaDiem.Image = global::GUI.Properties.Resources._8120a168e11b4d45140a;
            this.pictureBoxDiaDiem.Location = new System.Drawing.Point(12, 539);
            this.pictureBoxDiaDiem.Name = "pictureBoxDiaDiem";
            this.pictureBoxDiaDiem.Size = new System.Drawing.Size(55, 52);
            this.pictureBoxDiaDiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDiaDiem.TabIndex = 77;
            this.pictureBoxDiaDiem.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::GUI.Properties.Resources.a7e12305a3750f2b5664;
            this.pictureBox4.Location = new System.Drawing.Point(622, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(229, 145);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::GUI.Properties.Resources._7f87f2be6dcec19098df;
            this.pictureBox3.Location = new System.Drawing.Point(387, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(229, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::GUI.Properties.Resources.a9a4924c123cbe62e72d;
            this.pictureBox2.Location = new System.Drawing.Point(387, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(464, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxAnh1
            // 
            this.pictureBoxAnh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAnh1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnh1.Image")));
            this.pictureBoxAnh1.Location = new System.Drawing.Point(12, 73);
            this.pictureBoxAnh1.Name = "pictureBoxAnh1";
            this.pictureBoxAnh1.Size = new System.Drawing.Size(369, 301);
            this.pictureBoxAnh1.TabIndex = 17;
            this.pictureBoxAnh1.TabStop = false;
            // 
            // ChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(863, 688);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.pictureBoxLoaiPhong);
            this.Controls.Add(this.pictureBoxDiaDiem);
            this.Controls.Add(this.btnXemPhongTrong);
            this.Controls.Add(this.linklbDanhGia);
            this.Controls.Add(this.txtTenKhachSan);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxAnh1);
            this.Controls.Add(this.richTextBoxMoTa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietPhong";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiaDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnh1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label txtTenKhachSan;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxAnh1;
        private System.Windows.Forms.RichTextBox richTextBoxMoTa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linklbDanhGia;
        private Guna.UI2.WinForms.Guna2GradientButton btnXemPhongTrong;
        private System.Windows.Forms.PictureBox pictureBoxLoaiPhong;
        private System.Windows.Forms.PictureBox pictureBoxDiaDiem;
        private System.Windows.Forms.Label txtDiaDiem;
        private System.Windows.Forms.Label txtLoaiPhong;
    }
}