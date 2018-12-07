using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
    //Table KETQUAHOC
    public class KETQUAHOC
    {
        public int MAKQ { get; set; }
        public float DIEM { get; set; }
        public string KETQUA { get; set; }
        public bool TINHTRANGHOCPHI { get; set; }
        public string TINHTRANGHOC { get; set; }
        public bool TRANGTHAI { get; set; }

        //Phương thức có ID phục vụ cho việc Update
        public KETQUAHOC() { }
        public KETQUAHOC(int MAKQ, float DIEM, string KETQUA, bool TINHTRANGHOCPHI, string TINHTRANGHOC, bool TRANGTHAI)
        {
            this.MAKQ = MAKQ;
            this.DIEM = DIEM;
            this.KETQUA = KETQUA;
            this.TINHTRANGHOCPHI = TINHTRANGHOCPHI;
            this.TINHTRANGHOC = TINHTRANGHOC;
            this.TRANGTHAI = TRANGTHAI;
        }

        public KETQUAHOC(float DIEM, string KETQUA, bool TINHTRANGHOCPHI, string TINHTRANGHOC, bool TRANGTHAI)
        {
            this.DIEM = DIEM;
            this.KETQUA = KETQUA;
            this.TINHTRANGHOCPHI = TINHTRANGHOCPHI;
            this.TINHTRANGHOC = TINHTRANGHOC;
            this.TRANGTHAI = TRANGTHAI;
        }
    }
}
