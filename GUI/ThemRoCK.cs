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
using Newtonsoft.Json;

namespace GUI
{
    public partial class ThemRoCK : Form
    {
        public ThemRoCK()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void ThemRoCK_Load(object sender, EventArgs e)
        {
            QLRoCKBUS qLRo = new QLRoCKBUS();
            txtMaRo.Text = qLRo.taoMaRo();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                QLRoCKBUS qLRo = new QLRoCKBUS();
                switch (qLRo.KTThongTinThemRoCK(txtTenRo.Text))
                {
                    case 1:
                        {
                            lblError.Text = "Bạn chưa nhập Tên Rổ";
                            break;
                        }
                    case 2:
                        {
                            lblError.Text = "Tên rổ không hợp lệ";
                            break;
                        }
                    case 0:
                        {
                            lblError.Text = "";
                            RoCK roCK = new RoCK();

                            roCK.MaRo = txtMaRo.Text;
                            roCK.TenRo = txtTenRo.Text;

                            string jsonDataAdd = JsonConvert.SerializeObject(roCK);
                            if (qLRo.ThemRoCK(jsonDataAdd))
                            {
                                QLRoCKDTO qLRoCKDTO = new QLRoCKDTO();
                                qLRoCKDTO.MaRo = txtMaRo.Text;

                                string jsonData = JsonConvert.SerializeObject(qLRoCKDTO);


                                MessageBox.Show("Thêm rổ mới thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Đã có lỗi xảy ra, thêm rổ mới thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
