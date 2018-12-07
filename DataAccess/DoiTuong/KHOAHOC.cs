using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
    //Table KHOAHOC
    public class KHOAHOC
    {
        public string MAKH { get; set; }
        public string TENKHOAHOC { get; set; }
        public string MOTA { get; set; }
        public int THOIGIAN { get; set; }
        public string NOIDUNG { get; set; }
        public string MUCTIEU { get; set; }
        public int SOLUONGHOCVIENTOITHIEU { get; set; }
        public int SOLUONGHOCVIENTOIDA { get; set; }
        public bool TRANGTHAI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public KHOAHOC() { }
        public KHOAHOC(string MAKH, string TENKHOAHOC, string MOTA, int THOIGIAN, string NOIDUNG, string MUCTIEU, int SOLUONGHOCVIENTOITHIEU, int SOLUONGHOCVIENTOIDA, bool TRANGTHAI)
        {
            this.MAKH = MAKH;
            this.TENKHOAHOC = TENKHOAHOC;
            this.MOTA = MOTA;
            this.THOIGIAN = THOIGIAN;
            this.NOIDUNG = NOIDUNG;
            this.MUCTIEU = MUCTIEU;
            this.SOLUONGHOCVIENTOITHIEU = SOLUONGHOCVIENTOITHIEU;
            this.SOLUONGHOCVIENTOIDA = SOLUONGHOCVIENTOIDA;
            this.TRANGTHAI = TRANGTHAI;
        }

        public KHOAHOC(string TENKHOAHOC, string MOTA, int THOIGIAN, string NOIDUNG, string MUCTIEU, int SOLUONGHOCVIENTOITHIEU, int SOLUONGHOCVIENTOIDA, bool TRANGTHAI)
        {
            this.TENKHOAHOC = TENKHOAHOC;
            this.MOTA = MOTA;
            this.THOIGIAN = THOIGIAN;
            this.NOIDUNG = NOIDUNG;
            this.MUCTIEU = MUCTIEU;
            this.SOLUONGHOCVIENTOITHIEU = SOLUONGHOCVIENTOITHIEU;
            this.SOLUONGHOCVIENTOIDA = SOLUONGHOCVIENTOIDA;
            this.TRANGTHAI = TRANGTHAI;
        }
    }
}
