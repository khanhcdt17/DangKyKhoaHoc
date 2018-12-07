using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

public partial class Login : System.Web.UI.Page
{
    QLTaiKhoan QLTaiKhoan = new QLTaiKhoan();

    protected void Page_Load(object sender, EventArgs e)
    {
        //string username = Request["username"];
        //string pass = Request["password"];
        //TaiKhoan taiKhoan = new TaiKhoan();
        //taiKhoan = QLTaiKhoan.SelectBy(username, "TENDANGNHAP")[0];
        //if (username == taiKhoan.TenDangNhap && pass == taiKhoan.MatKhau)
        //    Response.Redirect("~/Default.aspx?username="+username+",pass="+pass);
    }
}