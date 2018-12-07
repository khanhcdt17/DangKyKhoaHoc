using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

public partial class Admin_TaiKhoan : System.Web.UI.Page
{
    public List<TAIKHOAN> taiKhoans = new List<TAIKHOAN>();
    private QLTaiKhoan QLTaiKhoan = new QLTaiKhoan();
    protected void Page_Load(object sender, EventArgs e)
    {
        QLTaiKhoan.GetAll();
        taiKhoans = QLTaiKhoan.listTAIKHOAN;
    }
}