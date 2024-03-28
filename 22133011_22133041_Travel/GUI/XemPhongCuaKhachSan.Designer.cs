namespace GUI
{
    partial class XemPhongCuaKhachSan
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
            this.pnlTienDe = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboLuongKhach = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lblLuongKhach = new System.Windows.Forms.Label();
            this.lblNgayTraPhong = new System.Windows.Forms.Label();
            this.lblNgayNhanPhong = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.flpTrangChuKhachSan = new System.Windows.Forms.FlowLayoutPanel();
            this.ucPhongCuaKS2 = new GUI.UCPhongCuaKS();
            this.ucPhongCuaKS3 = new GUI.UCPhongCuaKS();
            this.ucPhongCuaKS4 = new GUI.UCPhongCuaKS();
            this.ucPhongCuaKS1 = new GUI.UCPhongCuaKS();
            this.pnlTienDe.SuspendLayout();
            this.flpTrangChuKhachSan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTienDe
            // 
            this.pnlTienDe.Controls.Add(this.btnTimKiem);
            this.pnlTienDe.Controls.Add(this.cboLuongKhach);
            this.pnlTienDe.Controls.Add(this.dateTimePickerNgayTra);
            this.pnlTienDe.Controls.Add(this.dateTimePickerNgayNhan);
            this.pnlTienDe.Controls.Add(this.lblLuongKhach);
            this.pnlTienDe.Controls.Add(this.lblNgayTraPhong);
            this.pnlTienDe.Controls.Add(this.lblNgayNhanPhong);
            this.pnlTienDe.Controls.Add(this.lblPhong);
            this.pnlTienDe.Location = new System.Drawing.Point(2, 2);
            this.pnlTienDe.Name = "pnlTienDe";
            this.pnlTienDe.Size = new System.Drawing.Size(794, 144);
            this.pnlTienDe.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(679, 59);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 52);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cboLuongKhach
            // 
            this.cboLuongKhach.FormattingEnabled = true;
            this.cboLuongKhach.Location = new System.Drawing.Point(535, 87);
            this.cboLuongKhach.Name = "cboLuongKhach";
            this.cboLuongKhach.Size = new System.Drawing.Size(121, 24);
            this.cboLuongKhach.TabIndex = 11;
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(276, 89);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(245, 22);
            this.dateTimePickerNgayTra.TabIndex = 10;
            // 
            // dateTimePickerNgayNhan
            // 
            this.dateTimePickerNgayNhan.Location = new System.Drawing.Point(13, 89);
            this.dateTimePickerNgayNhan.Name = "dateTimePickerNgayNhan";
            this.dateTimePickerNgayNhan.Size = new System.Drawing.Size(245, 22);
            this.dateTimePickerNgayNhan.TabIndex = 9;
            // 
            // lblLuongKhach
            // 
            this.lblLuongKhach.AutoSize = true;
            this.lblLuongKhach.Location = new System.Drawing.Point(532, 59);
            this.lblLuongKhach.Name = "lblLuongKhach";
            this.lblLuongKhach.Size = new System.Drawing.Size(104, 16);
            this.lblLuongKhach.TabIndex = 8;
            this.lblLuongKhach.Text = "Số Lượng Khách";
            // 
            // lblNgayTraPhong
            // 
            this.lblNgayTraPhong.AutoSize = true;
            this.lblNgayTraPhong.Location = new System.Drawing.Point(273, 59);
            this.lblNgayTraPhong.Name = "lblNgayTraPhong";
            this.lblNgayTraPhong.Size = new System.Drawing.Size(99, 16);
            this.lblNgayTraPhong.TabIndex = 6;
            this.lblNgayTraPhong.Text = "Ngày trả phòng";
            // 
            // lblNgayNhanPhong
            // 
            this.lblNgayNhanPhong.AutoSize = true;
            this.lblNgayNhanPhong.Location = new System.Drawing.Point(10, 59);
            this.lblNgayNhanPhong.Name = "lblNgayNhanPhong";
            this.lblNgayNhanPhong.Size = new System.Drawing.Size(113, 16);
            this.lblNgayNhanPhong.TabIndex = 5;
            this.lblNgayNhanPhong.Text = "Ngày nhận phòng";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(10, 6);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(169, 32);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Phòng trống";
            // 
            // flpTrangChuKhachSan
            // 
            this.flpTrangChuKhachSan.Controls.Add(this.ucPhongCuaKS2);
            this.flpTrangChuKhachSan.Controls.Add(this.ucPhongCuaKS3);
            this.flpTrangChuKhachSan.Controls.Add(this.ucPhongCuaKS4);
            this.flpTrangChuKhachSan.Controls.Add(this.ucPhongCuaKS1);
            this.flpTrangChuKhachSan.Location = new System.Drawing.Point(2, 152);
            this.flpTrangChuKhachSan.Name = "flpTrangChuKhachSan";
            this.flpTrangChuKhachSan.Size = new System.Drawing.Size(794, 621);
            this.flpTrangChuKhachSan.TabIndex = 1;
            // 
            // ucPhongCuaKS2
            // 
            this.ucPhongCuaKS2.BackColor = System.Drawing.Color.White;
            this.ucPhongCuaKS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPhongCuaKS2.Location = new System.Drawing.Point(3, 3);
            this.ucPhongCuaKS2.Name = "ucPhongCuaKS2";
            this.ucPhongCuaKS2.Size = new System.Drawing.Size(791, 148);
            this.ucPhongCuaKS2.TabIndex = 4;
            // 
            // ucPhongCuaKS3
            // 
            this.ucPhongCuaKS3.BackColor = System.Drawing.Color.White;
            this.ucPhongCuaKS3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPhongCuaKS3.Location = new System.Drawing.Point(3, 157);
            this.ucPhongCuaKS3.Name = "ucPhongCuaKS3";
            this.ucPhongCuaKS3.Size = new System.Drawing.Size(791, 148);
            this.ucPhongCuaKS3.TabIndex = 2;
            // 
            // ucPhongCuaKS4
            // 
            this.ucPhongCuaKS4.BackColor = System.Drawing.Color.White;
            this.ucPhongCuaKS4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPhongCuaKS4.Location = new System.Drawing.Point(3, 311);
            this.ucPhongCuaKS4.Name = "ucPhongCuaKS4";
            this.ucPhongCuaKS4.Size = new System.Drawing.Size(791, 152);
            this.ucPhongCuaKS4.TabIndex = 3;
            // 
            // ucPhongCuaKS1
            // 
            this.ucPhongCuaKS1.BackColor = System.Drawing.Color.White;
            this.ucPhongCuaKS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPhongCuaKS1.Location = new System.Drawing.Point(3, 469);
            this.ucPhongCuaKS1.Name = "ucPhongCuaKS1";
            this.ucPhongCuaKS1.Size = new System.Drawing.Size(791, 148);
            this.ucPhongCuaKS1.TabIndex = 5;
            // 
            // XemPhongCuaKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(801, 776);
            this.Controls.Add(this.pnlTienDe);
            this.Controls.Add(this.flpTrangChuKhachSan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XemPhongCuaKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChuKhachSan";
            this.pnlTienDe.ResumeLayout(false);
            this.pnlTienDe.PerformLayout();
            this.flpTrangChuKhachSan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTienDe;
        private System.Windows.Forms.FlowLayoutPanel flpTrangChuKhachSan;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblNgayTraPhong;
        private System.Windows.Forms.Label lblNgayNhanPhong;
        private System.Windows.Forms.Label lblLuongKhach;
        private UCPhongCuaKS ucPhongCuaKS3;
        private UCPhongCuaKS ucPhongCuaKS4;
        private UCPhongCuaKS ucPhongCuaKS2;
        private System.Windows.Forms.ComboBox cboLuongKhach;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhan;
        private System.Windows.Forms.Button btnTimKiem;
        private UCPhongCuaKS ucPhongCuaKS1;
    }
}