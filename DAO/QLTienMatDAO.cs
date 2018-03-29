using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class QLTienMatDAO
    {
        /// <summary>
        /// Tìm kiếm theo số TKLK
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <returns></returns>
        public static QLTienMatDTO timKiem(string soTKLK)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT HO_TEN,SO_CMND,SDT,SO_TIEN_MAT,SO_DU_NO,SO_TKLK FROM KHACH_HANG WHERE SO_TKLK = :soTKLK";

                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    oracleDataReader.Read();
                    QLTienMatDTO qLTienMat = new QLTienMatDTO();

                    qLTienMat.HoTen = oracleDataReader.GetString(0);
                    qLTienMat.SoCMND = oracleDataReader.GetString(1);
                    qLTienMat.SDT = oracleDataReader.GetString(2);
                    qLTienMat.TienMat = oracleDataReader.GetInt64(3);
                    qLTienMat.DuNo = oracleDataReader.GetInt64(4);
                    qLTienMat.SoTKLK = oracleDataReader.GetString(5);

                    oracleCommand.Connection.Dispose();
                    return qLTienMat;
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

        public static bool nopTien(string soTKLK, long soTienMat,long soTienNop)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                long tien = soTienMat + soTienNop;
                oracleCommand.CommandText = "UPDATE KHACH_HANG SET SO_TIEN_MAT = :tien WHERE SO_TKLK = :soTKLK";
                oracleCommand.Parameters.Add(new OracleParameter("tien", tien));
                oracleCommand.Parameters.Add(new OracleParameter("soTKLK", soTKLK));

                return DataProvider.ExcuteNonQuery(oracleCommand);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool rutTien(string soTKLK, long soTienMat, long soTienRut)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                long tien = soTienMat - soTienRut;
                oracleCommand.CommandText = "UPDATE KHACH_HANG SET SO_TIEN_MAT = :tien WHERE SO_TKLK = :soTKLK";
                oracleCommand.Parameters.Add(new OracleParameter("tien", tien));
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
