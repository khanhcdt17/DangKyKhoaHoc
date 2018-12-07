using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Course_About : System.Web.UI.Page
{
    public List<HOCVIEN> listHOCVIEN = new List<HOCVIEN>();
    private QLHocVien QLHocVien = new QLHocVien();
    public HOCVIEN hocVien = new HOCVIEN();

    public List<TAIKHOAN> listTAIKHOAN = new List<TAIKHOAN>();
    private QLTaiKhoan QLTaiKhoan = new QLTaiKhoan();



    public List<KHOAHOC> listKHOAHOC = new List<KHOAHOC>();
    private QLKhoaHoc QLKhoaHoc = new QLKhoaHoc();

    public List<CT_KHOAHOC> listCT_KhoaHoc = new List<CT_KHOAHOC>();
    public List<CT_KHOAHOC> listSearch = new List<CT_KHOAHOC>();
    private QLCT_KhoaHoc QLCT_KhoaHoc = new QLCT_KhoaHoc();


    public List<GIANGVIEN> listGiangVien = new List<GIANGVIEN>();
    private QLGiangVien QLGiangVien = new QLGiangVien();


    string KhoaHoc;
    string NgayKhaiGiang_;
    string GioHoc;
    string GiangVien;
    string HocPhi;

    protected void Page_Load(object sender, EventArgs e)
    {

        QLGiangVien.GetAll();
        listGiangVien = QLGiangVien.listGiangVien;

        QLKhoaHoc.GetAll();
        listKHOAHOC = QLKhoaHoc.listKHOAHOC;

        QLHocVien.GetAll();
        listHOCVIEN = QLHocVien.listHOCVIEN;

        GetData();
    }

    void GetData()
    {
        QLCT_KhoaHoc.GetAll();
        listCT_KhoaHoc = QLCT_KhoaHoc.listCT_KhoaHoc;
        NameValueCollection data = Request.Form;
        KhoaHoc = data["KhoaHoc"];
        NgayKhaiGiang_ = data["NgayKhaiGiang"];
        GioHoc = data["GioHoc"];
        GiangVien = data["GiangVien"];
        HocPhi = data["HocPhi"];

        if (KhoaHoc != "")
        {
            string maKH = QLKhoaHoc.FindKeyWord(KhoaHoc)[0].MAKH;
            for (int i = 0; i < listCT_KhoaHoc.Count; i++)
            {
                if (maKH == listCT_KhoaHoc[i].MAKH && !listSearch.Contains(listCT_KhoaHoc[i]))
                {

                    listSearch.Add(listCT_KhoaHoc[i]);


                }
            }
        }
        if (NgayKhaiGiang_ != "")
        {
            string ngay = NgayKhaiGiang_.Substring(0, 2);
            string thang = NgayKhaiGiang_.Substring(3, 2);
            string nam = NgayKhaiGiang_.Substring(6, 4);

            for (int i = 0; i < listCT_KhoaHoc.Count; i++)
            {
                if (ngay + thang + nam == listCT_KhoaHoc[i].NGAYKHAIGIANG && !listSearch.Contains(listCT_KhoaHoc[i]))
                {
                    listSearch.Add(listCT_KhoaHoc[i]);
                }
            }
        }
        if (GioHoc != "")
        {
            for (int i = 0; i < listCT_KhoaHoc.Count; i++)
            {
                if (listCT_KhoaHoc[i].GIOHOC.ToLongTimeString().Contains(GioHoc) && !listSearch.Contains(listCT_KhoaHoc[i]))
                {
                    listSearch.Add(listCT_KhoaHoc[i]);
                }
            }
        }
        if (GiangVien != "")
        {
            int maGV = QLGiangVien.FindKeyWord(GiangVien)[0].MAGV;

            for (int i = 0; i < listCT_KhoaHoc.Count; i++)
            {
                if (maGV == listCT_KhoaHoc[i].MAGV && !listSearch.Contains(listCT_KhoaHoc[i]))
                {
                    listSearch.Add(listCT_KhoaHoc[i]);
                }
            }
        }
        if (HocPhi != "")
        {

            for (int i = 0; i < listCT_KhoaHoc.Count; i++)
            {
                if (Double.Parse(HocPhi) >= listCT_KhoaHoc[i].HOCPHI && !listSearch.Contains(listCT_KhoaHoc[i]))
                {
                    listSearch.Add(listCT_KhoaHoc[i]);
                }
            }
        }

    }


    string LayMaCTKH(string maKH)
    {
        QLCT_KhoaHoc.GetAll();
        listCT_KhoaHoc = QLCT_KhoaHoc.listCT_KhoaHoc;
        for (int i = 0; i < listCT_KhoaHoc.Count; i++)
        {
            if (maKH == listCT_KhoaHoc[i].MAKH)
            {
                return listCT_KhoaHoc[i].MACTKH;
            }
        }
        return null;
    }

    public String TimTenGiangVien(int maGV)
    {

        for (int i = 0; i < listGiangVien.Count; i++)
        {
            if (maGV == listGiangVien[i].MAGV)
            {
                return listGiangVien[i].HOTEN;
            }
        }
        return null;
    }
    public String TimTenKhoaHoc(string maKH)
    {

        for (int i = 0; i < listKHOAHOC.Count; i++)
        {
            if (maKH == listKHOAHOC[i].MAKH)
            {
                return listKHOAHOC[i].TENKHOAHOC;
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