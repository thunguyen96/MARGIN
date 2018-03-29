namespace GUI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyKH = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTienMat = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyLuuKy = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyDanhMucCK = new System.Windows.Forms.ToolStripMenuItem();
            this.qlRoCK = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyGiaoDichMua = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyKH,
            this.quanLyTienMat,
            this.quanLyLuuKy,
            this.quanLyDanhMucCK,
            this.qlRoCK,
            this.quanLyGiaoDichMua,
            this.thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyKH
            // 
            this.quanLyKH.Name = "quanLyKH";
            this.quanLyKH.Size = new System.Drawing.Size(79, 20);
            this.quanLyKH.Text = "Quản lý KH";
            this.quanLyKH.Click += new System.EventHandler(this.quanLyKH_Click);
            // 
            // quanLyTienMat
            // 
            this.quanLyTienMat.Name = "quanLyTienMat";
            this.quanLyTienMat.Size = new System.Drawing.Size(107, 20);
            this.quanLyTienMat.Text = "Quản lý tiền mặt";
            this.quanLyTienMat.Click += new System.EventHandler(this.quanLyTienMat_Click);
            // 
            // quanLyLuuKy
            // 
            this.quanLyLuuKy.Name = "quanLyLuuKy";
            this.quanLyLuuKy.Size = new System.Drawing.Size(95, 20);
            this.quanLyLuuKy.Text = "Quản lý lưu ký";
            this.quanLyLuuKy.Click += new System.EventHandler(this.quanLyLuuKy_Click);
            // 
            // quanLyDanhMucCK
            // 
            this.quanLyDanhMucCK.Name = "quanLyDanhMucCK";
            this.quanLyDanhMucCK.Size = new System.Drawing.Size(133, 20);
            this.quanLyDanhMucCK.Text = "Quản lý chứng khoán";
            this.quanLyDanhMucCK.Click += new System.EventHandler(this.quanLyDanhMucCK_Click);
            // 
            // qlRoCK
            // 
            this.qlRoCK.Name = "qlRoCK";
            this.qlRoCK.Size = new System.Drawing.Size(92, 20);
            this.qlRoCK.Text = "Quản lý rổ CK";
            this.qlRoCK.Click += new System.EventHandler(this.baoCao_Click);
            // 
            // quanLyGiaoDichMua
            // 
            this.quanLyGiaoDichMua.Name = "quanLyGiaoDichMua";
            this.quanLyGiaoDichMua.Size = new System.Drawing.Size(139, 20);
            this.quanLyGiaoDichMua.Text = "Quản lý giao dịch mua";
            this.quanLyGiaoDichMua.Click += new System.EventHandler(this.quanLyGiaoDichMua_Click);
            // 
            // thoat
            // 
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(50, 20);
            this.thoat.Text = "Thoát";
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 245);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục và sức mua cho khách hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyKH;
        private System.Windows.Forms.ToolStripMenuItem quanLyTienMat;
        private System.Windows.Forms.ToolStripMenuItem quanLyLuuKy;
        private System.Windows.Forms.ToolStripMenuItem quanLyDanhMucCK;
        private System.Windows.Forms.ToolStripMenuItem quanLyGiaoDichMua;
        private System.Windows.Forms.ToolStripMenuItem qlRoCK;
        private System.Windows.Forms.ToolStripMenuItem thoat;
    }
}