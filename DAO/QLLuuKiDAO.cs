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
    public class QLLuuKiDAO
    {
        public static List<QLLuuKiDTO> timKiem(string soTKLK)
        {
            try
            {
                List<QLLuuKiDTO> qLLuuKiDTOs = new List<QLLuuKiDTO>();
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT KHACH_HANG.SO_TKLK, KHACH_HANG.HO_TEN, KHACH_HANG.SO_CMND, KHACH_HANG.SDT, KHACHHANG_CHUNGKHOAN.MA_CK," +
                    "CHUNG_KHOAN.TEN_CK, KHACHHANG_CHUNGKHOAN.SO_LUONG, CHI_TIET_RO.GIA_VAY, CHI_TIET_RO.TI_LE_VAY FROM KHACH_HANG, CHUNG_KHOAN, KHACHHANG_CHUNGKHOAN, CHI_TIET_RO " +
                    "WHERE CHUNG_KHOAN.MA_CK = CHI_TIET_RO.MA_CK AND KHACHHANG_CHUNGKHOAN.MA_CK = CHI_TIET_RO.MA_CK AND KHACHHANG_CHUNGKHOAN.SO_TKLK = KHACH_HANG.SO_TKLK AND " +
                    "KHACH_HANG.MA_RO = CHI_TIET_RO.MA_RO AND KHACH_HANG.SO_TKLK = :soTKLK";

                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        QLLuuKiDTO qLLuuki = new QLLuuKiDTO();

                        qLLuuki.SoTKLK = oracleDataReader.GetString(0);
                        qLLuuki.HoTen = oracleDataReader.GetString(1);
                        qLLuuki.SoCMND = oracleDataReader.GetString(2);
                        qLLuuki.SoDT = oracleDataReader.GetString(3);
                        qLLuuki.MaCK = oracleDataReader.GetString(4);
                        qLLuuki.TenCK = oracleDataReader.GetString(5);
                        qLLuuki.SoLuong = oracleDataReader.GetInt32(6);
                        qLLuuki.GiaVay = oracleDataReader.GetInt32(7);
                        qLLuuki.TiLeVay = oracleDataReader.GetInt32(8);
                        

                        qLLuuKiDTOs.Add(qLLuuki);
                    }
                }
                oracleCommand.Connection.Dispose();
                return qLLuuKiDTOs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public static bool nopLuuKi(string soTKLK, string maCK, long soLuongCK, long soLuongNop)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                long CK = soLuongCK + soLuongNop;
                oracleCommand.CommandText = "UPDATE KHACHHANG_CHUNGKHOAN SET SO_LUONG = :CK WHERE SO_TKLK = :soTKLK AND MA_CK = :maCK";
                oracleCommand.Parameters.Add(new OracleParameter("CK", CK));
                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));
                oracleCommand.Parameters.Add("maCK", maCK);

                return DataProvider.ExcuteNonQuery(oracleCommand);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool rutLuuKi(string soTKLK, string maCK, long soLuongCK, long soLuongRut)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                long CK = soLuongCK - soLuongRut;
                oracleCommand.CommandText = "UPDATE KHACHHANG_CHUNGKHOAN SET SO_LUONG = :CK WHERE SO_TKLK = :soTKLK AND MA_CK = :maCK";
                oracleCommand.Parameters.Add(new OracleParameter("CK", CK));
                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));
                oracleCommand.Parameters.Add("maCK", maCK);

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
