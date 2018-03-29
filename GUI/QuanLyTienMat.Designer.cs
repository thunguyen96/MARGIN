namespace GUI
{
    partial class QuanLyTienMat
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
            this.txtTienMat = new System.Windows.Forms.TextBox();
            this.txtDuNo = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtSoTKLK = new System.Windows.Forms.TextBox();
            this.lblDuNo = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblTienMat = new System.Windows.Forms.Label();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.lblSoTKLK = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btbNop = new System.Windows.Forms.Button();
            this.btnRut = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTienMat
            // 
            this.txtTienMat.Location = new System.Drawing.Point(129, 102);
            this.txtTienMat.Name = "txtTienMat";
            this.txtTienMat.ReadOnly = true;
            this.txtTienMat.Size = new System.Drawing.Size(130, 20);
            this.txtTienMat.TabIndex = 5;
            // 
            // txtDuNo
            // 
            this.txtDuNo.Location = new System.Drawing.Point(421, 102);
            this.txtDuNo.Name = "txtDuNo";
            this.txtDuNo.ReadOnly = true;
            this.txtDuNo.Size = new System.Drawing.Size(127, 20);
            this.txtDuNo.TabIndex = 6;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(129, 67);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.ReadOnly = true;
            this.txtSoCMND.Size = new System.Drawing.Size(130, 20);
            this.txtSoCMND.TabIndex = 3;
            // 
            // txtSoTKLK
            // 
            this.txtSoTKLK.Location = new System.Drawing.Point(129, 36);
            this.txtSoTKLK.Name = "txtSoTKLK";
            this.txtSoTKLK.Size = new System.Drawing.Size(130, 20);
            this.txtSoTKLK.TabIndex = 1;
            this.txtSoTKLK.Leave += new System.EventHandler(this.txtSoTKLK_Leave_1);
            // 
            // lblDuNo
            // 
            this.lblDuNo.AutoSize = true;
            this.lblDuNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDuNo.Location = new System.Drawing.Point(324, 105);
            this.lblDuNo.Name = "lblDuNo";
            this.lblDuNo.Size = new System.Drawing.Size(36, 13);
            this.lblDuNo.TabIndex = 34;
            this.lblDuNo.Text = "Dư nợ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSDT.Location = new System.Drawing.Point(324, 70);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(70, 13);
            this.lblSDT.TabIndex = 33;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHoTen.Location = new System.Drawing.Point(324, 39);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 13);
            this.lblHoTen.TabIndex = 32;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // lblTienMat
            // 
            this.lblTienMat.AutoSize = true;
            this.lblTienMat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTienMat.Location = new System.Drawing.Point(28, 105);
            this.lblTienMat.Name = "lblTienMat";
            this.lblTienMat.Size = new System.Drawing.Size(48, 13);
            this.lblTienMat.TabIndex = 31;
            this.lblTienMat.Text = "Tiền mặt";
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.AutoSize = true;
            this.lblSoCMND.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSoCMND.Location = new System.Drawing.Point(28, 70);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(55, 13);
            this.lblSoCMND.TabIndex = 30;
            this.lblSoCMND.Text = "Số CMND";
            // 
            // lblSoTKLK
            // 
            this.lblSoTKLK.AutoSize = true;
            this.lblSoTKLK.ForeColor = System.Drawing.Color.Red;
            this.lblSoTKLK.Location = new System.Drawing.Point(28, 39);
            this.lblSoTKLK.Name = "lblSoTKLK";
            this.lblSoTKLK.Size = new System.Drawing.Size(68, 13);
            this.lblSoTKLK.TabIndex = 29;
            this.lblSoTKLK.Text = "Số TK lưu ký";
            this.lblSoTKLK.Click += new System.EventHandler(this.lblSoTKLK_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(421, 67);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(127, 20);
            this.txtSDT.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(421, 36);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(127, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(324, 144);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 43;
            // 
            // btbNop
            // 
            this.btbNop.Enabled = false;
            this.btbNop.Location = new System.Drawing.Point(115, 182);
            this.btbNop.Name = "btbNop";
            this.btbNop.Size = new System.Drawing.Size(75, 23);
            this.btbNop.TabIndex = 7;
            this.btbNop.Text = "Nộp";
            this.btbNop.UseVisualStyleBackColor = true;
            this.btbNop.Click += new System.EventHandler(this.btbNop_Click);
            // 
            // btnRut
            // 
            this.btnRut.Enabled = false;
            this.btnRut.Location = new System.Drawing.Point(245, 182);
            this.btnRut.Name = "btnRut";
            this.btnRut.Size = new System.Drawing.Size(75, 23);
            this.btnRut.TabIndex = 8;
            this.btnRut.Text = "Rút";
            this.btnRut.UseVisualStyleBackColor = true;
            this.btnRut.Click += new System.EventHandler(this.btnRut_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(385, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // QuanLyTienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 224);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnRut);
            this.Controls.Add(this.btbNop);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTienMat);
            this.Controls.Add(this.txtDuNo);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.txtSoTKLK);
            this.Controls.Add(this.lblDuNo);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTienMat);
            this.Controls.Add(this.lblSoCMND);
            this.Controls.Add(this.lblSoTKLK);
            this.Name = "QuanLyTienMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tiền mặt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTienMat;
        private System.Windows.Forms.TextBox txtDuNo;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtSoTKLK;
        private System.Windows.Forms.Label lblDuNo;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblTienMat;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.Label lblSoTKLK;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btbNop;
        private System.Windows.Forms.Button btnRut;
        private System.Windows.Forms.Button btnThoat;
    }
}