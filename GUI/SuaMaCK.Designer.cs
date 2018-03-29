namespace GUI
{
    partial class SuaMaCK
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtGiaSan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaTran = new System.Windows.Forms.TextBox();
            this.txtTenCK = new System.Windows.Forms.TextBox();
            this.txtmaCK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(166, 188);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGiaSan
            // 
            this.txtGiaSan.Location = new System.Drawing.Point(139, 128);
            this.txtGiaSan.Name = "txtGiaSan";
            this.txtGiaSan.Size = new System.Drawing.Size(130, 20);
            this.txtGiaSan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(38, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Giá sàn";
            // 
            // txtGiaTran
            // 
            this.txtGiaTran.Location = new System.Drawing.Point(139, 93);
            this.txtGiaTran.Name = "txtGiaTran";
            this.txtGiaTran.Size = new System.Drawing.Size(130, 20);
            this.txtGiaTran.TabIndex = 1;
            // 
            // txtTenCK
            // 
            this.txtTenCK.Location = new System.Drawing.Point(139, 61);
            this.txtTenCK.Name = "txtTenCK";
            this.txtTenCK.ReadOnly = true;
            this.txtTenCK.Size = new System.Drawing.Size(130, 20);
            this.txtTenCK.TabIndex = 96;
            // 
            // txtmaCK
            // 
            this.txtmaCK.Location = new System.Drawing.Point(139, 27);
            this.txtmaCK.Name = "txtmaCK";
            this.txtmaCK.ReadOnly = true;
            this.txtmaCK.Size = new System.Drawing.Size(130, 20);
            this.txtmaCK.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(38, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Giá trần";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Tên CK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Mã CK";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(71, 160);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 99;
            // 
            // SuaMaCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 233);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGiaSan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiaTran);
            this.Controls.Add(this.txtTenCK);
            this.Controls.Add(this.txtmaCK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "SuaMaCK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaMaCK";
            this.Load += new System.EventHandler(this.SuaMaCK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGiaSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTran;
        private System.Windows.Forms.TextBox txtTenCK;
        private System.Windows.Forms.TextBox txtmaCK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblError;
    }
}