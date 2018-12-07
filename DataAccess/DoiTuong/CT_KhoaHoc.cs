using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
    //Table CT_KHOAHOC
    public class CT_KHOAHOC
    {
        public string MACTKH { get; set; }
        public int MAGV { get; set; }
        public int MAKT { get; set; }
        public string MAKH { get; set; }
        public string NGAYKHAIGIANG { get; set; }
        public Int64 HOCPHI { get; set; }
        public DateTime GIOHOC { get; set; }
        public string TENPHONG { get; set; }
        public bool TRANGTHAI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public CT_KHOAHOC() { }
        public CT_KHOAHOC(string MACTKH, int MAGV, int MAKT, string MAKH, string NGAYKHAIGIANG, Int64 HOCPHI, DateTime GIOHOC, string TENPHONG, bool TRANGTHAI)
        {
            this.MACTKH = MACTKH;
            this.MAGV = MAGV;
            this.MAKT = MAKT;
            this.MAKH = MAKH;
            this.NGAYKHAIGIANG = NGAYKHAIGIANG;
            this.HOCPHI = HOCPHI;
            this.GIOHOC = GIOHOC;
            this.TENPHONG = TENPHONG;
            this.TRANGTHAI = TRANGTHAI;
        }

        public CT_KHOAHOC(int MAGV, int MAKT, string MAKH, string NGAYKHAIGIANG, Int64 HOCPHI, DateTime GIOHOC, string TENPHONG, bool TRANGTHAI)
        {
            this.MAGV = MAGV;
            this.MAKT = MAKT;
            this.MAKH = MAKH;
            this.NGAYKHAIGIANG = NGAYKHAIGIANG;
            this.HOCPHI = HOCPHI;
            this.GIOHOC = GIOHOC;
            this.TENPHONG = TENPHONG;
            this.TRANGTHAI = TRANGTHAI;
        }
    }
}
