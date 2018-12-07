using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
    //Table TAIKHOAN
    public class TAIKHOAN
    {
        public int MATK { get; set; }
        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
        public string MAILBAOMAT { get; set; }
        public string CHUCDANH { get; set; }
        public string QUANLY { get; set; }
        public bool TRANGTHAI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public TAIKHOAN() { }
        public TAIKHOAN(int MATK, string TENDANGNHAP, string MATKHAU, string MAILBAOMAT, string CHUCDANH, string QUANLY, bool TRANGTHAI)
        {
            this.MATK = MATK;
            this.TENDANGNHAP = TENDANGNHAP;
            this.MATKHAU = MATKHAU;
            this.MAILBAOMAT = MAILBAOMAT;
            this.CHUCDANH = CHUCDANH;
            this.QUANLY = QUANLY;
            this.TRANGTHAI = TRANGTHAI;
        }

        public TAIKHOAN(string TENDANGNHAP, string MATKHAU, string MAILBAOMAT, string CHUCDANH, string QUANLY, bool TRANGTHAI)
        {
            this.TENDANGNHAP = TENDANGNHAP;
            this.MATKHAU = MATKHAU;
            this.MAILBAOMAT = MAILBAOMAT;
            this.CHUCDANH = CHUCDANH;
            this.QUANLY = QUANLY;
            this.TRANGTHAI = TRANGTHAI;
        }
    }
}
