using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QLCKDTO
    {
        private string maCK;
        private string tenCK;
        private long giaTran;
        private long giaSan;
        private long giaVay;
        private long tiLeVay;

        public string MaCK { get; set; }
        public string TenCK { get; set; }
        public long GiaTran { get; set; }
        public long GiaSan { get; set; }
        public long GiaVay { get; set; }
        public long TiLeVay { get; set; }
    }
}
