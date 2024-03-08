namespace GUI
{
    partial class DanhGia
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucDanhGia3 = new GUI.UCDanhGia();
            this.ucDanhGia2 = new GUI.UCDanhGia();
            this.ucDanhGia1 = new GUI.UCDanhGia();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(664, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Viết đánh giá";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chúng tôi cố gắng mang đến 100% đánh giá chân thật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bài đánh giá của khách hàng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 55);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ucDanhGia3);
            this.panel2.Controls.Add(this.ucDanhGia2);
            this.panel2.Controls.Add(this.ucDanhGia1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 612);
            this.panel2.TabIndex = 5;
            // 
            // ucDanhGia3
            // 
            this.ucDanhGia3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDanhGia3.Location = new System.Drawing.Point(-1, 425);
            this.ucDanhGia3.Name = "ucDanhGia3";
            this.ucDanhGia3.Size = new System.Drawing.Size(800, 186);
            this.ucDanhGia3.TabIndex = 6;
            // 
            // ucDanhGia2
            // 
            this.ucDanhGia2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDanhGia2.Location = new System.Drawing.Point(-1, 232);
            this.ucDanhGia2.Name = "ucDanhGia2";
            this.ucDanhGia2.Size = new System.Drawing.Size(800, 193);
            this.ucDanhGia2.TabIndex = 5;
            // 
            // ucDanhGia1
            // 
            this.ucDanhGia1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDanhGia1.Location = new System.Drawing.Point(-1, 40);
            this.ucDanhGia1.Name = "ucDanhGia1";
            this.ucDanhGia1.Size = new System.Drawing.Size(800, 193);
            this.ucDanhGia1.TabIndex = 4;
            // 
            // DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhGia";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private UCDanhGia ucDanhGia3;
        private UCDanhGia ucDanhGia2;
        private UCDanhGia ucDanhGia1;
    }
}