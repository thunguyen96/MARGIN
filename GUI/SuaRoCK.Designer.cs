namespace GUI
{
    partial class SuaRoCK
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmaCK = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTiLeVay = new System.Windows.Forms.TextBox();
            this.txtGiaVay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaRo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaRo = new System.Windows.Forms.Label();
            this.txtTenRo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(282, 276);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(144, 276);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa mã CK";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmaCK);
            this.groupBox2.Controls.Add(this.lblError);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTiLeVay);
            this.groupBox2.Controls.Add(this.txtGiaVay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(18, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 120);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mã chứng khoán";
            // 
            // txtmaCK
            // 
            this.txtmaCK.Enabled = false;
            this.txtmaCK.Location = new System.Drawing.Point(173, 16);
            this.txtmaCK.Name = "txtmaCK";
            this.txtmaCK.Size = new System.Drawing.Size(154, 20);
            this.txtmaCK.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(343, 50);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(28, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã chứng khoán";
            // 
            // txtTiLeVay
            // 
            this.txtTiLeVay.Location = new System.Drawing.Point(173, 79);
            this.txtTiLeVay.Name = "txtTiLeVay";
            this.txtTiLeVay.Size = new System.Drawing.Size(154, 20);
            this.txtTiLeVay.TabIndex = 5;
            // 
            // txtGiaVay
            // 
            this.txtGiaVay.Location = new System.Drawing.Point(173, 50);
            this.txtGiaVay.Name = "txtGiaVay";
            this.txtGiaVay.Size = new System.Drawing.Size(154, 20);
            this.txtGiaVay.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(28, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tỉ lệ vay";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(28, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá vay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaRo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMaRo);
            this.groupBox1.Controls.Add(this.txtTenRo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 109);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chứng khoán";
            // 
            // txtMaRo
            // 
            this.txtMaRo.Enabled = false;
            this.txtMaRo.Location = new System.Drawing.Point(173, 26);
            this.txtMaRo.Name = "txtMaRo";
            this.txtMaRo.Size = new System.Drawing.Size(154, 20);
            this.txtMaRo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(75, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lblMaRo
            // 
            this.lblMaRo.AutoSize = true;
            this.lblMaRo.Location = new System.Drawing.Point(28, 29);
            this.lblMaRo.Name = "lblMaRo";
            this.lblMaRo.Size = new System.Drawing.Size(34, 13);
            this.lblMaRo.TabIndex = 6;
            this.lblMaRo.Text = "Mã rổ";
            // 
            // txtTenRo
            // 
            this.txtTenRo.Enabled = false;
            this.txtTenRo.Location = new System.Drawing.Point(173, 64);
            this.txtTenRo.Name = "txtTenRo";
            this.txtTenRo.Size = new System.Drawing.Size(154, 20);
            this.txtTenRo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên rổ";
            // 
            // SuaRoCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 312);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SuaRoCK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa mã chứng khoán cho rổ";
            this.Load += new System.EventHandler(this.SuaRoCK_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTiLeVay;
        private System.Windows.Forms.TextBox txtGiaVay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
       
        private System.Windows.Forms.TextBox txtMaRo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaRo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtmaCK;
        private System.Windows.Forms.TextBox txtTenRo;
        private System.Windows.Forms.Label label3;
    }
}