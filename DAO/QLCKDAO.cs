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
    public class QLCKDAO
    {
        // lấy ra danh sách chứng khoán
        public static List<QLCKDTO> layDSCK()
        {
            try
            {
                List<QLCKDTO> list = new List<QLCKDTO>();

                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT * FROM CHUNG_KHOAN";

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        QLCKDTO chungkhoan = new QLCKDTO();

                        chungkhoan.MaCK = oracleDataReader.GetString(0);
                        chungkhoan.TenCK = oracleDataReader.GetString(1);
                        chungkhoan.GiaTran = oracleDataReader.GetInt32(2);
                        chungkhoan.GiaSan = oracleDataReader.GetInt32(3);
                      

                        list.Add(chungkhoan);
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

        // lấy ra thông tin của 1 chứng khoán khi biết mã chứng khoán
        public static QLCKDTO laymotCK(string maCK)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT * FROM CHUNG_KHOAN WHERE MA_CK = :maCK";

                oracleCommand.Parameters.Add(new OracleParameter("maCK", maCK));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    oracleDataReader.Read();
                    QLCKDTO chungkhoan = new QLCKDTO();

                    chungkhoan.MaCK = oracleDataReader.GetString(0);
                    chungkhoan.TenCK = oracleDataReader.GetString(1);
                    chungkhoan.GiaTran = oracleDataReader.GetInt32(2);
                    chungkhoan.GiaSan = oracleDataReader.GetInt32(3);

                    oracleCommand.Connection.Dispose();
                    return chungkhoan;
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

        // Thêm mới mã chứng khoán
        public static bool ThemMaCK(QLCKDTO chungkhoan)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "INSERT INTO CHUNG_KHOAN (MA_CK, TEN_CK, GIA_TRAN, GIA_SAN) " +
                    "VALUES (:maCK, :tenCK, :giaTran, :giaSan)";

                oracleCommand.Parameters.Add("maCK", chungkhoan.MaCK);
                oracleCommand.Parameters.Add("maCK", chungkhoan.TenCK);
                oracleCommand.Parameters.Add("maCK", chungkhoan.GiaTran);
                oracleCommand.Parameters.Add("maCK", chungkhoan.GiaSan);

                return DataProvider.ExcuteNonQuery(oracleCommand);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Sửa mã chứng khoán
        public static bool suaMaCK(string maCK, string tenCK, string giaTran, string giaSan)
        {
            try
            {
                long gT = long.Parse(giaTran);
                long gS = long.Parse(giaSan);
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "UPDATE CHUNG_KHOAN SET GIA_TRAN = :gT, GIA_SAN = :gS" +
                   " WHERE MA_CK = :maCK";

                oracleCommand.Parameters.Add(new OracleParameter("gT", gT));
                oracleCommand.Parameters.Add(new OracleParameter("gS", gS));
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
