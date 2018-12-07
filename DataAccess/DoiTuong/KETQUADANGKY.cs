using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
    //Table KETQUADANGKY
    public class KETQUADANGKY
    {
        public int MAKQ { get; set; }
        public string MAHV { get; set; }
        public string MACTKH { get; set; }
        public string THOIGIANDK { get; set; }
        public string GHICHU { get; set; }
        public string HINHTHUCDANGKY { get; set; }
        public bool TRANGTHAI { get; set; }
    

        //Phương thức có ID phục vụ cho việc Update
        public KETQUADANGKY() { }
        public KETQUADANGKY(int MAKQ, string MAHV, string MACTKH, string THOIGIANDK, string GHICHU, string HINHTHUCDANGKY, bool TRANGTHAI)
        {
            this.MAKQ = MAKQ;
            this.MAHV = MAHV;
            this.MACTKH = MACTKH;
            this.THOIGIANDK = THOIGIANDK;
            this.GHICHU = GHICHU;
            this.HINHTHUCDANGKY = HINHTHUCDANGKY;
            this.TRANGTHAI = TRANGTHAI;
            
        }

        public KETQUADANGKY(string MAHV, string MACTKH, string THOIGIANDK, string GHICHU, string HINHTHUCDANGKY, bool TRANGTHAI)
        {
            this.MAHV = MAHV;
            this.MACTKH = MACTKH;
            this.THOIGIANDK = THOIGIANDK;
            this.GHICHU = GHICHU;
            this.HINHTHUCDANGKY = HINHTHUCDANGKY;
            this.TRANGTHAI = TRANGTHAI;
            
        }
    }
}
