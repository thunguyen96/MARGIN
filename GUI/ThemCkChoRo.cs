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
    public partial class ThemCkChoRo : Form
    {
        public ThemCkChoRo()
        {
            InitializeComponent();
        }

        private void txtMaRo_Leave(object sender, EventArgs e)
        {
            try
            {
                txtGiaVay.Text = "";
                txtTiLeVay.Text = "";
                QLRoCKBUS qLRoCKBUS = new QLRoCKBUS();
                //lấy thông tin từ số TKLK
                string jsonData = qLRoCKBUS.timKiem(txtMaRo.Text);
                string jsonTenRo = qLRoCKBUS.layTenRo(txtMaRo.Text);

                RoCK tenRoCK = JsonConvert.DeserializeObject<RoCK>(jsonTenRo);
                List<QLRoCKDTO> list = JsonConvert.DeserializeObject<List<QLRoCKDTO>>(jsonData);

                lblError.ForeColor = Color.Red;
                if (txtMaRo.Text == "")
                {
                    lblError.Text = "Bạn chưa nhập mã rổ";
                }
                else
                if (tenRoCK == null)
                {
                    lblError.Text = "Mã rổ không có trong hệ thống";
                }
                else 
                {
                    txtTenRo.Text = tenRoCK.TenRo;
                    lblError.Text = "";
                    
                    string jsonDataCK = qLRoCKBUS.layDSMaCK();
                    List<MaCK> listMaCK = JsonConvert.DeserializeObject<List<MaCK>>(jsonDataCK);
                    // Hiển thị lên cmb
                    cmbMaCK.Refresh();
                    cmbMaCK.DataSource = listMaCK;
                    cmbMaCK.DisplayMember = "MaCk";
                    cmbMaCK.SelectedIndex = 0;

                    if (list != null) {
                        // Xóa dữ liệu hiển thị cũ
                        gridView.Rows.Clear();
                        foreach (QLRoCKDTO temp in list)
                        {
                            gridView.Rows.Add(temp.MaCK, temp.GiaVay, temp.TiLeVay);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            if (txtGiaVay.Text == "")
            {
                lblError.Text = "Bạn chưa nhập giá vay";
            }
            else if (txtTiLeVay.Text == "")
            {
                lblError.Text = "Bạn chưa nhập tỉ lệ vay";
            }
            else if (!check.LaMotSoNguyenDuong(txtTiLeVay.Text) || long.Parse(txtTiLeVay.Text) <= 0 || long.Parse(txtTiLeVay.Text) >= 100)
            {
                lblError.Text = "Tỉ lệ vay không hợp lệ";
            }
            else if (!check.LaMotSoNguyenDuong(txtGiaVay.Text))
            {
                lblError.Text = "Giá vay không hợp lệ";
            }

            else
            {
                QLRoCKBUS qLRoCKBUS = new QLRoCKBUS();

                string jsonData = qLRoCKBUS.timKiem(txtMaRo.Text);

                List<QLRoCKDTO> list = JsonConvert.DeserializeObject<List<QLRoCKDTO>>(jsonData);
                List<String> listName = new List<string>();

                if (list != null)
                {
                    foreach (QLRoCKDTO temp in list)
                    {
                        listName.Add(temp.MaCK);
                    }
                }


                if (list == null || !listName.Contains(cmbMaCK.Text))
                {
                    QLRoCKDTO qLRoCKDTO = new QLRoCKDTO();
                    qLRoCKDTO.MaRo = txtMaRo.Text;
                    qLRoCKDTO.MaCK = cmbMaCK.Text;
                    qLRoCKDTO.GiaVay = long.Parse(txtGiaVay.Text);
                    qLRoCKDTO.TiLeVay = long.Parse(txtTiLeVay.Text);

                    string jsonDataAdd = JsonConvert.SerializeObject(qLRoCKDTO);
                    if (qLRoCKBUS.ThemCK(jsonDataAdd))
                    {
                        MessageBox.Show("Thêm mã chứng khoán mới thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                else
                {
                    lblError.Text = "Mã CK đã tồn tại trong rổ";
                }


            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThemCkChoRo_Load(object sender, EventArgs e)
        {
            gridView.ForeColor = Color.Black;
        }
    }
}
