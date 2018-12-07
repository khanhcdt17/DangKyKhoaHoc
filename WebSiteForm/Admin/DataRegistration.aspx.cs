using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DataRegistration : System.Web.UI.Page
{
    public List<KETQUADANGKY> listKETQUADANGKY = new List<KETQUADANGKY>();
    private QLKetQuaDangKy QLKetQuaDangKy = new QLKetQuaDangKy();
    private KETQUADANGKY kqDK = new KETQUADANGKY();
    string kieu;

    protected void Page_Load(object sender, EventArgs e)
    {
        GetData();
        Response.Redirect("Chart.aspx");
    }
    void GetData()
    {

        NameValueCollection data = Request.Form;
        try
        {
            kqDK.MAKQ = int.Parse(data["MaKQ"]);
        }
        catch (Exception)
        {
            Response.Redirect("\\404.html");
            throw;
        }
        
        kqDK.MAHV = data["MaHV"];
        kqDK.MACTKH = data["MaCTKH"];
        kqDK.THOIGIANDK = data["ThoiGian"];
        kqDK.GHICHU = data["GhiChu"];
        kqDK.HINHTHUCDANGKY = data["HinhThuc"];

        string da = data["TrangThai"];

        if (data["Them"]!=null)
        {
            kieu = "them";
        }
        else if (data["Xoa"] != null)
        {
            kieu = "xoa";
        }
        else if (data["Sua"] != null)
        {
            kieu = "sua";
        }
        switch (kieu)
        {
            case "them":
                try
                {
                    QLKetQuaDangKy.Insert(kqDK);
                }
                catch (Exception)
                {
                    Response.Redirect("\\404.html");
                    throw;
                }
                break;
            case "xoa":
                try
                {
                    QLKetQuaDangKy.DeleteBy(kqDK.MAHV,kqDK.MACTKH);
                }
                catch (Exception)
                {
                    Response.Redirect("\\404.html");
                    throw;
                }
                break;
            case "sua":
                try
                {
                    QLKetQuaDangKy.Update(kqDK);
                }
                catch (Exception)
                {
                    Response.Redirect("\\404.html");
                    throw;
                }
                break;
            
        }
    }
}