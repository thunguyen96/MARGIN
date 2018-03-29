using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using GUI.QLTienMatWS;

namespace GUI
{
    public partial class NopTien : Form
    {
        public QLTienMatDTO qLTienMat;
        public TextBox textBox;

        public NopTien()
        {
            qLTienMat = new QLTienMatDTO();
            InitializeComponent();
        }

        private void NopTien_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = qLTienMat.HoTen;
            txtSDT.Text = qLTienMat.SDT;
            txtSoTKLK.Text = qLTienMat.SoTKLK;
            txtSoCMND.Text = qLTienMat.SoCMND;
        }

        private void btbThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Red;
            QLTienMatBUS qLTienMatBUS = new QLTienMatBUS();
            switch (qLTienMatBUS.KtraNopTien(txtSoTienNop.Text))
            {
                case 1:
                    {
                        lblError.Text = "Bạn chưa nhập số tiền nộp";
                        break;
                    }
                case 2:
                    {
                        lblError.Text = "Số tiền nộp phải là số nguyên dương";
                        break;
                    }
                case 3:
                    {
                        lblError.Text = "Số tiền nộp phải là bội của 1000";
                        break;
                    }
                case 0:
                    {
                        lblError.Text = "";
                        if (qLTienMatBUS.nopTien(txtSoTKLK.Text, qLTienMat.TienMat, long.Parse(txtSoTienNop.Text)))
                        {
                            long tien = qLTienMat.TienMat+ long.Parse(txtSoTienNop.Text);
                            textBox.Text = tien.ToString();
                            MessageBox.Show("Nộp tiền thành công");
                            Close();
                        }
                        
                        break;
                    }
            }
        }

        private void txtSoTKLK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
