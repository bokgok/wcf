namespace MobileDesktop
{
    partial class FormSanPham
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxNhasanxuat = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.BTthem = new System.Windows.Forms.Button();
            this.Tbsoluong = new System.Windows.Forms.TextBox();
            this.Tbmota = new System.Windows.Forms.TextBox();
            this.Tbgia = new System.Windows.Forms.TextBox();
            this.TBhinh = new System.Windows.Forms.TextBox();
            this.Tbtensp = new System.Windows.Forms.TextBox();
            this.TBmasp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chonhinh = new System.Windows.Forms.Button();
            this.checkBoxhinh = new System.Windows.Forms.CheckBox();
            this.BTcapnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(857, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cbxNhasanxuat
            // 
            this.cbxNhasanxuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhasanxuat.FormattingEnabled = true;
            this.cbxNhasanxuat.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxNhasanxuat.Location = new System.Drawing.Point(693, 68);
            this.cbxNhasanxuat.Name = "cbxNhasanxuat";
            this.cbxNhasanxuat.Size = new System.Drawing.Size(176, 21);
            this.cbxNhasanxuat.TabIndex = 44;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(693, 180);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(477, 180);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // BTthem
            // 
            this.BTthem.Location = new System.Drawing.Point(86, 180);
            this.BTthem.Name = "BTthem";
            this.BTthem.Size = new System.Drawing.Size(75, 23);
            this.BTthem.TabIndex = 41;
            this.BTthem.Text = "Thêm";
            this.BTthem.UseVisualStyleBackColor = true;
            this.BTthem.Click += new System.EventHandler(this.BTthem_Click);
            // 
            // Tbsoluong
            // 
            this.Tbsoluong.Location = new System.Drawing.Point(86, 126);
            this.Tbsoluong.Name = "Tbsoluong";
            this.Tbsoluong.Size = new System.Drawing.Size(176, 20);
            this.Tbsoluong.TabIndex = 38;
            // 
            // Tbmota
            // 
            this.Tbmota.Location = new System.Drawing.Point(397, 68);
            this.Tbmota.Name = "Tbmota";
            this.Tbmota.Size = new System.Drawing.Size(176, 20);
            this.Tbmota.TabIndex = 36;
            // 
            // Tbgia
            // 
            this.Tbgia.Location = new System.Drawing.Point(86, 68);
            this.Tbgia.Name = "Tbgia";
            this.Tbgia.Size = new System.Drawing.Size(176, 20);
            this.Tbgia.TabIndex = 35;
            // 
            // TBhinh
            // 
            this.TBhinh.Location = new System.Drawing.Point(693, 12);
            this.TBhinh.Name = "TBhinh";
            this.TBhinh.Size = new System.Drawing.Size(176, 20);
            this.TBhinh.TabIndex = 34;
            // 
            // Tbtensp
            // 
            this.Tbtensp.Location = new System.Drawing.Point(397, 13);
            this.Tbtensp.Name = "Tbtensp";
            this.Tbtensp.Size = new System.Drawing.Size(176, 20);
            this.Tbtensp.TabIndex = 33;
            // 
            // TBmasp
            // 
            this.TBmasp.Location = new System.Drawing.Point(86, 12);
            this.TBmasp.Name = "TBmasp";
            this.TBmasp.ReadOnly = true;
            this.TBmasp.Size = new System.Drawing.Size(176, 20);
            this.TBmasp.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nhà sản xuất:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Hình:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tên SP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã SP:";
            // 
            // chonhinh
            // 
            this.chonhinh.Location = new System.Drawing.Point(794, 39);
            this.chonhinh.Name = "chonhinh";
            this.chonhinh.Size = new System.Drawing.Size(75, 23);
            this.chonhinh.TabIndex = 45;
            this.chonhinh.Text = "Chọn hình";
            this.chonhinh.UseVisualStyleBackColor = true;
            this.chonhinh.Click += new System.EventHandler(this.chonhinh_Click);
            // 
            // checkBoxhinh
            // 
            this.checkBoxhinh.AutoSize = true;
            this.checkBoxhinh.Location = new System.Drawing.Point(708, 44);
            this.checkBoxhinh.Name = "checkBoxhinh";
            this.checkBoxhinh.Size = new System.Drawing.Size(68, 17);
            this.checkBoxhinh.TabIndex = 46;
            this.checkBoxhinh.Text = "Hình Mới";
            this.checkBoxhinh.UseVisualStyleBackColor = true;
            // 
            // BTcapnhat
            // 
            this.BTcapnhat.Location = new System.Drawing.Point(277, 180);
            this.BTcapnhat.Name = "BTcapnhat";
            this.BTcapnhat.Size = new System.Drawing.Size(75, 23);
            this.BTcapnhat.TabIndex = 47;
            this.BTcapnhat.Text = "Cập Nhật";
            this.BTcapnhat.UseVisualStyleBackColor = true;
            this.BTcapnhat.Click += new System.EventHandler(this.BTcapnhat_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 476);
            this.Controls.Add(this.BTcapnhat);
            this.Controls.Add(this.checkBoxhinh);
            this.Controls.Add(this.chonhinh);
            this.Controls.Add(this.cbxNhasanxuat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.BTthem);
            this.Controls.Add(this.Tbsoluong);
            this.Controls.Add(this.Tbmota);
            this.Controls.Add(this.Tbgia);
            this.Controls.Add(this.TBhinh);
            this.Controls.Add(this.Tbtensp);
            this.Controls.Add(this.TBmasp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSanPham";
            this.Text = "Quản Lý Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxNhasanxuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button BTthem;
        private System.Windows.Forms.TextBox Tbsoluong;
        private System.Windows.Forms.TextBox Tbmota;
        private System.Windows.Forms.TextBox Tbgia;
        private System.Windows.Forms.TextBox TBhinh;
        private System.Windows.Forms.TextBox Tbtensp;
        private System.Windows.Forms.TextBox TBmasp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chonhinh;
        private System.Windows.Forms.CheckBox checkBoxhinh;
        private System.Windows.Forms.Button BTcapnhat;
    }
}