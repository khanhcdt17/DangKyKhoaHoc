using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
    //Table BIENLAI
    public class BIENLAI
    {
        public string MABL { get; set; }
        public string MAHV { get; set; }
        public string MACTKH { get; set; }
        public string NGUOINOP { get; set; }
        public string LYDO { get; set; }
        public string NGUOITHU { get; set; }
        public Int64 MIENGIAMHOCPHI { get; set; }
        public string LYDOMIENGIAM { get; set; }
        public bool TRANGTHAI { get; set; }
        public string NgayNop { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public BIENLAI() { }
        public BIENLAI(string MABL, string MAHV, string MACTKH, string NGUOINOP, string LYDO, string NGUOITHU, Int64 MIENGIAMHOCPHI, string LYDOMIENGIAM, bool TRANGTHAI, string NgayNop)
        {
            this.MABL = MABL;
            this.MAHV = MAHV;
            this.MACTKH = MACTKH;
            this.NGUOINOP = NGUOINOP;
            this.LYDO = LYDO;
            this.NGUOITHU = NGUOITHU;
            this.MIENGIAMHOCPHI = MIENGIAMHOCPHI;
            this.LYDOMIENGIAM = LYDOMIENGIAM;
            this.TRANGTHAI = TRANGTHAI;
            this.NgayNop = NgayNop;
        }

        public BIENLAI(string MAHV, string MACTKH, string NGUOINOP, string LYDO, string NGUOITHU, Int64 MIENGIAMHOCPHI, string LYDOMIENGIAM, bool TRANGTHAI, string NgayNop)
        {
            this.MAHV = MAHV;
            this.MACTKH = MACTKH;
            this.NGUOINOP = NGUOINOP;
            this.LYDO = LYDO;
            this.NGUOITHU = NGUOITHU;
            this.MIENGIAMHOCPHI = MIENGIAMHOCPHI;
            this.LYDOMIENGIAM = LYDOMIENGIAM;
            this.TRANGTHAI = TRANGTHAI;
            this.NgayNop = NgayNop;
        }
    }
}
