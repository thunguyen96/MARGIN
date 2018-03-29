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
    public partial class QuanLyDSCK : Form
    {
        public QuanLyDSCK()
        {
            InitializeComponent();
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemCK_Click(object sender, EventArgs e)
        {
            ThemMoiMaCK themMaCK = new ThemMoiMaCK();
            themMaCK.ShowDialog();
        }

        // Sửa mã chứng khoán
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView.RowCount > 0 && gridView.SelectedRows.Count > 0)
                {
                    SuaMaCK suaCK = new SuaMaCK();
                    suaCK.dataGridView = gridView;
                    QLCKDTO chungKhoan = new QLCKDTO();
                    QLCKBUS chungKhoanBUS = new QLCKBUS();
                    string jsonData = chungKhoanBUS.GetmaCK(gridView.SelectedRows[0].Cells[0].Value.ToString());
                    suaCK.indexOfRow = gridView.SelectedRows[0].Index;

                    chungKhoan = JsonConvert.DeserializeObject<QLCKDTO>(jsonData);

                    suaCK.chungKhoan = chungKhoan;

                    suaCK.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa dữ liệu hiển thị cũ
                gridView.Rows.Clear();
                // Lấy DS chứng khoán
                List<QLCKDTO> list = new List<QLCKDTO>();
                QLCKDTO listmaCK = new QLCKDTO();

                QLCKBUS chungkhoanBUS = new QLCKBUS();
                string jsonData = chungkhoanBUS.layDSCK();
                string jsonCK = chungkhoanBUS.GetmaCK(txtTimKiem.Text);

                list = JsonConvert.DeserializeObject<List<QLCKDTO>>(jsonData);
                listmaCK = JsonConvert.DeserializeObject<QLCKDTO>(jsonCK);


                // Hiển thị danh sách chứng khoán lên grid view
                if (txtTimKiem.Text == "")
                {
                    foreach (QLCKDTO temp in list)
                    {
                        gridView.Rows.Add(temp.MaCK, temp.TenCK, temp.GiaTran, temp.GiaSan);
                    }
                }
                else if (listmaCK != null)
                {
                    gridView.Rows.Add(listmaCK.MaCK, listmaCK.TenCK, listmaCK.GiaTran, listmaCK.GiaSan);
                }

                else
                {
                    MessageBox.Show("Không tìm thấy mã chứng khoán nào trong hệ thống");
                }
                if (gridView.RowCount > 1)
                {
                    gridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuanLyDSCK_Load(object sender, EventArgs e)
        {
            try
            {
                // Xóa dữ liệu hiển thị cũ
                gridView.Rows.Clear();
                // Lấy DS chứng khoán
                List<QLCKDTO> list = new List<QLCKDTO>();
                QLCKDTO listmaCK = new QLCKDTO();

                QLCKBUS chungkhoanBUS = new QLCKBUS();
                string jsonData = chungkhoanBUS.layDSCK();
                //string jsonCK = chungkhoanBUS.GetmaCK(txtTimKiem.Text);

                list = JsonConvert.DeserializeObject<List<QLCKDTO>>(jsonData);
                //listmaCK = JsonConvert.DeserializeObject<QLCKDTO>(jsonCK);

                foreach (QLCKDTO temp in list)
                {
                    gridView.Rows.Add(temp.MaCK, temp.TenCK, temp.GiaTran, temp.GiaSan);
                }
               if (gridView.RowCount > 1)
                {
                    gridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
