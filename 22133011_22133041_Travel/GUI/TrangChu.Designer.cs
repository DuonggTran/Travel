namespace GUI
{
    partial class TrangChu
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
            this.ucTrangChu1 = new GUI.UCTrangChu();
            this.ucThongTinPhong1 = new GUI.UCThongTinPhong();
            this.ucThongTinPhong2 = new GUI.UCThongTinPhong();
            this.ucThongTinPhong3 = new GUI.UCThongTinPhong();
            this.ucThongTinPhong4 = new GUI.UCThongTinPhong();
            this.SuspendLayout();
            // 
            // ucTrangChu1
            // 
            this.ucTrangChu1.Location = new System.Drawing.Point(-1, -1);
            this.ucTrangChu1.Name = "ucTrangChu1";
            this.ucTrangChu1.Size = new System.Drawing.Size(1439, 696);
            this.ucTrangChu1.TabIndex = 0;
            // 
            // ucThongTinPhong1
            // 
            this.ucThongTinPhong1.Location = new System.Drawing.Point(296, 176);
            this.ucThongTinPhong1.Name = "ucThongTinPhong1";
            this.ucThongTinPhong1.Size = new System.Drawing.Size(447, 199);
            this.ucThongTinPhong1.TabIndex = 1;
            // 
            // ucThongTinPhong2
            // 
            this.ucThongTinPhong2.Location = new System.Drawing.Point(901, 176);
            this.ucThongTinPhong2.Name = "ucThongTinPhong2";
            this.ucThongTinPhong2.Size = new System.Drawing.Size(447, 199);
            this.ucThongTinPhong2.TabIndex = 2;
            // 
            // ucThongTinPhong3
            // 
            this.ucThongTinPhong3.Location = new System.Drawing.Point(296, 449);
            this.ucThongTinPhong3.Name = "ucThongTinPhong3";
            this.ucThongTinPhong3.Size = new System.Drawing.Size(447, 199);
            this.ucThongTinPhong3.TabIndex = 3;
            // 
            // ucThongTinPhong4
            // 
            this.ucThongTinPhong4.Location = new System.Drawing.Point(901, 449);
            this.ucThongTinPhong4.Name = "ucThongTinPhong4";
            this.ucThongTinPhong4.Size = new System.Drawing.Size(447, 199);
            this.ucThongTinPhong4.TabIndex = 4;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 695);
            this.Controls.Add(this.ucThongTinPhong4);
            this.Controls.Add(this.ucThongTinPhong3);
            this.Controls.Add(this.ucThongTinPhong2);
            this.Controls.Add(this.ucThongTinPhong1);
            this.Controls.Add(this.ucTrangChu1);
            this.Name = "TrangChu";
            this.Text = "Trang Chu";
            this.ResumeLayout(false);

        }

        #endregion

        private UCTrangChu ucTrangChu1;
        private UCThongTinPhong ucThongTinPhong1;
        private UCThongTinPhong ucThongTinPhong2;
        private UCThongTinPhong ucThongTinPhong3;
        private UCThongTinPhong ucThongTinPhong4;
    }
}

