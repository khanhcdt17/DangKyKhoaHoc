using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Course_Index : System.Web.UI.Page
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

    public String TimTenGiangVien(string maKH)
    {
        int maGV;
        try
        {
            CT_KHOAHOC ctKhoaHoc = QLCT_KhoaHoc.FindKeyWord(maKH)[0];
            maGV = ctKhoaHoc.MAGV;

            for (int i = 0; i < listGiangVien.Count; i++)
            {
                if (maGV == listGiangVien[i].MAGV)
                {
                    return listGiangVien[i].HOTEN;

                }
            }
        }
        catch (Exception)
        {
            Response.Redirect("\\404.html");
            return null;
        }
       

        return null;
    }
}