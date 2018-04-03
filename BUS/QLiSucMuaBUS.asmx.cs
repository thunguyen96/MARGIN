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
    /// Summary description for QLiSucMuaBUS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLiSucMuaBUS : System.Web.Services.WebService
    {

        [WebMethod]
        public string timKiem(string soTKLK)
        {
            List<QLiSucMuaDTO> qLiSucMuas = QliSucMuaDAO.layThongTinKH(soTKLK);
            string jsonData = JsonConvert.SerializeObject(qLiSucMuas);
            return jsonData;
        }

        [WebMethod]
        public string layDSMaCK(string soTKLK)
        {
            List<MaCK> list = new List<MaCK>();
            list = QliSucMuaDAO.LayDSMaCK(soTKLK);

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
        public string layThongtinCK(string soTKLK)
        {
            List<QLiSucMuaDTO> qLiSucMua = QliSucMuaDAO.layThongTinCK(soTKLK);
            string jsonData = JsonConvert.SerializeObject(qLiSucMua);
            return jsonData;
        }

        [WebMethod]
        public int KtraNhap(string giaMua, string soLuongMua, string giaTran, string giaSan)
        {
            Check check = new Check();
            if (giaMua == "")
            {
                return 1;
            }
            if ((long.Parse(giaMua) < long.Parse(giaSan)) || (long.Parse(giaMua) >long.Parse(giaTran)))
            {
                return 2;
            }
            if (check.ChiChuaChuSo(giaMua) == false)
            {
                return 3;
            }
            if (check.ChiChuaChuSo(soLuongMua) == false)
            {
                return 4;
            }
            return 0;
        }

        [WebMethod]
        public long GetSL(string SoTKLK, string maCK)
        {
            return QliSucMuaDAO.GetSL(SoTKLK, maCK);
        }

        [WebMethod]
        public bool ThemMuaCK(string soTKLK, string maCK, long sl, long slBD, long duNoBD, long gtMua, long tienMat)
        {
            return QliSucMuaDAO.ThemMuaCK(soTKLK, maCK, sl, slBD, duNoBD, gtMua, tienMat);
        }
    }
}
