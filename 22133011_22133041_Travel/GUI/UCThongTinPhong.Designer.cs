namespace GUI
{
    partial class UCThongTinPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChiTiet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiaDiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKhachSan = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxHinhAnh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Animated = true;
            this.btnChiTiet.AutoRoundedCorners = true;
            this.btnChiTiet.BorderRadius = 21;
            this.btnChiTiet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTiet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTiet.FillColor = System.Drawing.Color.Orange;
            this.btnChiTiet.FillColor2 = System.Drawing.Color.PeachPuff;
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.Location = new System.Drawing.Point(334, 159);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(130, 45);
            this.btnChiTiet.TabIndex = 3;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDiaDiem);
            this.panel1.Controls.Add(this.txtTenKhachSan);
            this.panel1.Controls.Add(this.pictureBoxHinhAnh);
            this.panel1.Controls.Add(this.btnChiTiet);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 209);
            this.panel1.TabIndex = 4;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Animated = true;
            this.txtDiaDiem.AutoRoundedCorners = true;
            this.txtDiaDiem.BorderColor = System.Drawing.Color.Black;
            this.txtDiaDiem.BorderRadius = 26;
            this.txtDiaDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaDiem.DefaultText = "Địa điểm";
            this.txtDiaDiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.ForeColor = System.Drawing.Color.Black;
            this.txtDiaDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Location = new System.Drawing.Point(209, 85);
            this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.PasswordChar = '\0';
            this.txtDiaDiem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDiaDiem.PlaceholderText = "";
            this.txtDiaDiem.ReadOnly = true;
            this.txtDiaDiem.SelectedText = "";
            this.txtDiaDiem.Size = new System.Drawing.Size(191, 55);
            this.txtDiaDiem.TabIndex = 5;
            // 
            // txtTenKhachSan
            // 
            this.txtTenKhachSan.Animated = true;
            this.txtTenKhachSan.AutoRoundedCorners = true;
            this.txtTenKhachSan.BorderColor = System.Drawing.Color.Black;
            this.txtTenKhachSan.BorderRadius = 26;
            this.txtTenKhachSan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachSan.DefaultText = "Tên Khách Sạn";
            this.txtTenKhachSan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhachSan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhachSan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachSan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachSan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachSan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachSan.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhachSan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachSan.Location = new System.Drawing.Point(209, 5);
            this.txtTenKhachSan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenKhachSan.Name = "txtTenKhachSan";
            this.txtTenKhachSan.PasswordChar = '\0';
            this.txtTenKhachSan.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenKhachSan.PlaceholderText = "";
            this.txtTenKhachSan.ReadOnly = true;
            this.txtTenKhachSan.SelectedText = "";
            this.txtTenKhachSan.Size = new System.Drawing.Size(255, 55);
            this.txtTenKhachSan.TabIndex = 4;
            // 
            // pictureBoxHinhAnh
            // 
            this.pictureBoxHinhAnh.BackColor = System.Drawing.Color.White;
            this.pictureBoxHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHinhAnh.Image = global::GUI.Properties.Resources._42c98447061cab42f20d;
            this.pictureBoxHinhAnh.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxHinhAnh.Name = "pictureBoxHinhAnh";
            this.pictureBoxHinhAnh.Size = new System.Drawing.Size(204, 211);
            this.pictureBoxHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHinhAnh.TabIndex = 0;
            this.pictureBoxHinhAnh.TabStop = false;
            // 
            // UCThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "UCThongTinPhong";
            this.Size = new System.Drawing.Size(476, 217);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHinhAnh;
        private Guna.UI2.WinForms.Guna2GradientButton btnChiTiet;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaDiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhachSan;
    }
}
