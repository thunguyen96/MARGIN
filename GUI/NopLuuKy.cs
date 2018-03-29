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
using Newtonsoft.Json;
namespace GUI
    
{
    public partial class NopLuuKy : Form
    {
        public QLLuuKiDTO qLLuuKi;
        public DataGridView dataGridView;
        
        public NopLuuKy()
        {
            qLLuuKi = new QLLuuKiDTO();
            InitializeComponent();
        }

        private void NopLuuKy_Load(object sender, EventArgs e)
        {
           
            txthoTen.Text = qLLuuKi.HoTen;
            txtSDT.Text = qLLuuKi.SoDT;
            txtsoTKLK.Text = qLLuuKi.SoTKLK;
            txtsoCMND.Text = qLLuuKi.SoCMND;
            txtMaCK.Text = qLLuuKi.MaCK;
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Red;
            QLLuukiBUS qLLuukiBUS = new QLLuukiBUS();
            switch (qLLuukiBUS.KtraNopLuuKi(textsoLuongNop.Text))
            {
                case 1:
                    {
                        lblError.Text = "Bạn chưa nhập số lưu kí cần nộp";
                        break;
                    }
                case 2:
                    {
                        lblError.Text = "Số lưu kí phải là số";
                        break;
                    }
                case 0:
                    {
                        lblError.Text = "";
                        
                        if (qLLuukiBUS.nopLuuKi(txtsoTKLK.Text, txtMaCK.Text, qLLuuKi.SoLuong, long.Parse(textsoLuongNop.Text)))
                        {
                            long luuKi = qLLuuKi.SoLuong + long.Parse(textsoLuongNop.Text);

                            dataGridView.SelectedRows[0].Cells[2].Value = luuKi.ToString();

                            MessageBox.Show("Nộp lưu kí thành công");
                            Close();
                        }

                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
