using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
    //Table LICHTHI
    public class LICHTHI
    {
        public int MAKT { get; set; }
        public string TENKT { get; set; }
        public string NGAYTHI { get; set; }
        public int THOIGIAN { get; set; }
        public string PHONGTHI { get; set; }
        public bool TRANGTHAI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public LICHTHI() { }
        public LICHTHI(int MAKT, string TENKT, string NGAYTHI, int THOIGIAN, string PHONGTHI, bool TRANGTHAI)
        {
            this.MAKT = MAKT;
            this.TENKT = TENKT;
            this.NGAYTHI = NGAYTHI;
            this.THOIGIAN = THOIGIAN;
            this.PHONGTHI = PHONGTHI;
            this.TRANGTHAI = TRANGTHAI;
        }

        public LICHTHI(string TENKT, string NGAYTHI, int THOIGIAN, string PHONGTHI, bool TRANGTHAI)
        {
            this.TENKT = TENKT;
            this.NGAYTHI = NGAYTHI;
            this.THOIGIAN = THOIGIAN;
            this.PHONGTHI = PHONGTHI;
            this.TRANGTHAI = TRANGTHAI;
        }
    }
}
