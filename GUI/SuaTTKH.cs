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
using GUI.QLyKHWS;
using Newtonsoft.Json;

namespace GUI
{
    public partial class SuaTTKH : Form
    {
        public QLyKHDTO khachHang;
        public DataGridView dataGridView;

        public SuaTTKH()
        {
            InitializeComponent();
            khachHang = new QLyKHDTO();
        }

        private void SuaTTKH_Load(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Red;

            txtSoTKLK.Text = khachHang.STKLK;
            txtHoTen.Text = khachHang.hoTenKH;
            dateNgayCap.Value = khachHang.NgayCap;
            txtDiaChi.Text = khachHang.diaChiKH;
            txtSDT.Text = khachHang.SDTKH;
            txtNgayMoTK.Text = khachHang.ngayMoTKKH.ToString();
            datengaySinh.Value = khachHang.ngaySinhKH;
            txtSoCMND.Text = khachHang.soCMNNKH;
            txtNoiCap.Text = khachHang.NoiCap;
            txtEmail.Text = khachHang.emailKH;
            txtHanMucVay.Text = khachHang.HanMucVay.ToString();
            if (khachHang.gioiTinhKH == "Nữ")
            {
                cmbGioiTinh.SelectedIndex = 1;
            }
            if (khachHang.gioiTinhKH == "Nam")
            {
                cmbGioiTinh.SelectedIndex = 0;
            }

            // Lấy danh sách mã rổ
            QLyKHBUS qLyKHBUS = new QLyKHBUS();
            RoCK roCK = new RoCK();
            string jsonData = qLyKHBUS.layDSRo();
            List<RoCK> list = JsonConvert.DeserializeObject<List<RoCK>>(jsonData);
            // Hiển thị danh sách Mã rổ lên combobox
            cmbMaRo.Refresh();
            cmbMaRo.DataSource = list;
            cmbMaRo.DisplayMember = "MaRo";
            int i = 0;
            foreach (var temp in list)
            {
                if (temp.MaRo == khachHang.MaRo)
                {
                    cmbMaRo.SelectedIndex = i;
                }
                else
                {
                    i++;
                }
            }
        }

        private void btnMoTK_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra lỗi nhập
                QLyKHBUS khachHangBUS = new QLyKHBUS();
                switch (khachHangBUS.KTThongTinSuaKH(txtSoTKLK.Text, DateTime.Parse(txtNgayMoTK.Text), txtEmail.Text, txtHoTen.Text, datengaySinh.Value, txtNoiCap.Text, txtSoCMND.Text, txtDiaChi.Text, txtHanMucVay.Text, txtSDT.Text))
                {
                    
                    case 1:
                        {
                            lblError.Text = "Bạn chưa nhập họ tên";
                            break;
                        }
                    case 2:
                        {
                            lblError.Text = "Bạn chưa nhập nơi cấp";
                            break;
                        }
                    case 3:
                        {
                            lblError.Text = "Bạn chưa nhập số CMND";
                            break;
                        }
                    case 4:
                        {
                            lblError.Text = "Bạn chưa nhập địa chỉ";
                            break;
                        }
                    case 5:
                        {
                            lblError.Text = "Bạn chưa nhập hạn mức vay";
                            break;
                        }
                    case 6:
                        {
                            lblError.Text = "Bạn chưa nhập số điện thoại";
                            break;
                        }
                    case 7:
                        {
                            lblError.Text = "Họ tên không hợp lệ";
                            break;
                        }
                    case 8:
                        {
                            lblError.Text = "Hạn mức vay không hợp lệ";
                            break;
                        }
                    case 9:
                        {
                            lblError.Text = "Số CMND không hợp lệ";
                            break;
                        }
                    case 10:
                        {
                            lblError.Text = "Số điện thoại không hợp lệ";
                            break;
                        }
                    case 12:
                        {
                            lblError.Text = "STLLK không hợp lệ";
                            break;
                        }
                    case 13:
                        {
                            lblError.Text = "Số CMND đã tồn tại trong hệ thống";
                            break;
                        }
                    case 14:
                        {
                            lblError.Text = "Địa chỉ không hợp lệ";
                            break;
                        }
                    case 15:
                        {
                            lblError.Text = "Nơi cấp không hợp lệ";
                            break;
                        }
                    case 16:
                        {
                            lblError.Text = "Nơi cấp không hợp lê";
                            break;
                        }
                    case 17:
                        {
                            lblError.Text = "Số điện thoại đã tồn tại trong hệ thống";
                            break;
                        }
                    case 18:
                        {
                            lblError.Text = "Khách hàng chưa đủ 18 tuổi";
                            break;
                        }
                    case 0:
                        {
                            lblError.Text = "";
                            RoCK ro = (RoCK)cmbMaRo.SelectedItem;
                            string email;
                            if (txtEmail.Text != "")
                            {
                                email = txtEmail.Text;
                            }
                            else
                            {
                                email = " ";
                            }
                            if (khachHangBUS.suaThongTinKH(txtSoTKLK.Text, txtHoTen.Text, datengaySinh.Value, txtNoiCap.Text, txtSoCMND.Text,
                                dateNgayCap.Value, txtEmail.Text, cmbGioiTinh.SelectedItem.ToString(), int.Parse(txtHanMucVay.Text), txtDiaChi.Text, txtSDT.Text, ro.MaRo))
                            {
                                // Hiển thị lại dữ liệu lên grid view
                                /*foreach (DataGridViewRow temp in dataGridView.Rows)
                                {
                                    if (temp.Cells[0].Value.ToString() == txtSoTKLK.Text)
                                    {
                                        temp.Cells[1].Value = txtHoTen.Text;
                                        temp.Cells[2].Value = datengaySinh.Value;
                                        temp.Cells[3].Value = txtSoCMND.Text;
                                        temp.Cells[4].Value = dateNgayCap.Value;
                                        temp.Cells[5].Value = txtNoiCap.Text;
                                        temp.Cells[6].Value = cmbGioiTinh.SelectedItem.ToString();
                                        temp.Cells[7].Value = txtDiaChi.Text;
                                        temp.Cells[8].Value = khachHang.ngayMoTKKH;
                                        temp.Cells[9].Value = txtSDT.Text;
                                    }
                                }*/
                                MessageBox.Show("Sửa khách hàng thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Đã có lỗi xảy ra, sửa khách hàng thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
