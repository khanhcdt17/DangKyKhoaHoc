using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration_Regis : System.Web.UI.Page
{
    public List<KHOAHOC> listKhoaHoc = new List<KHOAHOC>();
    private QLKhoaHoc QLKhoaHoc = new QLKhoaHoc();
    private QLHocVien QLHocVien = new QLHocVien();
    private HOCVIEN hocVien = new HOCVIEN();


    protected void Page_Load(object sender, EventArgs e)
    {
        QLKhoaHoc.GetAll();
        listKhoaHoc = QLKhoaHoc.listKHOAHOC;

       
    }
   
    
}