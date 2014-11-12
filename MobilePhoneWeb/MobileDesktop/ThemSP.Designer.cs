namespace MobileDesktop
{
    partial class ThemSP
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
            this.LBtensp = new System.Windows.Forms.Label();
            this.LBgia = new System.Windows.Forms.Label();
            this.LBsoluong = new System.Windows.Forms.Label();
            this.Lbhinh = new System.Windows.Forms.Label();
            this.LBmota = new System.Windows.Forms.Label();
            this.LBnsx = new System.Windows.Forms.Label();
            this.TBtensp = new System.Windows.Forms.TextBox();
            this.TBmota = new System.Windows.Forms.TextBox();
            this.Tbgia = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TBsoluong = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBtensp
            // 
            this.LBtensp.AutoSize = true;
            this.LBtensp.Location = new System.Drawing.Point(12, 9);
            this.LBtensp.Name = "LBtensp";
            this.LBtensp.Size = new System.Drawing.Size(75, 13);
            this.LBtensp.TabIndex = 0;
            this.LBtensp.Text = "Tên sản phẩm";
            // 
            // LBgia
            // 
            this.LBgia.AutoSize = true;
            this.LBgia.Location = new System.Drawing.Point(459, 9);
            this.LBgia.Name = "LBgia";
            this.LBgia.Size = new System.Drawing.Size(23, 13);
            this.LBgia.TabIndex = 1;
            this.LBgia.Text = "Giá";
            // 
            // LBsoluong
            // 
            this.LBsoluong.AutoSize = true;
            this.LBsoluong.Location = new System.Drawing.Point(459, 154);
            this.LBsoluong.Name = "LBsoluong";
            this.LBsoluong.Size = new System.Drawing.Size(49, 13);
            this.LBsoluong.TabIndex = 2;
            this.LBsoluong.Text = "Số lượng";
            // 
            // Lbhinh
            // 
            this.Lbhinh.AutoSize = true;
            this.Lbhinh.Location = new System.Drawing.Point(12, 154);
            this.Lbhinh.Name = "Lbhinh";
            this.Lbhinh.Size = new System.Drawing.Size(29, 13);
            this.Lbhinh.TabIndex = 3;
            this.Lbhinh.Text = "Hình";
            // 
            // LBmota
            // 
            this.LBmota.AutoSize = true;
            this.LBmota.Location = new System.Drawing.Point(12, 80);
            this.LBmota.Name = "LBmota";
            this.LBmota.Size = new System.Drawing.Size(34, 13);
            this.LBmota.TabIndex = 4;
            this.LBmota.Text = "Mô tả";
            // 
            // LBnsx
            // 
            this.LBnsx.AutoSize = true;
            this.LBnsx.Location = new System.Drawing.Point(459, 80);
            this.LBnsx.Name = "LBnsx";
            this.LBnsx.Size = new System.Drawing.Size(70, 13);
            this.LBnsx.TabIndex = 5;
            this.LBnsx.Text = "Nhà sản xuất";
            // 
            // TBtensp
            // 
            this.TBtensp.Location = new System.Drawing.Point(93, 6);
            this.TBtensp.Name = "TBtensp";
            this.TBtensp.Size = new System.Drawing.Size(316, 20);
            this.TBtensp.TabIndex = 6;
            // 
            // TBmota
            // 
            this.TBmota.Location = new System.Drawing.Point(93, 73);
            this.TBmota.Name = "TBmota";
            this.TBmota.Size = new System.Drawing.Size(316, 20);
            this.TBmota.TabIndex = 7;
            // 
            // Tbgia
            // 
            this.Tbgia.Location = new System.Drawing.Point(536, 12);
            this.Tbgia.Name = "Tbgia";
            this.Tbgia.Size = new System.Drawing.Size(203, 20);
            this.Tbgia.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBsoluong
            // 
            this.TBsoluong.Location = new System.Drawing.Point(536, 151);
            this.TBsoluong.Name = "TBsoluong";
            this.TBsoluong.Size = new System.Drawing.Size(203, 20);
            this.TBsoluong.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sam Sung",
            "Nokia",
            "Apple",
            "Hãng Khác"});
            this.comboBox1.Location = new System.Drawing.Point(536, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // ThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 321);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TBsoluong);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tbgia);
            this.Controls.Add(this.TBmota);
            this.Controls.Add(this.TBtensp);
            this.Controls.Add(this.LBnsx);
            this.Controls.Add(this.LBmota);
            this.Controls.Add(this.Lbhinh);
            this.Controls.Add(this.LBsoluong);
            this.Controls.Add(this.LBgia);
            this.Controls.Add(this.LBtensp);
            this.Name = "ThemSP";
            this.Text = "Hình";
            this.Load += new System.EventHandler(this.ThemSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBtensp;
        private System.Windows.Forms.Label LBgia;
        private System.Windows.Forms.Label LBsoluong;
        private System.Windows.Forms.Label Lbhinh;
        private System.Windows.Forms.Label LBmota;
        private System.Windows.Forms.Label LBnsx;
        private System.Windows.Forms.TextBox TBtensp;
        private System.Windows.Forms.TextBox TBmota;
        private System.Windows.Forms.TextBox Tbgia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TBsoluong;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}