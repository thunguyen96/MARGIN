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
using GUI.QLRoCKWS;
using GUI.CheckWS;
using Newtonsoft.Json;

namespace GUI
{
    public partial class SuaRoCK : Form
    {
        public QLRoCKDTO roCK;
        public DataGridView dataGridView;

        public SuaRoCK()
        {
            InitializeComponent();
            roCK = new QLRoCKDTO();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SuaRoCK_Load(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Red;

            txtMaRo.Text = roCK.MaRo;
            txtTenRo.Text = roCK.TenRo;
            txtmaCK.Text = roCK.MaCK;
            txtGiaVay.Text = roCK.GiaVay.ToString();
            txtTiLeVay.Text = roCK.TiLeVay.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra lỗi nhập
                QLRoCKBUS roCKBUS = new QLRoCKBUS();
                switch (roCKBUS.KTThongTinSuaRoCK(txtGiaVay.Text, txtTiLeVay.Text))
                {
                    case 1:
                        {
                            lblError.Text = "Giá vay không được để trống";
                            break;
                        }
                    case 2:
                        {
                            lblError.Text = "Tỉ lệ vay không được để trống";
                            break;
                        }
                    case 3:
                        {
                            lblError.Text = "Giá vay không hợp lệ";
                            break;
                        }
                    case 4:
                        {
                            lblError.Text = "Tỉ lệ vay không hợp lệ";
                            break;
                        }
                    case 0:
                        {
                            lblError.Text = "";

                            if (roCKBUS.suaTTMaCK(txtMaRo.Text, txtmaCK.Text, txtGiaVay.Text, txtTiLeVay.Text))
                            {

                                MessageBox.Show("Sửa mã chứng khoán thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Đã có lỗi xảy ra, sửa mã chứng khoán thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
