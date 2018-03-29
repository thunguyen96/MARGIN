namespace GUI
{
    partial class QuanLyLuuKy
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
            this.txthoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtsoCMND = new System.Windows.Forms.TextBox();
            this.txtSoTKLK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnRut = new System.Windows.Forms.Button();
            this.btnNop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txthoTen
            // 
            this.txthoTen.Location = new System.Drawing.Point(501, 26);
            this.txthoTen.Name = "txthoTen";
            this.txthoTen.ReadOnly = true;
            this.txthoTen.Size = new System.Drawing.Size(127, 20);
            this.txthoTen.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(501, 60);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(127, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtsoCMND
            // 
            this.txtsoCMND.Location = new System.Drawing.Point(209, 60);
            this.txtsoCMND.Name = "txtsoCMND";
            this.txtsoCMND.ReadOnly = true;
            this.txtsoCMND.Size = new System.Drawing.Size(130, 20);
            this.txtsoCMND.TabIndex = 2;
            // 
            // txtSoTKLK
            // 
            this.txtSoTKLK.Location = new System.Drawing.Point(209, 26);
            this.txtSoTKLK.Name = "txtSoTKLK";
            this.txtSoTKLK.Size = new System.Drawing.Size(130, 20);
            this.txtSoTKLK.TabIndex = 1;
            this.txtSoTKLK.Enter += new System.EventHandler(this.txtSoTKLK_Enter);
            this.txtSoTKLK.Leave += new System.EventHandler(this.txtSoTKLK_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(404, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(404, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(108, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Số CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(108, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Số TK lưu ký";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(484, 100);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(172, 13);
            this.lblError.TabIndex = 75;
            this.lblError.Text = "Dòng màu đỏ là thông tin bắt buộc";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.gridView.Location = new System.Drawing.Point(6, 116);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(732, 240);
            this.gridView.TabIndex = 76;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã CK";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên CK";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá vay";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tỉ lệ vay";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tài sản đảm bảo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(475, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnRut
            // 
            this.btnRut.Location = new System.Drawing.Point(335, 393);
            this.btnRut.Name = "btnRut";
            this.btnRut.Size = new System.Drawing.Size(75, 23);
            this.btnRut.TabIndex = 4;
            this.btnRut.Text = "Rút";
            this.btnRut.UseVisualStyleBackColor = true;
            this.btnRut.Click += new System.EventHandler(this.btnRut_Click);
            // 
            // btnNop
            // 
            this.btnNop.Location = new System.Drawing.Point(205, 393);
            this.btnNop.Name = "btnNop";
            this.btnNop.Size = new System.Drawing.Size(75, 23);
            this.btnNop.TabIndex = 3;
            this.btnNop.Text = "Nộp";
            this.btnNop.UseVisualStyleBackColor = true;
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // QuanLyLuuKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 438);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnRut);
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txthoTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtsoCMND);
            this.Controls.Add(this.txtSoTKLK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyLuuKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lưu kí";
            this.Load += new System.EventHandler(this.QuanLyLuuKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtsoCMND;
        private System.Windows.Forms.TextBox txtSoTKLK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnRut;
        private System.Windows.Forms.Button btnNop;
    }
}