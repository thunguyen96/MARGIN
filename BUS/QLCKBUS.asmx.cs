using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DAO;
using DTO;
using Newtonsoft.Json;

namespace BUS
{
    /// <summary>
    /// Summary description for QLCKBUS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLCKBUS : System.Web.Services.WebService
    {
        // lấy danh sách chứng khoán
        [WebMethod]
        public string layDSCK()
        {
            List<QLCKDTO> list = new List<QLCKDTO>();
            list = QLCKDAO.layDSCK();

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

        // lấy thông tin chứng khoán khi biết mã chứng khoán
        [WebMethod]
        public string GetmaCK(string maCK)
        {
            QLCKDTO chungkhoan = QLCKDAO.laymotCK(maCK);
            string jsonData = JsonConvert.SerializeObject(chungkhoan);
            return jsonData;
        }
        
        // Thêm mới mã chứng khoán
        [WebMethod]
        public bool ThemCK(string jsonData)
        {
            QLCKDTO chungKhoan = new QLCKDTO();
            chungKhoan = JsonConvert.DeserializeObject<QLCKDTO>(jsonData);
            return QLCKDAO.ThemMaCK(chungKhoan);
        }

        // Kiểm tra thông tin thêm mới chứng khoán
        [WebMethod]
        public int KTThongTinThemCK(string maCK, string tenCK, string giaTran, string giaSan)
        {
            Check check = new Check();
            if (maCK == "")
            {
                return 1;
            }
            if (tenCK == "")
            {
                return 2;
            }
            if (giaTran == "")
            {
                return 3;
            }
            if (giaSan == "")
            {
                return 4;
            }
            if (check.LaMotSoNguyenDuong(giaTran) == false || long.Parse(giaTran) % 1000 != 0)
            {
                return 5;
            }
            if (check.LaMotSoNguyenDuong(giaSan) == false || long.Parse(giaSan) % 1000 != 0)
            {
                return 6;
            }
            if (check.ChiChuaChuCai(maCK) == false || maCK.Length != 3)
            {
                return 7;
            }
            if (check.ChiChuaChuCai(tenCK) == false || tenCK.Length > 50)
            {
                return 8;
            }
            if (long.Parse(giaTran) < long.Parse(giaSan))
            {
                return 9;
            }
            if (QLCKDAO.laymotCK(maCK) != null)
            {
                return 10;
            }
            return 0;
        }

        //Sửa mã chứng khoán
        [WebMethod]
        public bool SuaCK(string maCK, string tenCK, string giaTran, string giaSan)
        {
            return QLCKDAO.suaMaCK(maCK, tenCK, giaTran, giaSan);
        }

        // Kiểm tra thông tin sửa chứng khoán
        [WebMethod]
        public int KTThongTinSuaCK(string giaTran, string giaSan)
        {
            Check check = new Check();
            if (giaTran == "")
            {
                return 1;
            }
            if (giaSan == "")
            {
                return 2;
            }
            if (check.LaMotSoNguyenDuong(giaTran) == false || long.Parse(giaTran) % 1000 != 0)
            {
                return 3;
            }
            if (check.LaMotSoNguyenDuong(giaSan) == false || long.Parse(giaSan) % 1000 != 0 )
            {
                return 4;
            }
            if (long.Parse(giaTran) < long.Parse(giaSan))
            {
                return 5;
            }
            return 0;
        }
    }
}
