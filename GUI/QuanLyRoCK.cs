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
    public partial class QuanLyRoCK : Form
    {
        public QuanLyRoCK()
        {
            InitializeComponent();
        }

        private void txtMaRo_Leave(object sender, EventArgs e)
        {
            try
            {
                if(txtMaRo.Text != "")
                {
                    lblError.Text = "";
                    QLRoCKBUS qLRoCKBUS = new QLRoCKBUS();
                    //lấy thông tin từ số TKLK
                    string jsonData = qLRoCKBUS.timKiem(txtMaRo.Text);
                    List<QLRoCKDTO> list = JsonConvert.DeserializeObject<List<QLRoCKDTO>>(jsonData);

                    lblError.ForeColor = Color.Red;
                    if (list != null)
                    {
                        gridView.Rows.Clear();
                        foreach (QLRoCKDTO temp in list)
                        {
                            txtTenRo.Text = temp.TenRo;

                            lblError.Text = "";

                            // Xóa dữ liệu hiển thị cũ
                            gridView.Rows.Add(temp.MaCK, temp.TenCK, temp.GiaVay, temp.TiLeVay);
                        }
                    }
                    else
                    {
                        lblError.Text = "Mã rổ không có trong hệ thống";
                        gridView.Rows.Clear();
                    }
                }
                else
                {
                    gridView.Rows.Clear();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemRoCK themRo = new ThemRoCK();
            themRo.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView.RowCount > 0 && gridView.SelectedRows.Count > 0)
                {
                    SuaRoCK suaRo = new SuaRoCK();
                    suaRo.dataGridView = gridView;
                    QLRoCKDTO roCK = new QLRoCKDTO();

                    roCK.MaRo = txtMaRo.Text;
                    roCK.MaCK = gridView.SelectedRows[0].Cells[0].Value.ToString();
                    roCK.TenRo = txtTenRo.Text;
                    roCK.TenCK = gridView.SelectedRows[0].Cells[1].Value.ToString();
                    roCK.GiaVay = long.Parse(gridView.SelectedRows[0].Cells[2].Value.ToString());
                    roCK.TiLeVay = long.Parse(gridView.SelectedRows[0].Cells[3].Value.ToString());

                    suaRo.roCK = roCK;

                    suaRo.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ThemCkChoRo them = new ThemCkChoRo();
            them.ShowDialog();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridView.RowCount > 0 && gridView.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa mã chứng khoán " + gridView.SelectedRows[0].Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    QLRoCKBUS qLRoCKBUS = new QLRoCKBUS();
                    if(qLRoCKBUS.XoaMaCK(txtMaRo.Text, gridView.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Xóa mã CK thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xóa mã CK thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thao tác lỗi. Bạn chưa chọn mã chứng khoán nào", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
