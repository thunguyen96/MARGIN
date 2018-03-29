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
    public partial class QuanLyKH : Form
    {
        public QuanLyKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa dữ liệu hiển thị cũ
                gridTabKH.Rows.Clear();
                // Lấy DS khách hàng
                List<QLyKHDTO> list = new List<QLyKHDTO>();
                QLyKHDTO listCMND = new QLyKHDTO();
                QLyKHDTO listTKLK = new QLyKHDTO();

                QLyKHBUS khachHangBUS = new QLyKHBUS();
                string jsonData = khachHangBUS.layDSKhachHang();
                string jsonCMND = khachHangBUS.GetKH(txtTimKiem.Text);
                string jsonTKLK = khachHangBUS.layMotKhachHang(txtTimKiem.Text);

                list = JsonConvert.DeserializeObject<List<QLyKHDTO>>(jsonData);
                listCMND = JsonConvert.DeserializeObject<QLyKHDTO>(jsonCMND);
                listTKLK = JsonConvert.DeserializeObject<QLyKHDTO>(jsonTKLK);

                // Hiển thị danh sách khách hàng lên grid view
                if(txtTimKiem.Text == "")
                {
                    foreach (QLyKHDTO temp in list)
                    {
                        gridTabKH.Rows.Add(temp.STKLK, temp.hoTenKH, temp.ngaySinhKH,
                        temp.soCMNNKH, temp.NgayCap, temp.NoiCap,
                        temp.gioiTinhKH, temp.diaChiKH, temp.ngayMoTKKH, temp.SDTKH, temp.emailKH, temp.HanMucVay,
                        temp.MaRo, temp.SoTienMat, temp.SoDuNo);

                    }
                }
                else if(listCMND != null)
                {
                    gridTabKH.Rows.Add(listCMND.STKLK, listCMND.hoTenKH, listCMND.ngaySinhKH, 
                        listCMND.soCMNNKH, listCMND.NgayCap,listCMND.NoiCap,
                        listCMND.gioiTinhKH,listCMND.diaChiKH,listCMND.ngayMoTKKH,listCMND.SDTKH, listCMND.emailKH, listCMND.HanMucVay,
                        listCMND.MaRo, listCMND.SoTienMat, listCMND.SoDuNo);
                }
                else if(listTKLK != null)
                {
                    gridTabKH.Rows.Add(listTKLK.STKLK, listTKLK.hoTenKH, listTKLK.ngaySinhKH,
                        listTKLK.soCMNNKH, listTKLK.NgayCap, listTKLK.NoiCap,
                        listTKLK.gioiTinhKH, listTKLK.diaChiKH, listTKLK.ngayMoTKKH, listTKLK.SDTKH, listTKLK.emailKH, listTKLK.HanMucVay,
                        listTKLK.MaRo, listTKLK.SoTienMat, listTKLK.SoDuNo);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy KH nào trong hệ thống");
                }
                if (gridTabKH.RowCount > 1)
                {
                    gridTabKH.Rows[0].Selected = true;
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

        private void btnMoTK_Click(object sender, EventArgs e)
        {
            MoTaiKhoan moTaiKhoan = new MoTaiKhoan();
            moTaiKhoan.ShowDialog();
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridTabKH.RowCount > 0 && gridTabKH.SelectedRows.Count > 0)
                {
                    SuaTTKH suaKH = new SuaTTKH();
                    suaKH.dataGridView = gridTabKH;
                    QLyKHDTO khachHang = new QLyKHDTO();
                    QLyKHBUS khachHangBUS = new QLyKHBUS();
                    string jsonData = khachHangBUS.layMotKhachHang(gridTabKH.SelectedRows[0].Cells[0].Value.ToString());

                    khachHang = JsonConvert.DeserializeObject<QLyKHDTO>(jsonData);

                    suaKH.khachHang = khachHang;

                    suaKH.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thao tác lỗi. Bạn chưa chọn khách hàng nào", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridTabKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyKH_Load(object sender, EventArgs e)
        {
            try
            {
                // Xóa dữ liệu hiển thị cũ
                gridTabKH.Rows.Clear();
                // Lấy DS khách hàng
                List<QLyKHDTO> list = new List<QLyKHDTO>();

                QLyKHBUS khachHangBUS = new QLyKHBUS();
                string jsonData = khachHangBUS.layDSKhachHang();
             
                list = JsonConvert.DeserializeObject<List<QLyKHDTO>>(jsonData);
                foreach (QLyKHDTO temp in list)
                {
                    gridTabKH.Rows.Add(temp.STKLK, temp.hoTenKH, temp.ngaySinhKH,
                    temp.soCMNNKH, temp.NgayCap, temp.NoiCap,
                    temp.gioiTinhKH, temp.diaChiKH, temp.ngayMoTKKH, temp.SDTKH, temp.emailKH, temp.HanMucVay,
                    temp.MaRo, temp.SoTienMat, temp.SoDuNo);
                }


                if (gridTabKH.RowCount > 1)
                {
                    gridTabKH.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
