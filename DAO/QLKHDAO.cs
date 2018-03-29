using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class QLKHDAO
    {
        /// <summary>
        /// Laays danh sachs KH
        /// </summary>
        /// <returns></returns>
        public static List<QLyKHDTO> layDSKhachHang()
        {
            try
            {
                List<QLyKHDTO> list = new List<QLyKHDTO>();

                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT * FROM KHACH_HANG";

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        QLyKHDTO khachHang = new QLyKHDTO();
                        
                        khachHang.STKLK = oracleDataReader.GetString(0);
                        khachHang.hoTenKH = oracleDataReader.GetString(1);
                        khachHang.ngaySinhKH = oracleDataReader.GetDateTime(2);
                        khachHang.soCMNNKH = oracleDataReader.GetString(3);
                        khachHang.NgayCap = oracleDataReader.GetDateTime(4);
                        khachHang.NoiCap = oracleDataReader.GetString(5);
                        khachHang.gioiTinhKH = oracleDataReader.GetString(6);
                        khachHang.diaChiKH = oracleDataReader.GetString(7);
                        khachHang.ngayMoTKKH = oracleDataReader.GetDateTime(8);
                        khachHang.SDTKH = oracleDataReader.GetString(9);
                        if (oracleDataReader.IsDBNull(10))
                        {
                            khachHang.emailKH = "";
                        }
                        else
                        {
                            khachHang.emailKH = oracleDataReader.GetString(10);
                        }
                        khachHang.HanMucVay = oracleDataReader.GetInt32(11);
                        khachHang.MaRo = oracleDataReader.GetString(12);
                        khachHang.SoTienMat = oracleDataReader.GetInt64(13);
                        khachHang.SoDuNo = oracleDataReader.GetInt64(14);

                        list.Add(khachHang);
                    }
                }

                oracleCommand.Connection.Dispose();
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy ra 1 khách hàng khi biết số TKLK
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <returns></returns>
        public static QLyKHDTO layMotKhachHang(string soTKLK)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT * FROM KHACH_HANG WHERE SO_TKLK = :soTKLK";

                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    oracleDataReader.Read();
                    QLyKHDTO khachHang = new QLyKHDTO();

                    khachHang.STKLK = oracleDataReader.GetString(0);
                    khachHang.hoTenKH = oracleDataReader.GetString(1);
                    khachHang.ngaySinhKH = oracleDataReader.GetDateTime(2);
                    khachHang.soCMNNKH = oracleDataReader.GetString(3);
                    khachHang.NgayCap = oracleDataReader.GetDateTime(4);
                    khachHang.NoiCap = oracleDataReader.GetString(5);
                    khachHang.gioiTinhKH = oracleDataReader.GetString(6);
                    khachHang.diaChiKH = oracleDataReader.GetString(7);
                    khachHang.ngayMoTKKH = oracleDataReader.GetDateTime(8);
                    khachHang.SDTKH = oracleDataReader.GetString(9);
                    if (oracleDataReader.IsDBNull(10))
                    {
                        khachHang.emailKH = "";
                    }
                    else
                    {
                        khachHang.emailKH = oracleDataReader.GetString(10);
                    }
                    khachHang.HanMucVay = oracleDataReader.GetInt32(11);
                    khachHang.MaRo = oracleDataReader.GetString(12);
                    khachHang.SoTienMat = oracleDataReader.GetInt64(13);
                    khachHang.SoDuNo = oracleDataReader.GetInt64(14);

                    oracleCommand.Connection.Dispose();
                    return khachHang;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Lấy ra một khách hàng khi biết số CMND
        /// </summary>
        /// <param name="soCMND"></param>
        /// <returns></returns>
        public static QLyKHDTO GetKhachHang(string soCMND)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT * FROM KHACH_HANG WHERE SO_CMND = :soCMND";

                oracleCommand.Parameters.Add(new OracleParameter("soCMND", soCMND));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    oracleDataReader.Read();
                    QLyKHDTO khachHang = new QLyKHDTO();

                    khachHang.STKLK = oracleDataReader.GetString(0);
                    khachHang.hoTenKH = oracleDataReader.GetString(1);
                    khachHang.ngaySinhKH = oracleDataReader.GetDateTime(2);
                    khachHang.soCMNNKH = oracleDataReader.GetString(3);
                    khachHang.NgayCap = oracleDataReader.GetDateTime(4);
                    khachHang.NoiCap = oracleDataReader.GetString(5);
                    khachHang.gioiTinhKH = oracleDataReader.GetString(6);
                    khachHang.diaChiKH = oracleDataReader.GetString(7);
                    khachHang.ngayMoTKKH = oracleDataReader.GetDateTime(8);
                    khachHang.SDTKH = oracleDataReader.GetString(9);
                    khachHang.emailKH = oracleDataReader.GetString(10);
                    khachHang.HanMucVay = oracleDataReader.GetInt32(11);
                    khachHang.MaRo = oracleDataReader.GetString(12);
                    khachHang.SoTienMat = oracleDataReader.GetInt64(13);
                    khachHang.SoDuNo = oracleDataReader.GetInt64(14);

                    oracleCommand.Connection.Dispose();
                    return khachHang;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static QLyKHDTO GetKhachHangSDT(string SDT)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT * FROM KHACH_HANG WHERE SDT = :SDT";

                oracleCommand.Parameters.Add(new OracleParameter("SDT", SDT));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    oracleDataReader.Read();
                    QLyKHDTO khachHang = new QLyKHDTO();

                    khachHang.STKLK = oracleDataReader.GetString(0);
                    khachHang.hoTenKH = oracleDataReader.GetString(1);
                    khachHang.ngaySinhKH = oracleDataReader.GetDateTime(2);
                    khachHang.soCMNNKH = oracleDataReader.GetString(3);
                    khachHang.NgayCap = oracleDataReader.GetDateTime(4);
                    khachHang.NoiCap = oracleDataReader.GetString(5);
                    khachHang.gioiTinhKH = oracleDataReader.GetString(6);
                    khachHang.diaChiKH = oracleDataReader.GetString(7);
                    khachHang.ngayMoTKKH = oracleDataReader.GetDateTime(8);
                    khachHang.SDTKH = oracleDataReader.GetString(9);
                    khachHang.emailKH = oracleDataReader.GetString(10);
                    khachHang.HanMucVay = oracleDataReader.GetInt32(11);
                    khachHang.MaRo = oracleDataReader.GetString(12);
                    khachHang.SoTienMat = oracleDataReader.GetInt64(13);
                    khachHang.SoDuNo = oracleDataReader.GetInt64(14);

                    oracleCommand.Connection.Dispose();
                    return khachHang;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        /// <summary>
        /// Lấy danh sách mã rổ
        /// </summary>
        /// <returns></returns>
        public static List<RoCK> layDSRo()
        {
            try
            {
                List<RoCK> list = new List<RoCK>();

                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT * FROM RO_CK";

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        RoCK roCK = new RoCK();

                        roCK.MaRo = oracleDataReader.GetString(0);
                        roCK.TenRo = oracleDataReader.GetString(1);

                        list.Add(roCK);
                    }
                }

                oracleCommand.Connection.Dispose();
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Thêm khách hàng
        /// </summary>
        /// <param name="khachHang"></param>
        /// <returns></returns>
        public static bool ThemKH(QLyKHDTO khachHang)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "INSERT INTO KHACH_HANG (SO_TKLK, HO_TEN, NGAY_SINH, SO_CMND, NGAY_CAP, NOI_CAP, GIOI_TINH, DIA_CHI, NGAY_MO_TK, SDT, EMAIL, HAN_MUC_VAY, MA_RO, SO_TIEN_MAT, SO_DU_NO) " +
                    "VALUES (:soTKLK, :hotenKH, :ngaysinh, :soCMND, :ngayCap, :noiCap, :gioiTinh, :diaChi, :ngayMoTK, :sdt, :email, :hanMucVay, :maRo, :soTienMat, :soDuNo)";
                oracleCommand.Parameters.Add("soTKLK", khachHang.STKLK);
                oracleCommand.Parameters.Add("hotenKH", khachHang.hoTenKH);
                oracleCommand.Parameters.Add("ngaysinh", khachHang.ngaySinhKH);
                oracleCommand.Parameters.Add("soCMND", khachHang.soCMNNKH);
                oracleCommand.Parameters.Add("ngayCap", khachHang.NgayCap);
                oracleCommand.Parameters.Add("noiCap", khachHang.NoiCap);
                oracleCommand.Parameters.Add("gioiTinh", khachHang.gioiTinhKH);
                oracleCommand.Parameters.Add("diaChi", khachHang.diaChiKH);
                oracleCommand.Parameters.Add("ngayMoTK", khachHang.ngayMoTKKH);
                oracleCommand.Parameters.Add("sdt", khachHang.SDTKH);
                oracleCommand.Parameters.Add("email", khachHang.emailKH);
                oracleCommand.Parameters.Add("hanMucVay", khachHang.HanMucVay);
                oracleCommand.Parameters.Add("maRo", khachHang.MaRo);
                oracleCommand.Parameters.Add("soTienMat", khachHang.SoTienMat);
                oracleCommand.Parameters.Add("soDuNo", khachHang.SoDuNo);

                DataProvider.ExcuteNonQuery(oracleCommand);

                // Lấy danh sách mã CK của rổ
                List<QLRoCKDTO> qLRoCKDTOs = QLRoCKDAO.timKiem(khachHang.MaRo);
                foreach (QLRoCKDTO temp in qLRoCKDTOs)
                {
                    oracleCommand.Parameters.Clear();
                    oracleCommand.CommandText = "INSERT INTO KHACHHANG_CHUNGKHOAN (SO_TKLK, MA_CK, SO_LUONG) VALUES (:sO_TKLK, :mA_CK, '0')";
                    oracleCommand.Parameters.Add("sO_TKLK", khachHang.STKLK);
                    oracleCommand.Parameters.Add("mA_CK", temp.MaCK);
                    DataProvider.ExcuteNonQuery(oracleCommand);
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Sửa khách hàng
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <param name="hoTen"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="noiCap"></param>
        /// <param name="soCMNN"></param>
        /// <param name="ngayCap"></param>
        /// <param name="email"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="hanMucVay"></param>
        /// <param name="diaChi"></param>
        /// <param name="SDT"></param>
        /// <param name="maRo"></param>
        /// <returns></returns>
        public static bool suaThongTinKH(string soTKLK, string hoTen, DateTime ngaySinh, string noiCap,string soCMNN, DateTime ngayCap, string email, string gioiTinh, int hanMucVay, string diaChi, string SDT, string maRo)
        {
            try
            {
                   OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "UPDATE KHACH_HANG SET HO_TEN = :hoTen, NGAY_SINH = :ngaySinh," +
                    " SO_CMND = :soCMNN, NGAY_CAP = :ngayCap, NOI_CAP = :noiCap," +
                    " GIOI_TINH = :gioiTinh, DIA_CHI = :diaChi, SDT = :SDT, EMAIL = :email," +
                    " HAN_MUC_VAY = :hanMucVay ,MA_RO = :maRo WHERE SO_TKLK = :soTKLK";
                oracleCommand.Parameters.Add(new OracleParameter("hoTen", hoTen));
                oracleCommand.Parameters.Add(new OracleParameter("ngaySinh", ngaySinh));
                oracleCommand.Parameters.Add(new OracleParameter("soCMNN", soCMNN));
                oracleCommand.Parameters.Add(new OracleParameter("ngayCap", ngayCap));
                oracleCommand.Parameters.Add(new OracleParameter("noiCap", noiCap));
                oracleCommand.Parameters.Add(new OracleParameter("gioiTinh", gioiTinh));
                oracleCommand.Parameters.Add(new OracleParameter("diaChi", diaChi));
                oracleCommand.Parameters.Add(new OracleParameter("SDT", SDT));
                oracleCommand.Parameters.Add(new OracleParameter("email", email));
                oracleCommand.Parameters.Add(new OracleParameter("hanMucVay", hanMucVay));
                oracleCommand.Parameters.Add(new OracleParameter("maRo", maRo));
                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));

                return DataProvider.ExcuteNonQuery(oracleCommand);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
