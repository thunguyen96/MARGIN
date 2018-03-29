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
    public class QLRoCKDAO
    {
        // lấy ra thông tin của 1 rổ chứng khoán khi biết mã rổ
        public static List<QLRoCKDTO> timKiem(string maRo)
        {
            try
            {
                List<QLRoCKDTO> qLRoCKDTOs = new List<QLRoCKDTO>();
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT RO_CK.MA_RO, RO_CK.TEN_RO, CHI_TIET_RO.MA_CK,CHI_TIET_RO.GIA_VAY, CHI_TIET_RO.TI_LE_VAY,CHUNG_KHOAN.TEN_CK  FROM RO_CK, CHI_TIET_RO , CHUNG_KHOAN WHERE RO_CK.MA_RO = CHI_TIET_RO.MA_RO AND CHUNG_KHOAN.MA_CK = CHI_TIET_RO.MA_CK AND RO_CK.MA_RO = :maRo";

                oracleCommand.Parameters.Add(new OracleParameter("maRo", maRo));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        QLRoCKDTO qLRo = new QLRoCKDTO();

                        qLRo.MaRo = oracleDataReader.GetString(0);
                        qLRo.TenRo = oracleDataReader.GetString(1);
                        qLRo.MaCK = oracleDataReader.GetString(2);
                        qLRo.GiaVay = oracleDataReader.GetInt64(3);
                        qLRo.TiLeVay = oracleDataReader.GetInt64(4);
                        qLRo.TenCK = oracleDataReader.GetString(5);

                        qLRoCKDTOs.Add(qLRo);
                    }

                    oracleCommand.Connection.Dispose();
                    return qLRoCKDTOs;
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

        public static RoCK layTenRo(string maRo)
        {
            try
            {
                RoCK qLRoCKDTOs = new RoCK();
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT * FROM RO_CK WHERE RO_CK.MA_RO = :maRo";

                oracleCommand.Parameters.Add(new OracleParameter("maRo", maRo));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    oracleDataReader.Read();
                    RoCK roCK = new RoCK();

                    roCK.MaRo = oracleDataReader.GetString(0);
                    roCK.TenRo = oracleDataReader.GetString(1);

                    oracleCommand.Connection.Dispose();
                    return roCK;
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

        public static bool ThemRoCK(RoCK roCK)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "INSERT INTO RO_CK (MA_RO,TEN_RO) VALUES (:maRo,:tenRo)";
                oracleCommand.Parameters.Add("maRo", roCK.MaRo);
                oracleCommand.Parameters.Add("tenRo", roCK.TenRo);

                return DataProvider.ExcuteNonQuery(oracleCommand);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ThemCK(QLRoCKDTO roCK)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "INSERT INTO CHI_TIET_RO (MA_RO, MA_CK,GIA_VAY,TI_LE_VAY) VALUES (:maRo,:maCK,:giaVay,:tiLeVay)";
                oracleCommand.Parameters.Add("maRo", roCK.MaRo);
                oracleCommand.Parameters.Add("maCK", roCK.MaCK);
                oracleCommand.Parameters.Add("giaVay", roCK.GiaVay);
                oracleCommand.Parameters.Add("tiLeVay", roCK.TiLeVay);

                return DataProvider.ExcuteNonQuery(oracleCommand);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // lấy danh sách mã CK
        public static List<MaCK> layDSMaCk()
        {
            try
            {
                List<MaCK> list = new List<MaCK>();

                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT * FROM CHUNG_KHOAN";

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

        // lấy danh sách rổ CK
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

        // Sửa thông tin rổ chứng khoán
        public static bool suaThongTinroCK(string maRo, string tenRo)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "UPDATE RO_CK SET TEN_RO = :tenRo WHERE MA_RO = :maRo";
                oracleCommand.Parameters.Add(new OracleParameter("tenRo", tenRo));
                oracleCommand.Parameters.Add(new OracleParameter("maRo", maRo));
                

                return DataProvider.ExcuteNonQuery(oracleCommand);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Sửa thông tin mã chứng khoán
        public static bool suaThongTinmaCK(string maRo, string maCK, string giaVay, string tiLeVay)
        {
            try
            {
                long GiaVay = long.Parse(giaVay);
                long TiLeVay = long.Parse(tiLeVay);

                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "UPDATE CHI_TIET_RO SET GIA_VAY = :giaVay, TI_LE_VAY =:tiLeVay WHERE MA_RO = :maRo AND MA_CK =:maCK";
                oracleCommand.Parameters.Add(new OracleParameter("giaVay", GiaVay));
                oracleCommand.Parameters.Add(new OracleParameter("tiLeVay", TiLeVay));
                oracleCommand.Parameters.Add(new OracleParameter("maRo", maRo));
                oracleCommand.Parameters.Add(new OracleParameter("maCK", maCK));

                return DataProvider.ExcuteNonQuery(oracleCommand);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //lấy ra danh sách mã chứng khoán khi biết mã rổ
        public static List<QLRoCKDTO> GetMaCK(string maRo)
        {
            try
            {
                List<QLRoCKDTO> qLRoCKDTOs = new List<QLRoCKDTO>();
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "SELECT CHI_TIET_RO.MA_CK FROM CHI_TIET_RO WHERE MA_RO = :maRo";

                oracleCommand.Parameters.Add(new OracleParameter("maRo", maRo));

                OracleDataReader oracleDataReader = DataProvider.GetOracleDataReader(oracleCommand);

                if (oracleDataReader != null && oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        QLRoCKDTO qLRo = new QLRoCKDTO();

                        qLRo.MaRo = oracleDataReader.GetString(0);
                        //qLRo.TenRo = oracleDataReader.GetString(1);
                        //qLRo.MaCK = oracleDataReader.GetString(2);
                        //qLRo.GiaVay = oracleDataReader.GetInt64(3);
                        //qLRo.TiLeVay = oracleDataReader.GetInt64(4);

                        qLRoCKDTOs.Add(qLRo);
                    }

                    oracleCommand.Connection.Dispose();
                    return qLRoCKDTOs;
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

        public static bool XoaMaCK(string maRo, string maCK)
        {
            try
            {
                OracleCommand oracleCommand = new OracleCommand();
                oracleCommand.CommandText = "DELETE FROM CHI_TIET_RO WHERE MA_RO = :maRo AND MA_CK = :maCK";
                oracleCommand.Parameters.Add("maRo", maRo);
                oracleCommand.Parameters.Add("maCK", maCK);

                return DataProvider.ExcuteNonQuery(oracleCommand);
            }catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
