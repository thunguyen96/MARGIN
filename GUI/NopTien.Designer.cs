namespace GUI
{
    partial class NopTien
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtSoTienNop = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtSoTKLK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNop = new System.Windows.Forms.Button();
            this.btbThoat = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(418, 33);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(127, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(418, 67);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(127, 20);
            this.txtSDT.TabIndex = 4;
            // 
            // txtSoTienNop
            // 
            this.txtSoTienNop.Location = new System.Drawing.Point(126, 99);
            this.txtSoTienNop.Name = "txtSoTienNop";
            this.txtSoTienNop.Size = new System.Drawing.Size(130, 20);
            this.txtSoTienNop.TabIndex = 5;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(126, 67);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.ReadOnly = true;
            this.txtSoCMND.Size = new System.Drawing.Size(130, 20);
            this.txtSoCMND.TabIndex = 3;
            // 
            // txtSoTKLK
            // 
            this.txtSoTKLK.Location = new System.Drawing.Point(126, 33);
            this.txtSoTKLK.Name = "txtSoTKLK";
            this.txtSoTKLK.ReadOnly = true;
            this.txtSoTKLK.Size = new System.Drawing.Size(130, 20);
            this.txtSoTKLK.TabIndex = 1;
            this.txtSoTKLK.TextChanged += new System.EventHandler(this.txtSoTKLK_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(321, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(321, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Số tiền nộp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Số CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Số TK lưu ký";
            // 
            // btnNop
            // 
            this.btnNop.Location = new System.Drawing.Point(166, 149);
            this.btnNop.Name = "btnNop";
            this.btnNop.Size = new System.Drawing.Size(75, 23);
            this.btnNop.TabIndex = 6;
            this.btnNop.Text = "Nộp";
            this.btnNop.UseVisualStyleBackColor = true;
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // btbThoat
            // 
            this.btbThoat.Location = new System.Drawing.Point(333, 149);
            this.btbThoat.Name = "btbThoat";
            this.btbThoat.Size = new System.Drawing.Size(75, 23);
            this.btbThoat.TabIndex = 7;
            this.btbThoat.Text = "Thoát";
            this.btbThoat.UseVisualStyleBackColor = true;
            this.btbThoat.Click += new System.EventHandler(this.btbThoat_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(321, 102);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 57;
            // 
            // NopTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 200);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btbThoat);
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtSoTienNop);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.txtSoTKLK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NopTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nộp tiền";
            this.Load += new System.EventHandler(this.NopTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtSoTienNop;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtSoTKLK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNop;
        private System.Windows.Forms.Button btbThoat;
        private System.Windows.Forms.Label lblError;
    }
}