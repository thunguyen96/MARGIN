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
    /// Summary description for QLyKHBUS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLyKHBUS : System.Web.Services.WebService
    {

        /// <summary>
        /// Lấy danh sách khách hàng
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string layDSKhachHang()
        {
            List<QLyKHDTO> list = new List<QLyKHDTO>();
            list = QLKHDAO.layDSKhachHang();

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

        /// <summary>
        /// Lấy ra một khách hàng khi biết số TKLK
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <returns></returns>
        [WebMethod]
        public string layMotKhachHang(string soTKLK)
        {
            QLyKHDTO khachHang = QLKHDAO.layMotKhachHang(soTKLK);
            string jsonData = JsonConvert.SerializeObject(khachHang);
            return jsonData;
        }

        /// <summary>
        /// Lấy ra một khách hàng khi biết số cmnd
        /// </summary>
        /// <param name="soCMND"></param>
        /// <returns></returns>
        [WebMethod]
        public string GetKH(string soCMND)
        {
            QLyKHDTO khachHang = QLKHDAO.GetKhachHang(soCMND);
            string jsonData = JsonConvert.SerializeObject(khachHang);
            return jsonData;
        }
        
        // lấy ra một khách hàng khi biết số điên thoại
        [WebMethod]
        public string GetKHSDT(string SDT)
        {
            QLyKHDTO khachHang = QLKHDAO.GetKhachHangSDT(SDT);
            string jsonData = JsonConvert.SerializeObject(khachHang);
            return jsonData;
        }

        /// <summary>
        /// Kiểm tra thông tin thêm mới KH
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <param name="ngayMoTK"></param>
        /// <param name="hoTen"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="noiCap"></param>
        /// <param name="soCMND"></param>
        /// <param name="diaChi"></param>
        /// <param name="hanMucVay"></param>
        /// <param name="SDT"></param>
        /// <returns></returns>
        [WebMethod]
        public int KTThongTinThemKH(string soTKLK, DateTime ngayMoTK, string hoTen, string email, DateTime ngaySinh, string noiCap, string soCMND, string diaChi, string hanMucVay, string SDT)
        {
            DateTime ngayDu18Tuoi = ngaySinh.AddYears(18);
            Check check = new Check();
            if (soTKLK == "")
            {
                return 1;
            }
            if (hoTen == "")
            {
                return 2;
            }
            if (noiCap == "")
            {
                return 3;
            }
            if (soCMND == "")
            {
                return 4;
            }
            if (diaChi == "")
            {
                return 5;
            }
            if (hanMucVay == "")
            {
                return 6;
            }
            if (SDT == "")
            {
                return 7;
            }
            if (ngayMoTK < ngayDu18Tuoi)
            {
                return 8;
            }
            if (check.ChiChuaChuCai(hoTen) == false || hoTen.Length >50)
            {
                return 9;
            }
            if (check.ChiChuaChuSo(hanMucVay) == false)
            {
                return 10;
            }
            if (!check.ChiChuaChuSo(soCMND) || soCMND.Length >12)
            {
                return 11;
            }
            if (!check.ChiChuaChuSo(SDT) || SDT.Length >12 || QLKHDAO.GetKhachHangSDT(SDT) != null)
            {
                return 12;
            }
            if (QLKHDAO.layMotKhachHang(soTKLK) != null)
            {
                return 13;
            }
            if (soTKLK.Length != 10 || !check.ChiChuaChuSo(soTKLK.Substring(4, 6)) || soTKLK.Substring(0, 4) != "001C")
            {
                return 14;
            }
            if (QLKHDAO.GetKhachHang(soCMND) != null)
            {
                return 15;
            }
            if (check.ChiChuaChuCai(diaChi) == false || diaChi.Length >50)
            {
                return 16;
            }
            if (check.ChiChuaChuCai(noiCap) == false || noiCap.Length > 50)
            {
                return 17;
            }
            if (email.Length > 50)
            {
                return 18;
            }
            return 0;
        }

        /// <summary>
        /// Kiểm tra thông tin sửa KH
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <param name="ngayMoTK"></param>
        /// <param name="hoTen"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="noiCap"></param>
        /// <param name="soCMND"></param>
        /// <param name="diaChi"></param>
        /// <param name="hanMucVay"></param>
        /// <param name="SDT"></param>
        /// <returns></returns>
        [WebMethod]
        public int KTThongTinSuaKH(string soTKLK, DateTime ngayMoTK, string email, string hoTen, DateTime ngaySinh, string noiCap, string soCMND, string diaChi, string hanMucVay, string SDT)
        {
            DateTime ngayDu18Tuoi = ngaySinh.AddYears(18);
            Check check = new Check();
     
            if (hoTen == "")
            {
                return 1;
            }
            if (noiCap == "")
            {
                return 2;
            }
            if (soCMND == "")
            {
                return 3;
            }
            if (diaChi == "")
            {
                return 4;
            }
            if (hanMucVay == "")
            {
                return 5;
            }
            if (SDT == "")
            {
                return 6;
            }
            if (check.ChiChuaChuCai(hoTen) == false || hoTen.Length > 50)
            {
                return 7;
            }
            if (check.ChiChuaChuSo(hanMucVay) == false || long.Parse(hanMucVay) % 1000 != 0)
            {
                return 8;
            }
            if (!check.ChiChuaChuSo(soCMND) || soCMND.Length > 12)
            {
                return 9;
            }
            if (!check.ChiChuaChuSo(SDT) || SDT.Length > 12 )
            {
                return 10;
            }
            if (soTKLK.Length != 10 || !check.ChiChuaChuSo(soTKLK.Substring(4, 6)) || soTKLK.Substring(0, 4) != "001C")
            {
                return 12;
            }
            if (QLKHDAO.GetKhachHang(soCMND) != null && QLKHDAO.GetKhachHang(soCMND).STKLK != soTKLK)
            {
                return 13;
            }
            if (check.ChiChuaChuCai(diaChi) == false || diaChi.Length > 50)
            {
                return 14;
            }
            if (check.ChiChuaChuCai(noiCap) == false || noiCap.Length > 50)
            {
                return 15;
            }
            if (email.Length > 50)
            {
                return 16;
            }
            if (QLKHDAO.GetKhachHangSDT(SDT) != null && QLKHDAO.GetKhachHangSDT(SDT).STKLK != soTKLK)
            {
                return 17;
            }
            if (ngayMoTK < ngayDu18Tuoi)
            {
                return 18;
            }
            return 0;
        }

        /// <summary>
        /// Thêm khách hàng
        /// </summary>
        /// <param name="jsonData"></param>
        /// <returns></returns>
        [WebMethod]
        public bool ThemKH(string jsonData)
        {
            QLyKHDTO khachHang = new QLyKHDTO();
            khachHang = JsonConvert.DeserializeObject<QLyKHDTO>(jsonData);
            return QLKHDAO.ThemKH(khachHang);
        }

        /// <summary>
        /// Lấy danh sách rổ
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Sửa khách hàng
        /// </summary>
        /// <param name="soTKLK"></param>
        /// <param name="hoTen"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="noiCap"></param>
        /// <param name="soCMNN"></param>
        /// <param name="ngayCap"></param>
        /// <param name="email"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="hanMucVay"></param>
        /// <param name="diaChi"></param>
        /// <param name="SDT"></param>
        /// <param name="maRo"></param>
        /// <returns></returns>
        [WebMethod]
        public bool suaThongTinKH(string soTKLK, string hoTen, DateTime ngaySinh, string noiCap, string soCMNN, DateTime ngayCap, string email, string gioiTinh, int hanMucVay, string diaChi, string SDT, string maRo)
        {
            return QLKHDAO.suaThongTinKH(soTKLK, hoTen, ngaySinh, noiCap, soCMNN, ngayCap, email, gioiTinh, hanMucVay, diaChi, SDT, maRo);
        }
    }
}
