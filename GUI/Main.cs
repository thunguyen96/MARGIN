using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quanLyKH_Click(object sender, EventArgs e)
        {
            QuanLyKH quanLyKH = new QuanLyKH();
            quanLyKH.ShowDialog();
        }

        private void quanLyTienMat_Click(object sender, EventArgs e)
        {
            QuanLyTienMat quanLyTienMat = new QuanLyTienMat();
            quanLyTienMat.ShowDialog();
        }

        private void quanLyLuuKy_Click(object sender, EventArgs e)
        {
            QuanLyLuuKy quanLyLuuKy = new QuanLyLuuKy();
            quanLyLuuKy.ShowDialog();
        }

        private void quanLyDanhMucCK_Click(object sender, EventArgs e)
        {
            QuanLyDSCK quanLyDSCK = new QuanLyDSCK();
            quanLyDSCK.ShowDialog();
        }

        private void quanLyGiaoDichMua_Click(object sender, EventArgs e)
        {
            QuanLyGiaoDichMua quanLyGiaoDichMua = new QuanLyGiaoDichMua();
            quanLyGiaoDichMua.ShowDialog();
        }

        private void baoCao_Click(object sender, EventArgs e)
        {
            QuanLyRoCK quanLyRoCK = new QuanLyRoCK();
            quanLyRoCK.ShowDialog();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
