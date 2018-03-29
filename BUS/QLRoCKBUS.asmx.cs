using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DTO;
using DAO;
using Newtonsoft.Json;

namespace BUS
{
    /// <summary>
    /// Summary description for QLRoCKBUS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLRoCKBUS : System.Web.Services.WebService
    {
        [WebMethod]
        public string timKiem(string roCK)
        {
            List<QLRoCKDTO> qlRo = QLRoCKDAO.timKiem(roCK);
            string jsonData = JsonConvert.SerializeObject(qlRo);
            return jsonData;
        }

        // lấy danh sách mã chứng khoán
        [WebMethod]
        public string layDSMaCK()
        {
            List<MaCK> list = new List<MaCK>();
            list = QLRoCKDAO.layDSMaCk();

            if (list != null)
            {
                string jsonData = JsonConvert.SerializeObject(list);
                return jsonData;
            }
            else
            {
                return null;
            }
        }

        // lấy danh sách mã rổ
        [WebMethod]
        public string layDSRo()
        {
            List<RoCK> list = new List<RoCK>();
            list = QLKHDAO.layDSRo();

            if (list != null)
            {
                string jsonData = JsonConvert.SerializeObject(list);
                return jsonData;
            }
            else
            {
                return null;
            }
        }

        [WebMethod]
        public string layTenRo(string maRo)
        {
            RoCK roCK = QLRoCKDAO.layTenRo(maRo);
            string jsonData = JsonConvert.SerializeObject(roCK);
            return jsonData;
        }

        [WebMethod]
        public int KTThongTinThemRoCK(string tenRo)
        {
       
            Check check = new Check();
            if (tenRo == "")
            {
                return 1;
            }
            if (tenRo.Length > 50)
            {
                return 2;
            }
            //if (QLRoCKDAO.timKiem(maRo) != null)
            //{
            //    return 7;
            //}
            return 0;
        }

        [WebMethod]
        public bool ThemRoCK(string jsonData)
        {
            RoCK roCK = new RoCK();
            roCK = JsonConvert.DeserializeObject<RoCK>(jsonData);
            return QLRoCKDAO.ThemRoCK(roCK);
        }

        [WebMethod]
        public bool ThemCK(string jsonData)
        {
            QLRoCKDTO roCK = new QLRoCKDTO();
            roCK = JsonConvert.DeserializeObject<QLRoCKDTO>(jsonData);
            return QLRoCKDAO.ThemCK(roCK);
        }

        [WebMethod]
        public string taoMaRo()
        {
            //Lấy danh sách rổ
            List<RoCK> list = QLRoCKDAO.layDSRo();
            var listMaGN = new List<string>();
            //Lấy các mã rổ đã tồn tại
            foreach (RoCK temp in list)
            {
                listMaGN.Add(temp.MaRo);
            }
            //Sinh mã
            string resulf = "";
            for (int index = 1; index <= 99; index++)
            {
                if (index.ToString().Length == 1)
                {
                    resulf += "0";
                    resulf += index.ToString();
                }
                else
                {
                    resulf += index.ToString();
                }
                //Kiểm tra mã
                if (!listMaGN.Contains(resulf))
                {
                    return resulf;
                }
                else
                {
                    resulf ="";
                }
            }
            return resulf;
        }

        // Sửa tên rổ
        [WebMethod]
        public bool suaTenRo(string maRo, string tenRo)
        {
            return QLRoCKDAO.suaThongTinroCK(maRo, tenRo);
        }

        [WebMethod]
        public string layTTinMaCK(string maRo)
        {
            List<QLRoCKDTO> qlRo = QLRoCKDAO.timKiem(maRo);
            string jsonData = JsonConvert.SerializeObject(qlRo);
            return jsonData;
        }

        // Sửa thông tin rổ CK
        [WebMethod]
        public bool suaThongTinroCK(string tenRo, string maRo)
        {
            return QLRoCKDAO.suaThongTinroCK(tenRo, maRo);
        }

        // Kiểm tra thông tin sửa rổ chứng khoán
        [WebMethod]
        public int KTThongTinSuaRoCK(string giaVay, string tiLeVay)
        {

            Check check = new Check();
            if (giaVay == "")
            {
                return 1;
            }
            if (tiLeVay == "")
            {
                return 2;
            }
            if (check.ChiChuaChuSo(giaVay) == false)
            {
                return 3;
            }
            if (check.ChiChuaChuSo(tiLeVay) == false || long.Parse(tiLeVay) <= 0 || long.Parse(tiLeVay) >= 100)
            
            {
                return 4;
            }
            return 0;
        }

        // Sửa mã chứng khoán trong rổ
        [WebMethod]
        public bool suaTTMaCK( string maRo, string maCK, string giaVay, string tiLeVay)
        {
            return QLRoCKDAO.suaThongTinmaCK(maRo, maCK, giaVay, tiLeVay);
        }

        [WebMethod]
        public bool XoaMaCK(string maRo, string maCK)
        {
            return QLRoCKDAO.XoaMaCK(maRo, maCK);
        }
    }

}
