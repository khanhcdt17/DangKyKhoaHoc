using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
    //Table TAINGUYEN
    public class TAINGUYEN
    {
        public int MAGV { get; set; }
        public string MAKH { get; set; }
        public string MATN { get; set; }
        public string TENTN { get; set; }
        public string NGAYCAPNHAT { get; set; }
        public string MOTA { get; set; }
        public string NOIDUNGTN { get; set; }
        public bool TRANGTHAI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public TAINGUYEN() { }
        public TAINGUYEN(int MAGV, string MAKH, string MATN, string TENTN, string NGAYCAPNHAT, string MOTA, string NOIDUNGTN, bool TRANGTHAI)
        {
            this.MAGV = MAGV;
            this.MAKH = MAKH;
            this.MATN = MATN;
            this.TENTN = TENTN;
            this.NGAYCAPNHAT = NGAYCAPNHAT;
            this.MOTA = MOTA;
            this.NOIDUNGTN = NOIDUNGTN;
            this.TRANGTHAI = TRANGTHAI;
        }

        public TAINGUYEN(string MAKH, string MATN, string TENTN, string NGAYCAPNHAT, string MOTA, string NOIDUNGTN, bool TRANGTHAI)
        {
            this.MAKH = MAKH;
            this.MATN = MATN;
            this.TENTN = TENTN;
            this.NGAYCAPNHAT = NGAYCAPNHAT;
            this.MOTA = MOTA;
            this.NOIDUNGTN = NOIDUNGTN;
            this.TRANGTHAI = TRANGTHAI;
        }
    }
}
