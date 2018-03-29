using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.Configuration;

namespace DAO
{
    public class DataProvider
    {

        // Lấy kết nối đến DB
        public static OracleConnection GetOracleConnection()
        {
            try
            {
                    
                string connectionString = ConfigurationManager.ConnectionStrings["oracleDB"].ConnectionString;
                OracleConnection oracleConnection = new OracleConnection();
                oracleConnection.ConnectionString = connectionString;

                oracleConnection.Open();

                return oracleConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối, vui lòng kiểm tra lại đường truyền \n" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        /// <summary>
        /// Thực thi câu lệnh truy vấn
        /// </summary>
        /// <param name="oracleCmd"></param>
        /// <returns></returns>
        public static OracleDataReader GetOracleDataReader(OracleCommand oracleCmd)
        {
            try
            {
                OracleDataReader oracleDataReader;
                oracleCmd.Connection = GetOracleConnection();
                oracleDataReader = oracleCmd.ExecuteReader();

                return oracleDataReader;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi truy vấn CSDL \n" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Thực thi câu lệnh non query
        /// </summary>
        /// <param name="oracleCommand"></param>
        /// <returns></returns>
        public static bool ExcuteNonQuery(OracleCommand oracleCommand)
        {
            try
            {
                oracleCommand.Connection = GetOracleConnection();
                oracleCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi truy vấn CSDL \n" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
