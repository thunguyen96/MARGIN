using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DAO
{
    public class QliSucMuaDAO
    {
        // HIển thị thông tin khách hàng theo số TKLK
        public static List<QLiSucMuaDTO> layThongTinKH(string soTKLK)
        {
            try
            {
                List<QLiSucMuaDTO> qLiSucMuas= new List<QLiSucMuaDTO>();
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT KHACH_HANG.SO_TKLK, KHACH_HANG.HO_TEN, KHACH_HANG.SO_CMND, KHACH_HANG.NGAY_SINH, KHACH_HANG.SO_TIEN_MAT, KHACH_HANG.HAN_MUC_VAY, KHACH_HANG.SO_DU_NO  FROM KHACH_HANG WHERE SO_TKLK = :soTKLK";

                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        QLiSucMuaDTO qLiSucMua = new QLiSucMuaDTO();

                        qLiSucMua.SoTKLK = oracleDataReader.GetString(0);
                        qLiSucMua.HoTen = oracleDataReader.GetString(1);
                        qLiSucMua.SoCMND = oracleDataReader.GetString(2);
                        qLiSucMua.NgaySinh = oracleDataReader.GetDateTime(3);
                        qLiSucMua.TienMat = oracleDataReader.GetInt64(4);
                        qLiSucMua.HanMucVay = oracleDataReader.GetInt64(5);
                        qLiSucMua.SoDuNo = oracleDataReader.GetInt64(6);

                        qLiSucMuas.Add(qLiSucMua);
                    }

                    oracleCommand.Connection.Dispose();
                    return qLiSucMuas;
            
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

        // Lấy danh sách mã chứng khoán
        public static List<MaCK> LayDSMaCK(string soTKLK)
        {
            try
            {
                List<MaCK> list = new List<MaCK>();

                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = oracleCommand.CommandText = "SELECT CHI_TIET_RO.MA_CK FROM KHACH_HANG,CHI_TIET_RO WHERE KHACH_HANG.MA_RO = CHI_TIET_RO.MA_RO AND KHACH_HANG.SO_TKLK = :soTKLK GROUP BY CHI_TIET_RO.MA_CK";

                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        MaCK maCK = new MaCK();

                        maCK.MaCk = oracleDataReader.GetString(0);

                        list.Add(maCK);
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
        
       // Hiển thị thông tin mã CK 
        public static List<QLiSucMuaDTO> layThongTinCK(string soTKLK)
        {
            try
            {
                List<QLiSucMuaDTO> qLiSucMuas = new List<QLiSucMuaDTO>();
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT KHACHHANG_CHUNGKHOAN.MA_CK, CHUNG_KHOAN.GIA_TRAN, CHUNG_KHOAN.GIA_SAN, KHACHHANG_CHUNGKHOAN.SO_LUONG, CHI_TIET_RO.GIA_VAY, CHI_TIET_RO.TI_LE_VAY " +
" FROM KHACH_HANG, CHUNG_KHOAN, KHACHHANG_CHUNGKHOAN, CHI_TIET_RO " +
" WHERE CHUNG_KHOAN.MA_CK = CHI_TIET_RO.MA_CK AND KHACHHANG_CHUNGKHOAN.MA_CK = CHI_TIET_RO.MA_CK AND KHACHHANG_CHUNGKHOAN.SO_TKLK = KHACH_HANG.SO_TKLK " +
" AND KHACH_HANG.MA_RO = CHI_TIET_RO.MA_RO AND KHACH_HANG.SO_TKLK = :soTKLK";

                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        QLiSucMuaDTO qLiSucMua = new QLiSucMuaDTO();

                        qLiSucMua.MaCK = oracleDataReader.GetString(0);
                        qLiSucMua.GiaTran = oracleDataReader.GetInt64(1);
                        qLiSucMua.GiaSan = oracleDataReader.GetInt64(2);
                        qLiSucMua.GiaVay = oracleDataReader.GetInt64(4);
                        qLiSucMua.TiLeVay = oracleDataReader.GetInt64(5);
                        qLiSucMua.SoLuong = oracleDataReader.GetInt64(3);
                 
                        qLiSucMuas.Add(qLiSucMua);
                    }

                    oracleCommand.Connection.Dispose();
                    return qLiSucMuas;
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
        ///  Lay so luong mua
        /// </summary>
        /// <param name="SoTKLK"></param>
        /// <param name="MaCK"></param>
        /// <returns></returns>
        public static long GetSL(string SoTKLK, string MaCK)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT SO_LUONG FROM KHACHHANG_CHUNGKHOAN WHERE SO_TKLK = :soTKLK AND MA_CK = :maCK";
                oracleCommand.Parameters.Add("soTKLK", SoTKLK);
                oracleCommand.Parameters.Add("maCK", MaCK);

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);
                if(oracleDataReader != null && oracleDataReader.HasRows)
                {
                    oracleDataReader.Read();
                    return oracleDataReader.GetInt64(0);
                }
                else
                {
                    return 0;
                }
            }catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Mua chung khoan
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <param name="maCK"></param>
        /// <param name="sl"></param>
        /// <returns></returns>
        public static bool ThemMuaCK(string soTKLK, string maCK, long sl, long gtMua, long tienMat)
        {
            try
            {
                long soDu = 0;
                if(gtMua > tienMat)
                {
                    soDu = gtMua - tienMat;
                }
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "INSERT INTO KHACHHANG_CHUNGKHOAN (SO_TKLK, MA_CK, SO_LUONG) VALUES (:sO_TKLK, :mA_CK, :sO_LUONG)";
                oracleCommand.Parameters.Add("sO_TKLK", soTKLK);
                oracleCommand.Parameters.Add("mA_CK", maCK);
                oracleCommand.Parameters.Add("sO_LUONG", sl);

                DataProvider.ExcuteNonQuery(oracleCommand);

                oracleCommand.Parameters.Clear();
                oracleCommand.CommandText = "UPDATE KHACH_HANG SET SO_DU_NO = :soDuNo WHERE SO_TKLK = :soTKLK";
                oracleCommand.Parameters.Add("soDuNo", soDu);
                oracleCommand.Parameters.Add("soTKLK", soTKLK);
                DataProvider.ExcuteNonQuery(oracleCommand);

                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
