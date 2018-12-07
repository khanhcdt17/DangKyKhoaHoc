using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Course_GetDataViaUser : System.Web.UI.Page
{
    public List<HOCVIEN> listHOCVIEN = new List<HOCVIEN>();
    private QLHocVien QLHocVien = new QLHocVien();
    public HOCVIEN hocVien = new HOCVIEN();

    public List<TAIKHOAN> listTAIKHOAN = new List<TAIKHOAN>();
    private QLTaiKhoan QLTaiKhoan = new QLTaiKhoan();

    public List<KETQUADANGKY> listKETQUADANGKYN = new List<KETQUADANGKY>();
    private QLKetQuaDangKy QLKetQuaDangKy = new QLKetQuaDangKy();

    public List<KHOAHOC> listKHOAHOC = new List<KHOAHOC>();
    private QLKhoaHoc QLKhoaHoc = new QLKhoaHoc();

    public List<CT_KHOAHOC> listCT_KhoaHoc = new List<CT_KHOAHOC>();
    private QLCT_KhoaHoc QLCT_KhoaHoc = new QLCT_KhoaHoc();

    public List<KETQUAHOC> listKETQUAHOC = new List<KETQUAHOC>();
    private QLKetQuaHoc QLKetQuaHoc = new QLKetQuaHoc();

    string maCTKH;

    protected void Page_Load(object sender, EventArgs e)
    {
        QLHocVien.GetAll();
        listHOCVIEN = QLHocVien.listHOCVIEN;
        hocVien = listHOCVIEN[1];

        GetData();
        int maKQ = LayMaKQ();
        KETQUAHOC kqHoc = new KETQUAHOC(maKQ, 0, "", false, "Chưa học", true);
        try
        {
            QLKetQuaHoc.Insert(kqHoc);
            string time = DateTime.Now.ToString().Replace("/","");
            KETQUADANGKY kqdk = new KETQUADANGKY(maKQ, hocVien.MAHV, maCTKH, time, "", "Online", true);
            QLKetQuaDangKy.Insert(kqdk);
           
        }
        catch (Exception)
        {
            Response.Redirect("\\404.html");
            
        }


        Response.Redirect("Index.aspx");
    }
    void GetData()
    {
        NameValueCollection data = Request.Form;
        maCTKH = data["outData"];
        
    }
    int LayMaKQ()
    {
        QLKetQuaHoc.GetAll();
        listKETQUAHOC = QLKetQuaHoc.listKETQUAHOC;
        int maKQ = listKETQUAHOC.Count;
        while (true)
        {
            if (QLKetQuaHoc.SelectByID(maKQ).Count == 0)
            {
                return maKQ;
            }
            else
            {
                maKQ++;
            }
        }
    }
}