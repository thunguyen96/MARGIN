using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLLuuKiDTO
    {
        private string soTKLK;
        private string hoTen;
        private string soCMND;
        private string SDT;
        private string maCK;
        private string tenCK;
        private long soLuong;
        private int giaVay;
        private int tiLeVay;

        public string SoTKLK { get; set; }
        public string HoTen { get; set; }
        public string SoCMND { get; set; }
        public string SoDT { get; set; }
        public string MaCK { get; set; }
        public string TenCK { get; set; }
        public long SoLuong { get; set; }
        public int GiaVay { get; set; }
        public int TiLeVay { get; set; }
    }
}
