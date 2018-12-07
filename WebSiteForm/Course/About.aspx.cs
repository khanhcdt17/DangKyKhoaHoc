using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Course_About : System.Web.UI.Page
{
    public List<GIANGVIEN> listGiangVien = new List<GIANGVIEN>();
    private QLGiangVien QLGiangVien = new QLGiangVien();

    public List<KHOAHOC> listKhoaHoc = new List<KHOAHOC>();
    private QLKhoaHoc QLKhoaHoc = new QLKhoaHoc();

    public List<CT_KHOAHOC> listCT_KhoaHoc = new List<CT_KHOAHOC>();
    private QLCT_KhoaHoc QLCT_KhoaHoc = new QLCT_KhoaHoc();

    public List<HOCVIEN> listHocVien = new List<HOCVIEN>();
    private QLHocVien QLHocVien = new QLHocVien();

    protected void Page_Load(object sender, EventArgs e)
    {
        QLGiangVien.GetAll();
        listGiangVien = QLGiangVien.listGiangVien;

        QLKhoaHoc.GetAll();
        listKhoaHoc = QLKhoaHoc.listKHOAHOC;

        QLCT_KhoaHoc.GetAll();
        listCT_KhoaHoc = QLCT_KhoaHoc.listCT_KhoaHoc;

        QLHocVien.GetAll();
        listHocVien = QLHocVien.listHOCVIEN;
    }
    public String TimTenGiangVien(int maGV)
    {

        for (int i = 0; i < listGiangVien.Count; i++)
        {
            if (maGV==listGiangVien[i].MAGV)
            {
                return listGiangVien[i].HOTEN;
            }
        }
        return null;
    }
    public String TimTenKhoaHoc(string maKH)
    {

        for (int i = 0; i < listKhoaHoc.Count; i++)
        {
            if (maKH == listKhoaHoc[i].MAKH)
            {
                return listKhoaHoc[i].TENKHOAHOC;
            }
        }
        return null;
    }
    public string NgayKhaiGiang(string ngayThangNam)
    {
        try
        {
            string ngay = ngayThangNam.Substring(0, 2);
            string thang = ngayThangNam.Substring(2, 2);
            string nam = ngayThangNam.Substring(4, 4);
            return ngay + "/" + thang + "/" + nam;
        }
        catch (Exception)
        {

            return null;
        }
       

        

    }
}