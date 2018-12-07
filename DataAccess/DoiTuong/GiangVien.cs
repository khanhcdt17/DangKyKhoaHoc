using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
    //Table GIANGVIEN
    public class GIANGVIEN
    {
        public int MAGV { get; set; }
        public int MATK { get; set; }
        public string HOTEN { get; set; }
        public bool GIOITINH { get; set; }
        public string NGAYSINH { get; set; }
        public string HINHANH { get; set; }
        public string DIACHI { get; set; }
        public string SODIENTHOAI { get; set; }
        public string E_MAIL { get; set; }
        public string TRINHDO { get; set; }
        public bool TRANGTHAI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public GIANGVIEN() { }
        public GIANGVIEN(int MAGV, int MATK, string HOTEN, bool GIOITINH, string NGAYSINH, string HINHANH, string DIACHI, string SODIENTHOAI, string E_MAIL, string TRINHDO, bool TRANGTHAI)
        {
            this.MAGV = MAGV;
            this.MATK = MATK;
            this.HOTEN = HOTEN;
            this.GIOITINH = GIOITINH;
            this.NGAYSINH = NGAYSINH;
            this.HINHANH = HINHANH;
            this.DIACHI = DIACHI;
            this.SODIENTHOAI = SODIENTHOAI;
            this.E_MAIL = E_MAIL;
            this.TRINHDO = TRINHDO;
            this.TRANGTHAI = TRANGTHAI;
        }

        public GIANGVIEN(int MATK, string HOTEN, bool GIOITINH, string NGAYSINH, string HINHANH, string DIACHI, string SODIENTHOAI, string E_MAIL, string TRINHDO, bool TRANGTHAI)
        {
            this.MATK = MATK;
            this.HOTEN = HOTEN;
            this.GIOITINH = GIOITINH;
            this.NGAYSINH = NGAYSINH;
            this.HINHANH = HINHANH;
            this.DIACHI = DIACHI;
            this.SODIENTHOAI = SODIENTHOAI;
            this.E_MAIL = E_MAIL;
            this.TRINHDO = TRINHDO;
            this.TRANGTHAI = TRANGTHAI;
        }
    }
}
