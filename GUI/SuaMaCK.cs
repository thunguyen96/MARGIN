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
    public partial class SuaMaCK : Form
    {
        public QLCKDTO chungKhoan;
        public DataGridView dataGridView;
        public int indexOfRow;

        public SuaMaCK()
        {
            InitializeComponent();
            chungKhoan = new QLCKDTO();
        }

       

        private void SuaMaCK_Load(object sender, EventArgs e)
        {
            txtmaCK.Text = chungKhoan.MaCK;
            txtTenCK.Text = chungKhoan.TenCK;
            txtGiaTran.Text = chungKhoan.GiaTran.ToString();
            txtGiaSan.Text = chungKhoan.GiaSan.ToString();
        }

        // Sửa mã chứng khoán
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra lỗi nhập
                QLCKBUS chungKhoanBUS = new QLCKBUS();
                switch (chungKhoanBUS.KTThongTinSuaCK(txtGiaTran.Text, txtGiaSan.Text))
                {
                    case 1:
                        {
                            lblError.Text = "Bạn chưa nhập giá trần";
                            break;
                        }
                    case 2:
                        {
                            lblError.Text = "Bạn chưa nhập giá sàn";
                            break;
                        }
                    case 3:
                        {
                            lblError.Text = "Giá trần không hợp lệ";
                            break;
                        }
                    case 4:
                        {
                            lblError.Text = "Giá sàn không hợp lệ";
                            break;
                        }
                    case 5:
                        {
                            lblError.Text = "Giá trần phải lớn hơn hoặc bằng giá sàn";
                            break;
                        }
                    case 0:
                        {
                            lblError.Text = "";
                            
                            if (chungKhoanBUS.SuaCK(chungKhoan.MaCK, chungKhoan.TenCK, txtGiaTran.Text, txtGiaSan.Text))
                            {
                                
                                MessageBox.Show("Sửa  mã chứng khoán thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView.Rows[indexOfRow].Cells[2].Value = txtGiaTran.Text;
                                dataGridView.Rows[indexOfRow].Cells[3].Value = txtGiaSan.Text;
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
