namespace GUI
{
    partial class ChiTietKhachHang
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
            this.lblThongTinLienLac = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNgayNhanPhong = new System.Windows.Forms.Label();
            this.lblNgayTraPhong = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btnThue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThongTinLienLac
            // 
            this.lblThongTinLienLac.AutoSize = true;
            this.lblThongTinLienLac.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinLienLac.Location = new System.Drawing.Point(18, 20);
            this.lblThongTinLienLac.Name = "lblThongTinLienLac";
            this.lblThongTinLienLac.Size = new System.Drawing.Size(262, 38);
            this.lblThongTinLienLac.TabIndex = 0;
            this.lblThongTinLienLac.Text = "Thông tin liên lạc";
            this.lblThongTinLienLac.UseWaitCursor = true;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(22, 90);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(37, 20);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên";
            this.lblTenKhachHang.UseWaitCursor = true;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(334, 90);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(106, 20);
            this.lblSoDienThoai.TabIndex = 2;
            this.lblSoDienThoai.Text = "Số điện thoại";
            this.lblSoDienThoai.UseWaitCursor = true;
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(22, 176);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(58, 20);
            this.lblCCCD.TabIndex = 3;
            this.lblCCCD.Text = "CCCD";
            this.lblCCCD.UseWaitCursor = true;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(335, 176);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(40, 20);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail";
            this.lblMail.UseWaitCursor = true;
            // 
            // lblNgayNhanPhong
            // 
            this.lblNgayNhanPhong.AutoSize = true;
            this.lblNgayNhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhanPhong.Location = new System.Drawing.Point(22, 258);
            this.lblNgayNhanPhong.Name = "lblNgayNhanPhong";
            this.lblNgayNhanPhong.Size = new System.Drawing.Size(138, 20);
            this.lblNgayNhanPhong.TabIndex = 5;
            this.lblNgayNhanPhong.Text = "Ngày nhận phòng";
            this.lblNgayNhanPhong.UseWaitCursor = true;
            // 
            // lblNgayTraPhong
            // 
            this.lblNgayTraPhong.AutoSize = true;
            this.lblNgayTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTraPhong.Location = new System.Drawing.Point(334, 258);
            this.lblNgayTraPhong.Name = "lblNgayTraPhong";
            this.lblNgayTraPhong.Size = new System.Drawing.Size(122, 20);
            this.lblNgayTraPhong.TabIndex = 6;
            this.lblNgayTraPhong.Text = "Ngày trả phòng";
            this.lblNgayTraPhong.UseWaitCursor = true;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(25, 120);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(277, 27);
            this.txtTenKhachHang.TabIndex = 8;
            this.txtTenKhachHang.UseWaitCursor = true;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(338, 120);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(281, 27);
            this.txtSoDienThoai.TabIndex = 9;
            this.txtSoDienThoai.UseWaitCursor = true;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(26, 206);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(277, 27);
            this.txtCCCD.TabIndex = 10;
            this.txtCCCD.UseWaitCursor = true;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(339, 206);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(281, 27);
            this.txtMail.TabIndex = 11;
            this.txtMail.UseWaitCursor = true;
            // 
            // dateTimePickerNgayNhan
            // 
            this.dateTimePickerNgayNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayNhan.Location = new System.Drawing.Point(25, 300);
            this.dateTimePickerNgayNhan.Name = "dateTimePickerNgayNhan";
            this.dateTimePickerNgayNhan.Size = new System.Drawing.Size(277, 27);
            this.dateTimePickerNgayNhan.TabIndex = 12;
            this.dateTimePickerNgayNhan.UseWaitCursor = true;
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(338, 301);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(281, 27);
            this.dateTimePickerNgayTra.TabIndex = 13;
            this.dateTimePickerNgayTra.UseWaitCursor = true;
            // 
            // btnThue
            // 
            this.btnThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThue.Location = new System.Drawing.Point(248, 356);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(139, 44);
            this.btnThue.TabIndex = 16;
            this.btnThue.Text = "Thuê";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.UseWaitCursor = true;
            // 
            // ChiTietKhachHang
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 424);
            this.Controls.Add(this.btnThue);
            this.Controls.Add(this.dateTimePickerNgayTra);
            this.Controls.Add(this.dateTimePickerNgayNhan);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblNgayTraPhong);
            this.Controls.Add(this.lblNgayNhanPhong);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblThongTinLienLac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietKhachHang";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinLienLac;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNgayNhanPhong;
        private System.Windows.Forms.Label lblNgayTraPhong;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhan;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.Button btnThue;
    }
}