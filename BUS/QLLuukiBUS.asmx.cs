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
    /// Summary description for QLLuukiBUS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLLuukiBUS : System.Web.Services.WebService
    {

        [WebMethod]
        public string timKiem(string soTKLK)
        {
            List<QLLuuKiDTO> qLTienMat = QLLuuKiDAO.timKiem(soTKLK);
            string jsonData = JsonConvert.SerializeObject(qLTienMat);
            return jsonData;
        }

        [WebMethod]
        public int KtraNopLuuKi(string soLuuKi)
        {
            Check check = new Check();
            if (soLuuKi == "")
            {
                return 1;
            }
            if (check.LaMotSoNguyenDuong(soLuuKi) == false)
            {
                return 2;
            }
            return 0;
        }

        [WebMethod]
        public int KtraRutLuuKi(string soLuuKi, string soLuongToiDa)
        {
            Check check = new Check();
            if (soLuuKi == "")
            {
                return 1;
            }
            if (check.LaMotSoNguyenDuong(soLuuKi) == false)
            {
                return 2;
            }
            if (long.Parse(soLuuKi) > long.Parse(soLuongToiDa))
            {
                return 3;
            }
            return 0;
        }

        [WebMethod]
        public bool nopLuuKi(string soTKLK, string maCK, long soLuong, long soLuongNop)
        {
            return QLLuuKiDAO.nopLuuKi(soTKLK, maCK, soLuong, soLuongNop);
        }

        [WebMethod]
        public bool rutLuuKi(string soTKLK, string maCK, long soLuong, long soLuongRut)
        {
            return QLLuuKiDAO.rutLuuKi(soTKLK, maCK, soLuong, soLuongRut);
        }

        [WebMethod]
        public int KtraNhapSoTKLK(string soTKLK)
        {
            if (soTKLK == "")
            {
                return 1;
            }
            if (QLLuuKiDAO.timKiem(soTKLK) == null)
            {
                return 2;
            }
            return 0;
        }



    }
}
