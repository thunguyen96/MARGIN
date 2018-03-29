using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.QLLuuKiWS;
using GUI.QLyKHWS;
using DTO;
using Newtonsoft.Json;

namespace GUI
{
    public partial class QuanLyLuuKy : Form
    {
        public QuanLyLuuKy()
        {
            InitializeComponent();
        }

        private void txtSoTKLK_Enter(object sender, EventArgs e)
        {
            

        }

        private void txtSoTKLK_Leave(object sender, EventArgs e)
        {
            try
            {
                QLLuukiBUS qLTienMatBUS = new QLLuukiBUS();
                //lấy thông tin từ số TKLK
                string jsonData = qLTienMatBUS.timKiem(txtSoTKLK.Text);
                List<QLLuuKiDTO> list = JsonConvert.DeserializeObject<List<QLLuuKiDTO>>(jsonData);

                lblError.ForeColor = Color.Red;
                if (txtSoTKLK.Text == "")
                {
                    lblError.Text = "Dòng màu đỏ là thông tin bắt buộc nhập";
                }
                else
                if (list == null)
                {
                }
                else
                {
                    QLyKHBUS qLyKHBUS = new QLyKHBUS();
                    QLyKHDTO qLyKHDTO = JsonConvert.DeserializeObject<QLyKHDTO>(qLyKHBUS.layMotKhachHang(txtSoTKLK.Text));
                    if(qLyKHDTO != null)
                    {
                        txthoTen.Text = qLyKHDTO.hoTenKH;
                        txtsoCMND.Text = qLyKHDTO.soCMNNKH;
                        txtSDT.Text = qLyKHDTO.SDTKH;
                    }
                    else
                    {
                        lblError.Text = "Số TKLK không có trong hệ thống";
                        txthoTen.Text = "";
                        txtsoCMND.Text = "";
                        txtSDT.Text = "";
                    }

                    gridView.Rows.Clear();
                    foreach (QLLuuKiDTO temp in list)
                    {
                        txthoTen.Text = temp.HoTen;
                        txtSDT.Text = temp.SoDT;
                        txtsoCMND.Text = temp.SoCMND;

                        lblError.Text = "";

                        long tsdb = temp.SoLuong * temp.GiaVay * temp.TiLeVay/100;
                        gridView.Rows.Add(temp.MaCK, temp.TenCK, temp.SoLuong, temp.GiaVay, temp.TiLeVay, tsdb);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //try
            //{
            //    QLLuukiBUS qLLuuki = new QLLuukiBUS();
            //    string jsonData = qLLuuki.timKiem(txtSoTKLK.Text);
            //    List<QLLuuKiDTO> list = JsonConvert.DeserializeObject<List<QLLuuKiDTO>>(jsonData);
            //    switch (qLLuuki.KtraNhapSoTKLK(txtSoTKLK.Text))
            //    {
            //        case 1:
            //            {
            //                lblError.Text = "Bạn chưa nhập số TKLK";
            //                break;
            //            }
            //        case 2:
            //            {
            //                lblError.Text = "Số tài khoản lưu kí không tồn tại trong hệ thống";
            //                break;
            //            }
            //        case 0:
            //            {
            //                gridView.Rows.Clear();
            //                foreach (QLLuuKiDTO temp in list)
            //                {
            //                    txthoTen.Text = temp.HoTen;
            //                    txtSDT.Text = temp.SoDT;
            //                    txtsoCMND.Text = temp.SoCMND;

            //                    lblError.Text = "";

            //                    long tsdb = temp.SoLuong * temp.GiaVay * temp.TiLeVay;
            //                    gridView.Rows.Add(temp.MaCK, temp.TenCK, temp.SoLuong, temp.GiaVay, temp.TiLeVay, tsdb);
            //                }
            //                break;
            //            }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView.RowCount > 0 && gridView.SelectedRows.Count > 0)
                {
                    NopLuuKy nopLuuKy = new NopLuuKy();
                    nopLuuKy.dataGridView = gridView;
                    QLLuuKiDTO qLLuuKi = new QLLuuKiDTO();

                    qLLuuKi.MaCK = gridView.SelectedRows[0].Cells[0].Value.ToString();
                    qLLuuKi.SoTKLK = txtSoTKLK.Text;
                    qLLuuKi.HoTen = txthoTen.Text;
                    qLLuuKi.SoCMND = txtsoCMND.Text;
                    qLLuuKi.SoDT = txtSDT.Text;
                    qLLuuKi.TenCK = gridView.SelectedRows[0].Cells[1].Value.ToString();
                    qLLuuKi.SoLuong = long.Parse(gridView.SelectedRows[0].Cells[2].Value.ToString());
                    qLLuuKi.GiaVay = int.Parse(gridView.SelectedRows[0].Cells[3].Value.ToString());
                    qLLuuKi.TiLeVay = int.Parse(gridView.SelectedRows[0].Cells[4].Value.ToString());

                    nopLuuKy.qLLuuKi = qLLuuKi;

                    nopLuuKy.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thao tác lỗi. Bạn chưa chọn mã chứng khoán nào", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRut_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView.RowCount > 0 && gridView.SelectedRows.Count > 0)
                {
                    RutLuuKy rutLuuKy = new RutLuuKy();
                    rutLuuKy.dataGridView = gridView;
                    QLLuuKiDTO qLLuuKi = new QLLuuKiDTO();

                    qLLuuKi.MaCK = gridView.SelectedRows[0].Cells[0].Value.ToString();
                    qLLuuKi.SoTKLK = txtSoTKLK.Text;
                    qLLuuKi.HoTen = txthoTen.Text;
                    qLLuuKi.SoCMND = txtsoCMND.Text;
                    qLLuuKi.SoDT = txtSDT.Text;
                    qLLuuKi.TenCK = gridView.SelectedRows[0].Cells[1].Value.ToString();
                    qLLuuKi.SoLuong = long.Parse(gridView.SelectedRows[0].Cells[2].Value.ToString());
                    qLLuuKi.GiaVay = int.Parse(gridView.SelectedRows[0].Cells[3].Value.ToString());
                    qLLuuKi.TiLeVay = int.Parse(gridView.SelectedRows[0].Cells[4].Value.ToString());

                    rutLuuKy.qLLuuKi = qLLuuKi;

                    rutLuuKy.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thao tác lỗi. Bạn chưa chọn mã chứng khoán nào", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuanLyLuuKy_Load(object sender, EventArgs e)
        {

        }
    }
}
