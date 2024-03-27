namespace GUI
{
    partial class UCPhongCuaKS
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
            this.linklblChiTietPhong = new System.Windows.Forms.LinkLabel();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.pictureBoxLoaiPhong = new System.Windows.Forms.PictureBox();
            this.lblSoGiaTien = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaiPhong)).BeginInit();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklblChiTietPhong
            // 
            this.linklblChiTietPhong.AutoSize = true;
            this.linklblChiTietPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblChiTietPhong.LinkColor = System.Drawing.Color.Blue;
            this.linklblChiTietPhong.Location = new System.Drawing.Point(15, 23);
            this.linklblChiTietPhong.Name = "linklblChiTietPhong";
            this.linklblChiTietPhong.Size = new System.Drawing.Size(169, 25);
            this.linklblChiTietPhong.TabIndex = 0;
            this.linklblChiTietPhong.TabStop = true;
            this.linklblChiTietPhong.Text = "Phòng \"ABCDEF\"";
            this.linklblChiTietPhong.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbChiTietPhong_LinkClicked);
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(12, 101);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(114, 20);
            this.lblLoaiPhong.TabIndex = 1;
            this.lblLoaiPhong.Text = "Giường \"ABC\"";
            // 
            // pictureBoxLoaiPhong
            // 
            this.pictureBoxLoaiPhong.Image = global::GUI.Properties.Resources.f2f783f4e4e7cd0558694a962b7f0872;
            this.pictureBoxLoaiPhong.Location = new System.Drawing.Point(136, 83);
            this.pictureBoxLoaiPhong.Name = "pictureBoxLoaiPhong";
            this.pictureBoxLoaiPhong.Size = new System.Drawing.Size(44, 38);
            this.pictureBoxLoaiPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoaiPhong.TabIndex = 2;
            this.pictureBoxLoaiPhong.TabStop = false;
            // 
            // lblSoGiaTien
            // 
            this.lblSoGiaTien.AutoSize = true;
            this.lblSoGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoGiaTien.Location = new System.Drawing.Point(306, 116);
            this.lblSoGiaTien.Name = "lblSoGiaTien";
            this.lblSoGiaTien.Size = new System.Drawing.Size(120, 20);
            this.lblSoGiaTien.TabIndex = 1;
            this.lblSoGiaTien.Text = "1.000.000 VNĐ";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(218, 116);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(72, 20);
            this.lblGiaTien.TabIndex = 0;
            this.lblGiaTien.Text = "Giá Tiền";
            // 
            // pnl1
            // 
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.pictureBoxLoaiPhong);
            this.pnl1.Controls.Add(this.lblLoaiPhong);
            this.pnl1.Location = new System.Drawing.Point(3, 3);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(343, 142);
            this.pnl1.TabIndex = 3;
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.lblSoLuong);
            this.pnl2.Controls.Add(this.lblGiaTien);
            this.pnl2.Controls.Add(this.lblSoGiaTien);
            this.pnl2.Location = new System.Drawing.Point(344, 3);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(444, 142);
            this.pnl2.TabIndex = 4;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(46, 24);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(130, 20);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Phòng \"N\" người";
            // 
            // UCPhongCuaKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.linklblChiTietPhong);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl2);
            this.Name = "UCPhongCuaKS";
            this.Size = new System.Drawing.Size(791, 148);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoaiPhong)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblChiTietPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.PictureBox pictureBoxLoaiPhong;
        private System.Windows.Forms.Label lblSoGiaTien;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblSoLuong;
    }
}
