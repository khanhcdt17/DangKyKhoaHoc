using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Table HOCVIEN
    public class HOCVIEN
    {
        public string MAHV { get; set; }
        public int MATK { get; set; }
        public string HOTEN { get; set; }
        public string NGAYSINH { get; set; }
        public bool GIOITINH { get; set; }
        public string HINH { get; set; }
        public string E_MAIL { get; set; }
        public string DIACHI { get; set; }
        public string SODIENTHOAI { get; set; }
        public bool TRANGTHAI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public HOCVIEN() { }
        public HOCVIEN(string MAHV, int MATK, string HOTEN, string NGAYSINH, bool GIOITINH, string HINH, string E_MAIL, string DIACHI, string SODIENTHOAI, bool TRANGTHAI)
        {
            this.MAHV = MAHV;
            this.MATK = MATK;
            this.HOTEN = HOTEN;
            this.NGAYSINH = NGAYSINH;
            this.GIOITINH = GIOITINH;
            this.HINH = HINH;
            this.E_MAIL = E_MAIL;
            this.DIACHI = DIACHI;
            this.SODIENTHOAI = SODIENTHOAI;
            this.TRANGTHAI = TRANGTHAI;
        }

        public HOCVIEN(int MATK, string HOTEN, string NGAYSINH, bool GIOITINH, string HINH, string E_MAIL, string DIACHI, string SODIENTHOAI, bool TRANGTHAI)
        {
            this.MATK = MATK;
            this.HOTEN = HOTEN;
            this.NGAYSINH = NGAYSINH;
            this.GIOITINH = GIOITINH;
            this.HINH = HINH;
            this.E_MAIL = E_MAIL;
            this.DIACHI = DIACHI;
            this.SODIENTHOAI = SODIENTHOAI;
            this.TRANGTHAI = TRANGTHAI;
        }
    }
}
