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
    public partial class MoTaiKhoan : Form
    {
        public MoTaiKhoan()
        {
            InitializeComponent();
        }
        private void MoTaiKhoan_Load(object sender, EventArgs e)
        {
            dateNgayMoTK.Text = DateTime.Now.Date.ToShortDateString();
            lblError.ForeColor = Color.Red;
            // Lấy ds mã rổ
            QLyKHBUS khachHangBUS = new QLyKHBUS();
            string jsonData = khachHangBUS.layDSRo();
            List<RoCK> list = JsonConvert.DeserializeObject<List<RoCK>>(jsonData);
            // Hiển thị lên cmb
            cmbMaRo.Refresh();
            cmbMaRo.DataSource = list;
            cmbMaRo.DisplayMember = "MaRo";
            //cmbMaRo.SelectedIndex = 0;
            //cmbGioiTinh.SelectedIndex = 0;
        }

        private void btnMoTK_Click(object sender, EventArgs e)
        {
            try
            {
                QLyKHBUS khachHangBUS = new QLyKHBUS();
                switch (khachHangBUS.KTThongTinThemKH(txtSoTKLK.Text, dateNgayMoTK.Value, txtHoTen.Text, txtEmail.Text, datengaySinh.Value, txtNoiCap.Text, txtSoCMND.Text, txtDiaChi.Text, txtHanMucVay.Text, txtSDT.Text))
                {
                    case 1:
                        {
                            lblError.Text = "Bạn chưa nhập số TKLK";
                            break;
                        }
                    case 2:
                        {
                            lblError.Text = "Bạn chưa nhập họ tên";
                            break;
                        }
                    case 3:
                        {
                            lblError.Text = "Bạn chưa nhập nơi cấp";
                            break;
                        }
                    case 4:
                        {
                            lblError.Text = "Bạn chưa nhập số CMND";
                            break;
                        }
                    case 5:
                        {
                            lblError.Text = "Bạn chưa nhập địa chỉ";
                            break;
                        }
                    case 6:
                        {
                            lblError.Text = "Bạn chưa nhập email";
                            break;
                        }
                    case 7:
                        {
                            lblError.Text = "Bạn chưa nhập số điện thoại";
                            break;
                        }
                    case 8:
                        {
                            lblError.Text = "Khách hàng chưa đủ 18 tuổi";
                            break;
                        }
                    case 9:
                        {
                            lblError.Text = "Họ tên không hợp lệ";
                            break;
                        }
                    case 10:
                        {
                            lblError.Text = "Hạn mức vay không hợp lệ";
                            break;
                        }
                    case 11:
                        {
                            lblError.Text = "Số CMND không hợp lệ";
                            break;
                        }
                    case 12:
                        {
                            lblError.Text = "Số điện thoại không hợp lệ";
                            break;
                        }
                    case 13:
                        {
                            lblError.Text = "Số TKLK đã tồn tại";
                            break;
                        }
                    case 14:
                        {
                            lblError.Text = "Số TKLK không hợp lệ";
                            break;
                        }
                    case 15:
                        {
                            lblError.Text = "Số CMND đã tồn tại";
                            break;
                        }
                    case 16:
                        {
                            lblError.Text = "Địa chỉ không hợp lệ";
                            break;
                        }
                    case 17:
                        {
                            lblError.Text = "Nơi cấp không hợp lệ";
                            break;
                        }
                    case 18:
                        {
                            lblError.Text = "Email không hợp lệ";
                            break;
                        }
                    case 0:
                        {
                            lblError.Text = "";
                            QLyKHDTO khachHang = new QLyKHDTO();
                            RoCK ro = (RoCK)cmbMaRo.SelectedItem;

                            khachHang.STKLK = txtSoTKLK.Text;
                            khachHang.hoTenKH = txtHoTen.Text;
                            khachHang.ngaySinhKH = datengaySinh.Value;
                            khachHang.ngayMoTKKH = DateTime.Now;
                            khachHang.HanMucVay = int.Parse(txtHanMucVay.Text);
                            khachHang.soCMNNKH = txtSoCMND.Text;
                                if (txtEmail.Text != "")
                                {
                                    khachHang.emailKH = txtEmail.Text;
                                }
                                else
                                {
                                    khachHang.emailKH = " ";
                                }
                            khachHang.NgayCap = dateNgayCap.Value;
                            khachHang.NoiCap = txtNoiCap.Text;
                            khachHang.gioiTinhKH = cmbGioiTinh.SelectedItem.ToString();
                            khachHang.MaRo = ro.MaRo;
                            khachHang.diaChiKH = txtDiaChi.Text;
                            khachHang.SDTKH = txtSDT.Text;
                            khachHang.SoTienMat = 0;
                            khachHang.SoDuNo = 0;

                            string jsonDataAdd = JsonConvert.SerializeObject(khachHang);
                            if (khachHangBUS.ThemKH(jsonDataAdd))
                            {
                                MessageBox.Show("Thêm khách hàng mới thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Đã có lỗi xảy ra, thêm khách hàng mới thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
