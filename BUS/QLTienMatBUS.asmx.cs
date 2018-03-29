using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using DAO;
using DTO;

namespace BUS
{
    /// <summary>
    /// Summary description for QLTienMatBUS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLTienMatBUS : System.Web.Services.WebService
    {
        /// <summary>
        /// Tìm kiếm thông tin theo số TKLK
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <returns></returns>
        [WebMethod]
        public string timKiem(string soTKLK)
        {
            QLTienMatDTO qLTienMat = QLTienMatDAO.timKiem(soTKLK);
            string jsonData = JsonConvert.SerializeObject(qLTienMat);
            return jsonData;
        }

        [WebMethod]
        public int KtraNopTien(string soTien)
        {
            Check check = new Check();
            if(soTien == "")
            {
                return 1;
            }
            if(check.LaMotSoNguyenDuong(soTien) == false)
            {
                return 2;
            }
            if(long.Parse(soTien) % 1000 != 0)
            {
                return 3;
            }
            return 0;
        }

        [WebMethod]
        public int KtraRutTien(string soTien, string soTienToiDa)
        {
            Check check = new Check();
            if (soTien == "")
            {
                return 1;
            }
            if (check.LaMotSoNguyenDuong(soTien) == false)
            {
                return 2;
            }
            if (long.Parse(soTien) % 1000 != 0)
            {
                return 3;
            }
            if(long.Parse(soTien) > long.Parse(soTienToiDa))
            {
                return 4;
            }
            return 0;
        }

        /// <summary>
        /// Update số tiền nộp
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <param name="soTienMat"></param>
        /// <returns></returns>
        [WebMethod]
        public bool nopTien(string soTKLK, long soTienMat, long soTienNop)
        {
            return QLTienMatDAO.nopTien(soTKLK, soTienMat,soTienNop);
        }

        [WebMethod]
        public bool rutTien(string soTKLK, long soTienMat, long soTienNop)
        {
            return QLTienMatDAO.rutTien(soTKLK, soTienMat, soTienNop);
        }
    }
}
