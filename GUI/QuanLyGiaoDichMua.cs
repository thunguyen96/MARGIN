using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.QLSucMuaWS;
using GUI.QLCKWS;
using DTO;
using GUI.CheckWS;
using Newtonsoft.Json;

namespace GUI
{
    public partial class QuanLyGiaoDichMua : Form
    {
        List<QLiSucMuaDTO> qLiSucMuaDTOs;
        public QuanLyGiaoDichMua()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Hiển thị thông tin khách hàng
        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                ResetElement();
                QLiSucMuaBUS qLiSucMua = new QLiSucMuaBUS();
                //lấy thông tin từ số TKLK
                string jsonData = qLiSucMua.timKiem(txtSoTKLK.Text);  
                List<QLiSucMuaDTO> list = JsonConvert.DeserializeObject<List<QLiSucMuaDTO>>(jsonData);

                lblError.ForeColor = Color.Red;
                if (txtSoTKLK.Text == "")
                {
                    lblError.Text = "Bạn chưa nhập số TKLK";
                }
                else
                if (list.Count == 0)
                {
                    lblError.Text = "Số TKLK không có trong hệ thống";
                }
                else
                {
                    
                    foreach (QLiSucMuaDTO temp in list)
                    {
                        txtHoTen.Text = temp.HoTen;
                        txtsoCMND.Text = temp.SoCMND;
                        txtNgaySinh.Text = temp.NgaySinh.ToShortDateString();
                        txtTienMat.Text = temp.TienMat.ToString();
                        txtHanMucVay.Text = temp.HanMucVay.ToString();
                        txtSoDuNo.Text = temp.SoDuNo.ToString(); 

                        lblError.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        

        // Hiển thị thông tin mã chứng khoán
        private void groupBoxTTMaCK_Enter(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Red;
            // Lấy ds mã CK có trong rổ
            QLiSucMuaBUS qLiSucMua = new QLiSucMuaBUS();
            string jsonData = qLiSucMua.layThongtinCK(txtSoTKLK.Text);
            List<QLiSucMuaDTO> list = JsonConvert.DeserializeObject<List<QLiSucMuaDTO>>(jsonData);
            List<string> listMaCK = new List<string>();
            qLiSucMuaDTOs = list;
            foreach(QLiSucMuaDTO temp in list)
            {
                listMaCK.Add(temp.MaCK);
            }
            // Lấy danh sách các mã CK
            QLCKBUS qLCKBUS = new QLCKBUS();
            List<QLCKDTO> qLCKDTOs = JsonConvert.DeserializeObject<List<QLCKDTO>>(qLCKBUS.layDSCK());
            foreach(QLCKDTO temp in qLCKDTOs)
            {
                if (!listMaCK.Contains(temp.MaCK))
                {
                    QLiSucMuaDTO qLiSucMuaDTO = new QLiSucMuaDTO();
                    qLiSucMuaDTO.MaCK = temp.MaCK;
                    qLiSucMuaDTO.SoLuong = qLiSucMua.GetSL(txtSoTKLK.Text, temp.MaCK);
                    qLiSucMuaDTO.GiaTran = temp.GiaTran;
                    qLiSucMuaDTO.GiaSan = temp.GiaSan;
                    qLiSucMuaDTO.GiaVay = 0;
                    qLiSucMuaDTO.TiLeVay = 0;

                    list.Add(qLiSucMuaDTO);
                }
            }
            // Hiển thị lên cmb
            cmbMaCK.Refresh();
            cmbMaCK.DisplayMember = "MaCK";
            cmbMaCK.DataSource = list;
            cmbMaCK.SelectedIndex = 0;

            long TSDB = 0;
         
            foreach (QLiSucMuaDTO temp in list)
            {
                TSDB += temp.SoLuong * temp.GiaVay * temp.TiLeVay / 100;
            }
            txtTSDB.Text = TSDB.ToString();

            long SucMuaCB = long.Parse(txtTienMat.Text) + Math.Min(long.Parse(txtTSDB.Text), long.Parse(txtHanMucVay.Text)) - long.Parse(txtSoDuNo.Text);
            txtSMCB.Text = SucMuaCB.ToString();
        }



        private void cmbMaCK_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLiSucMuaDTO qLiSucMuaDTO = (QLiSucMuaDTO)cmbMaCK.SelectedItem;
            if(qLiSucMuaDTO != null)
            {
                txtGiaTran.Text = qLiSucMuaDTO.GiaTran.ToString();
                txtGiaSan.Text = qLiSucMuaDTO.GiaSan.ToString();
                txtGiaVay.Text = qLiSucMuaDTO.GiaVay.ToString();
                txtTiLeVay.Text = qLiSucMuaDTO.TiLeVay.ToString();
                txtSL.Text = qLiSucMuaDTO.SoLuong.ToString();
                txtGiaMua.Text = txtGiaSan.Text;
                
                if(txtGiaVay.Text == "0" && txtTiLeVay.Text == "0")
                {
                    txtSMCB.Text = txtTSDB.Text;
                    txtSMTD.Text = txtSMCB.Text;
                }
                else
                {
                    if(txtTSDB.Text != "")
                    {
                        long SucMuaCB = long.Parse(txtTienMat.Text) + Math.Min(long.Parse(txtTSDB.Text), long.Parse(txtHanMucVay.Text)) - long.Parse(txtSoDuNo.Text);
                        txtSMCB.Text = SucMuaCB.ToString();
                        double temp;
                        temp =(double.Parse(txtGiaVay.Text) * double.Parse(txtTiLeVay.Text) / 100) / double.Parse(txtGiaMua.Text);
                        double SMTD = SucMuaCB / (1 - temp);
                        long result = (long) Math.Round(SMTD);
                        txtSMTD.Text = result.ToString();
                    }
                }
            }
        }

        private void ResetElement()
        {
            txtHoTen.Text = "";
            txtsoCMND.Text = "";
            txtNgaySinh.Text = "";
            txtTienMat.Text = "";
            txtHanMucVay.Text = "";
            txtSoDuNo.Text = "";
            cmbMaCK.DataSource = null;
            txtGiaTran.Text = "";
            txtGiaSan.Text = "";
            txtGiaVay.Text = "";
            txtTiLeVay.Text = "";
            txtSL.Text = "";
        }

        private void txtGiaMua_TextChanged(object sender, EventArgs e)
        {
            TinhGTMua();
        }


        private void TinhGTMua()
        {
            Check check = new Check();
            if (txtGiaMua.Text != "" && txtSLMua.Text != "" && check.LaMotSoNguyenDuong(txtGiaMua.Text) && check.LaMotSoNguyenDuong(txtSLMua.Text))
            {
                // Tinh gia tri mua
                if (txtGiaMua.Text != "" && txtSLMua.Text != "")
                {
                    txtGTMua.Text = (long.Parse(txtGiaMua.Text) * long.Parse(txtSLMua.Text)).ToString();
                }
                else
                {
                    txtGTMua.Text = "";
                }
                
            }
            if(txtGiaMua.Text != "" && check.LaMotSoNguyenDuong(txtGiaMua.Text) && txtSMCB.Text != "")
            {
                // Tinh so luong mua max
                double smBD = double.Parse(txtSMCB.Text);
                double gm = double.Parse(txtGiaMua.Text);
                double gv = double.Parse(txtGiaVay.Text);
                double tlv = double.Parse(txtTiLeVay.Text);
                double slMax = smBD / (gm - gv * tlv);
                long result = (long) Math.Round(slMax);
                txtSLMuaMax.Text = result.ToString();
            }
           
        }

        private void txtSLMua_TextChanged(object sender, EventArgs e)
        {
            Check check = new Check();
            if (txtGiaMua.Text != "" && txtSLMua.Text != "" && check.LaMotSoNguyenDuong(txtGiaMua.Text) && check.LaMotSoNguyenDuong(txtSLMua.Text))
            {
                // Tinh gia tri mua
                if (txtGiaMua.Text != "" && txtSLMua.Text != "")
                {
                    txtGTMua.Text = (long.Parse(txtGiaMua.Text) * long.Parse(txtSLMua.Text)).ToString();
                }
                else
                {
                    txtGTMua.Text = "";
                }
            }
        }

        private void txtGTMua_TextChanged(object sender, EventArgs e)
        {
            if(txtGTMua.Text != "")
            {
                long SucMuaCB = long.Parse(txtTienMat.Text) + Math.Min(long.Parse(txtTSDB.Text), long.Parse(txtHanMucVay.Text)) - long.Parse(txtSoDuNo.Text) - long.Parse(txtGTMua.Text);
                txtSMCB.Text = SucMuaCB.ToString();
            }
            else
            {
                long SucMuaCB = long.Parse(txtTienMat.Text) + Math.Min(long.Parse(txtTSDB.Text), long.Parse(txtHanMucVay.Text)) - long.Parse(txtSoDuNo.Text);
                txtSMCB.Text = SucMuaCB.ToString();
            }
        }

        private void txtSMTD_TextChanged(object sender, EventArgs e)
        {
            long smtd = long.Parse(txtSMTD.Text);
            long gm = long.Parse(txtGiaMua.Text);
            long sltd = smtd / gm;
            txtSLMuaMax.Text = sltd.ToString();
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            if(txtGiaMua.Text == "")
            {
                lblError.Text = "Bạn chưa nhập giá mua";
            }
            else
            {
                if (txtSLMua.Text == "")
                {
                    lblError.Text = "Bạn chưa nhập số lượng mua";
                }
                else
                {
                    Check check = new Check();
                    if (!check.LaMotSoNguyenDuong(txtGiaMua.Text))
                    {
                        lblError.Text = "Giá mua không hợp lệ";
                    }
                    else
                    {
                        if (!check.LaMotSoNguyenDuong(txtSLMua.Text) || long.Parse(txtSLMua.Text) > long.Parse(txtSLMuaMax.Text))
                        {
                            lblError.Text = "Số lượng mua không hợp lệ";
                        }
                        else
                        {
                            if (long.Parse(txtGiaMua.Text) < long.Parse(txtGiaSan.Text) || long.Parse(txtGiaMua.Text) > long.Parse(txtGiaTran.Text))
                            {
                                lblError.Text = "Giá mua không hợp lệ";
                            }
                            else
                            {
                                long gtMua = long.Parse(txtGiaMua.Text) * long.Parse(txtSLMua.Text);
                                QLiSucMuaBUS qLiSucMuaBUS = new QLiSucMuaBUS();
                                if(qLiSucMuaBUS.ThemMuaCK(txtSoTKLK.Text, cmbMaCK.Text, long.Parse(txtSLMua.Text), long.Parse(txtSL.Text), long.Parse(txtSoDuNo.Text), long.Parse(txtGiaMua.Text), long.Parse(txtTienMat.Text)))
                                {
                                    MessageBox.Show("Mua chứng khoán thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                                    object o = new object();
                                    EventArgs eventArgs = new EventArgs();
                                    textBox1_Leave(o, eventArgs);
                                    groupBoxTTMaCK_Enter(o, eventArgs);
                                    cmbMaCK.SelectedIndex = 0;
                                }
                                else
                                {
                                    MessageBox.Show("Đã có lỗi sảy ra, Mua chứng khoán thất bại");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CapNhatThongTin()
        {
            try
            {
                ResetElement();
                QLiSucMuaBUS qLiSucMua = new QLiSucMuaBUS();
                //lấy thông tin từ số TKLK
                string jsonData = qLiSucMua.timKiem(txtSoTKLK.Text);
                List<QLiSucMuaDTO> list = JsonConvert.DeserializeObject<List<QLiSucMuaDTO>>(jsonData);

                lblError.ForeColor = Color.Red;
                if (txtSoTKLK.Text == "")
                {
                    lblError.Text = "Bạn chưa nhập số TKLK";
                }
                else
                if (list.Count == 0)
                {
                    lblError.Text = "Số TKLK không có trong hệ thống";
                }
                else
                {
                    foreach (QLiSucMuaDTO temp in list)
                    {
                        txtHoTen.Text = temp.HoTen;
                        txtsoCMND.Text = temp.SoCMND;
                        txtNgaySinh.Text = temp.NgaySinh.ToShortDateString();
                        txtTienMat.Text = temp.TienMat.ToString();
                        txtHanMucVay.Text = temp.HanMucVay.ToString();
                        txtSoDuNo.Text = temp.SoDuNo.ToString();
                        lblError.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblError.ForeColor = Color.Red;
            // Lấy ds mã CK có trong rổ
            QLiSucMuaBUS qLiSucMua2 = new QLiSucMuaBUS();
            string jsonData2 = qLiSucMua2.layThongtinCK(txtSoTKLK.Text);
            List<QLiSucMuaDTO> list2 = JsonConvert.DeserializeObject<List<QLiSucMuaDTO>>(jsonData2);
            List<string> listMaCK = new List<string>();
            qLiSucMuaDTOs = list2;
            foreach (QLiSucMuaDTO temp in list2)
            {
                listMaCK.Add(temp.MaCK);
            }
            // Lấy danh sách các mã CK
            QLCKBUS qLCKBUS = new QLCKBUS();
            List<QLCKDTO> qLCKDTOs = JsonConvert.DeserializeObject<List<QLCKDTO>>(qLCKBUS.layDSCK());
            foreach (QLCKDTO temp in qLCKDTOs)
            {
                if (!listMaCK.Contains(temp.MaCK))
                {
                    QLiSucMuaDTO qLiSucMuaDTO = new QLiSucMuaDTO();
                    qLiSucMuaDTO.MaCK = temp.MaCK;
                    qLiSucMuaDTO.SoLuong = qLiSucMua2.GetSL(txtSoTKLK.Text, temp.MaCK);
                    qLiSucMuaDTO.GiaTran = temp.GiaTran;
                    qLiSucMuaDTO.GiaSan = temp.GiaSan;
                    qLiSucMuaDTO.GiaVay = 0;
                    qLiSucMuaDTO.TiLeVay = 0;

                    list2.Add(qLiSucMuaDTO);
                }
            }
            // Hiển thị lên cmb
            cmbMaCK.Refresh();
            cmbMaCK.DisplayMember = "MaCK";
            cmbMaCK.DataSource = list2;
            cmbMaCK.SelectedIndex = 0;

            long TSDB = 0;

            foreach (QLiSucMuaDTO temp in list2)
            {
                TSDB += temp.SoLuong * temp.GiaVay * temp.TiLeVay / 100;
            }
            txtTSDB.Text = TSDB.ToString();

            long SucMuaCB = long.Parse(txtTienMat.Text) + Math.Min(long.Parse(txtTSDB.Text), long.Parse(txtHanMucVay.Text)) - long.Parse(txtSoDuNo.Text);
            txtSMCB.Text = SucMuaCB.ToString();
        }
    }
}
