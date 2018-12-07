using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Recepi : System.Web.UI.Page
{

    public List<BIENLAI> bienlais = new List<BIENLAI>();
    private QLBienLai qLBienLai = new QLBienLai();

    public List<CT_KHOAHOC> listCT_KHOAHOC = new List<CT_KHOAHOC>();
    private QLCT_KhoaHoc QLCT_KhoaHoc = new QLCT_KhoaHoc();

    protected void Page_Load(object sender, EventArgs e)
    {
        qLBienLai.GetAll();
        bienlais = qLBienLai.listBienLai;
    }
    public double LayTien(string maCTKH)
    {
        return QLCT_KhoaHoc.SelectByID(maCTKH)[0].HOCPHI;
        
    }
}