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
    public partial class RutTien : Form
    {
        public QLTienMatDTO qLTienMat;
        public TextBox textBox;
        public RutTien()
        {
            InitializeComponent();
            qLTienMat = new QLTienMatDTO();
        }

        private void RutTien_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = qLTienMat.HoTen;
            txtSDT.Text = qLTienMat.SDT;
            txtSoTKLK.Text = qLTienMat.SoTKLK;
            txtSoCMND.Text = qLTienMat.SoCMND;
            txtSOTienRutToiDa.Text = qLTienMat.TienMat.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Red;
            QLTienMatBUS qLTienMatBUS = new QLTienMatBUS();
            switch (qLTienMatBUS.KtraRutTien(txtSoTienRut.Text, txtSOTienRutToiDa.Text))
            {
                case 1:
                    {
                        lblError.Text = "Bạn chưa nhập số tiền rút";
                        break;
                    }
                case 2:
                    {
                        lblError.Text = "Số tiền phải là số nguyên dương";
                        break;
                    }
                case 3:
                    {
                        lblError.Text = "Số tiền rút phải là bội của 1000";
                        break;
                    }
                case 4:
                    {
                        lblError.Text = "Số tiền rút phải nhỏ hơn số tiền rút tối đa";
                        break;
                    }
                case 0:
                    {
                        lblError.Text = "";
                        if(qLTienMatBUS.rutTien(txtSoTKLK.Text, qLTienMat.TienMat, long.Parse(txtSoTienRut.Text)))
                        {
                            long tien = qLTienMat.TienMat - long.Parse(txtSoTienRut.Text);
                            textBox.Text = tien.ToString();
                            MessageBox.Show("Rút tiền thành công");
                            Close();
                        }
                        
                        break;
                    }
            }
        }
    }
}
