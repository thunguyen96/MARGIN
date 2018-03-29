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
using GUI.QLLuuKiWS;

namespace GUI
{
    public partial class RutLuuKy : Form
    {
        public QLLuuKiDTO qLLuuKi;
        public DataGridView dataGridView;
        public RutLuuKy()
        {
            qLLuuKi = new QLLuuKiDTO();
            InitializeComponent();
        }

        private void RutLuuKy_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = qLLuuKi.HoTen;
            txtSDT.Text = qLLuuKi.SoDT;
            txtsoTKLK.Text = qLLuuKi.SoTKLK;
            txtsoCMND.Text = qLLuuKi.SoCMND;
            txtmaCK.Text = qLLuuKi.MaCK;
            txtsoLuongToiDa.Text = qLLuuKi.SoLuong.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRut_Click(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Red;
            QLLuukiBUS qLLuukiBUS = new QLLuukiBUS();
            switch (qLLuukiBUS.KtraRutLuuKi(txtsoLuongRut.Text, txtsoLuongToiDa.Text))
            {
                case 1:
                    {
                        lblError.Text = "Bạn chưa nhập số lưu kí cần rút";
                        break;
                    }
                case 2:
                    {
                        lblError.Text = "Số lưu kí phải là số";
                        break;
                    }
                
                case 3:
                    {
                        lblError.Text = "Số lưu kí rút lớn hơn số lượng tối đa có thể rút";
                        break;
                    }
                case 0:
                    {
                        lblError.Text = "";

                       if (qLLuukiBUS.rutLuuKi(txtsoTKLK.Text, txtmaCK.Text, qLLuuKi.SoLuong, long.Parse(txtsoLuongRut.Text)))
                        {
                            long luuKi = qLLuuKi.SoLuong - long.Parse(txtsoLuongRut.Text);

                            dataGridView.SelectedRows[0].Cells[2].Value = luuKi.ToString();

                            MessageBox.Show("Rút lưu kí thành công");
                            Close();
                        }

                        break;
                    }
            }
        }
    }
}
