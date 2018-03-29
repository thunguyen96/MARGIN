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
using GUI.QLCKWS;
using Newtonsoft.Json;

namespace GUI
{
    public partial class ThemMoiMaCK : Form
    {
        public ThemMoiMaCK()
        {
            InitializeComponent();
        }

        //Thêm mới mã chứng khoán
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QLCKBUS chungkhoanBUS = new QLCKBUS();
                switch (chungkhoanBUS.KTThongTinThemCK(txtMaCK.Text, txtTenCK.Text, txtGiaTran.Text, txtGiaSan.Text))
                {
                    case 1:
                        {
                            lblError.Text = "Bạn chưa nhập mã chứng khoán";
                            break;
                        }
                    case 2:
                        {
                            lblError.Text = "Bạn chưa nhập tên chứng khoán";
                            break;
                        }
                    case 3:
                        {
                            lblError.Text = "Bạn chưa nhập giá trần";
                            break;
                        }
                    case 4:
                        {
                            lblError.Text = "Bạn chưa nhập giá sàn";
                            break;
                        }
                    case 5:
                        {
                            lblError.Text = "Giá trần không hợp lệ";
                            break;
                        }
                    case 6:
                        {
                            lblError.Text = "Giá sàn không hợp lệ";
                            break;
                        }
                    case 7:
                        {
                            lblError.Text = "Mã chứng khoán không hợp lệ";
                            break;
                        }
                    case 8:
                        {
                            lblError.Text = "Tên chứng khoán không hợp lệ";
                            break;
                        }
                    case 9:
                        {
                            lblError.Text = "Gía sàn phải nhỏ hơn hoặc bằng giá trần";
                            break;
                        }
                    case 10:
                        {
                            lblError.Text = "Mã chứng khoán đã tồn tại trong hệ thống";
                            break;
                        }
                    case 0:
                        {
                            lblError.Text = "";
                            QLCKDTO chungkhoan = new QLCKDTO();

                            chungkhoan.MaCK = txtMaCK.Text;
                            chungkhoan.TenCK = txtTenCK.Text;
                            chungkhoan.GiaTran = int.Parse(txtGiaTran.Text);
                            chungkhoan.GiaSan = int.Parse(txtGiaSan.Text);

                            string jsonDataAdd = JsonConvert.SerializeObject(chungkhoan);
                            if (chungkhoanBUS.ThemCK(jsonDataAdd))
                            {
                                MessageBox.Show("Thêmmã chứng khoán mới thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Đã có lỗi xảy ra, thêm chứng khoán thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

        /*
        private void ThemMoiMaCK_Load(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Red;
        }
        */
        
}
