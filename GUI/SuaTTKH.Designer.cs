namespace GUI
{
    partial class SuaTTKH
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
            this.cmbMaRo = new System.Windows.Forms.ComboBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMoTK = new System.Windows.Forms.Button();
            this.datengaySinh = new System.Windows.Forms.DateTimePicker();
            this.dateNgayCap = new System.Windows.Forms.DateTimePicker();
            this.txtHanMucVay = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoTKLK = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayMoTK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbMaRo
            // 
            this.cmbMaRo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaRo.FormattingEnabled = true;
            this.cmbMaRo.Location = new System.Drawing.Point(129, 223);
            this.cmbMaRo.Name = "cmbMaRo";
            this.cmbMaRo.Size = new System.Drawing.Size(130, 21);
            this.cmbMaRo.TabIndex = 15;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(129, 81);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(130, 21);
            this.cmbGioiTinh.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(324, 231);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(192, 13);
            this.lblError.TabIndex = 60;
            this.lblError.Text = "Các dòng màu đỏ là thông tin bắt buộc";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(304, 275);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMoTK
            // 
            this.btnMoTK.Location = new System.Drawing.Point(172, 275);
            this.btnMoTK.Name = "btnMoTK";
            this.btnMoTK.Size = new System.Drawing.Size(75, 23);
            this.btnMoTK.TabIndex = 16;
            this.btnMoTK.Text = "Lưu";
            this.btnMoTK.UseVisualStyleBackColor = true;
            this.btnMoTK.Click += new System.EventHandler(this.btnMoTK_Click);
            // 
            // datengaySinh
            // 
            this.datengaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datengaySinh.Location = new System.Drawing.Point(421, 47);
            this.datengaySinh.Name = "datengaySinh";
            this.datengaySinh.Size = new System.Drawing.Size(127, 20);
            this.datengaySinh.TabIndex = 4;
            this.datengaySinh.Value = new System.DateTime(2018, 3, 26, 22, 58, 28, 0);
            // 
            // dateNgayCap
            // 
            this.dateNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayCap.Location = new System.Drawing.Point(129, 115);
            this.dateNgayCap.Name = "dateNgayCap";
            this.dateNgayCap.Size = new System.Drawing.Size(130, 20);
            this.dateNgayCap.TabIndex = 7;
            this.dateNgayCap.Value = new System.DateTime(2018, 3, 26, 0, 0, 0, 0);
            // 
            // txtHanMucVay
            // 
            this.txtHanMucVay.Location = new System.Drawing.Point(421, 195);
            this.txtHanMucVay.Name = "txtHanMucVay";
            this.txtHanMucVay.Size = new System.Drawing.Size(127, 20);
            this.txtHanMucVay.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(421, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(127, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(129, 192);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(130, 20);
            this.txtSDT.TabIndex = 13;
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(421, 118);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(127, 20);
            this.txtNoiCap.TabIndex = 8;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(421, 81);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(127, 20);
            this.txtSoCMND.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(129, 156);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(130, 20);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(129, 47);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(130, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtSoTKLK
            // 
            this.txtSoTKLK.Enabled = false;
            this.txtSoTKLK.Location = new System.Drawing.Point(129, 15);
            this.txtSoTKLK.Name = "txtSoTKLK";
            this.txtSoTKLK.Size = new System.Drawing.Size(130, 20);
            this.txtSoTKLK.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(324, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Số CMND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(324, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Ngày sinh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(324, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Nơi cấp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(324, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Ngày mở TK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(324, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(324, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Hạn mức vay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(28, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Mã rổ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(28, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(28, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(28, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Số TK lưu ký";
            // 
            // txtNgayMoTK
            // 
            this.txtNgayMoTK.Enabled = false;
            this.txtNgayMoTK.Location = new System.Drawing.Point(421, 15);
            this.txtNgayMoTK.Name = "txtNgayMoTK";
            this.txtNgayMoTK.Size = new System.Drawing.Size(127, 20);
            this.txtNgayMoTK.TabIndex = 2;
            // 
            // SuaTTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 321);
            this.Controls.Add(this.txtNgayMoTK);
            this.Controls.Add(this.cmbMaRo);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMoTK);
            this.Controls.Add(this.datengaySinh);
            this.Controls.Add(this.dateNgayCap);
            this.Controls.Add(this.txtHanMucVay);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtNoiCap);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSoTKLK);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuaTTKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin khách hàng";
            this.Load += new System.EventHandler(this.SuaTTKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaRo;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMoTK;
        private System.Windows.Forms.DateTimePicker datengaySinh;
        private System.Windows.Forms.DateTimePicker dateNgayCap;
        private System.Windows.Forms.TextBox txtHanMucVay;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoTKLK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayMoTK;
    }
}