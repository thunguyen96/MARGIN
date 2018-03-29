using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using GUI.QLTienMatWS;
using DTO;

namespace GUI
{
    public partial class QuanLyTienMat : Form
    {
        public QuanLyTienMat()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSoTKLK_Leave_1(object sender, EventArgs e)
        {
            try
            {
                QLTienMatBUS qLTienMatBUS = new QLTienMatBUS();
                //lấy thông tin từ số TKLK
                string jsonData = qLTienMatBUS.timKiem(txtSoTKLK.Text);
                QLTienMatDTO list = JsonConvert.DeserializeObject<QLTienMatDTO>(jsonData);

                lblError.ForeColor = Color.Red;
                if (txtSoTKLK.Text == "")
                {
                    lblError.Text = "Dòng màu đỏ là thông tin bắt buộc nhập";
                }else 
                if (list == null)
                {
                    lblError.Text = "Số TKLK không có trong hệ thống";
                }
                else
                {
                    txtHoTen.Text = list.HoTen;
                    txtSDT.Text = list.SDT;
                    txtSoCMND.Text = list.SoCMND;
                    txtDuNo.Text = list.DuNo.ToString();
                    txtTienMat.Text = list.TienMat.ToString();
                    lblError.Text = "";
                    btbNop.Enabled = true;
                    btnRut.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btbNop_Click(object sender, EventArgs e)
        {
            NopTien nopTien = new NopTien();
            nopTien.textBox = txtTienMat;
            nopTien.qLTienMat.SoTKLK = txtSoTKLK.Text;
            nopTien.qLTienMat.SoCMND = txtSoCMND.Text;
            nopTien.qLTienMat.HoTen = txtHoTen.Text;
            nopTien.qLTienMat.SDT = txtSDT.Text;
            nopTien.qLTienMat.TienMat = long.Parse(txtTienMat.Text);
            nopTien.qLTienMat.DuNo = long.Parse(txtDuNo.Text);
            nopTien.ShowDialog();
        }
        
        private void btnRut_Click(object sender, EventArgs e)
        {
            RutTien rutTien = new RutTien();
            rutTien.textBox = txtTienMat;
            rutTien.qLTienMat.SoTKLK = txtSoTKLK.Text;
            rutTien.qLTienMat.SoCMND = txtSoCMND.Text;
            rutTien.qLTienMat.HoTen = txtHoTen.Text;
            rutTien.qLTienMat.SDT = txtSDT.Text;
            rutTien.qLTienMat.TienMat = long.Parse(txtTienMat.Text);
            rutTien.qLTienMat.DuNo = long.Parse(txtDuNo.Text);
            rutTien.ShowDialog();
        }

        private void lblSoTKLK_Click(object sender, EventArgs e)
        {

        }
    }
}
