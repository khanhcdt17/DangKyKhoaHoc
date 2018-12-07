using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Chart : System.Web.UI.Page
{
    public List<KETQUADANGKY> listKETQUADANGKY = new List<KETQUADANGKY>();
    private QLKetQuaDangKy QLKetQuaDangKy = new QLKetQuaDangKy();

    protected void Page_Load(object sender, EventArgs e)
    {
        QLKetQuaDangKy.GetAll();
        listKETQUADANGKY = QLKetQuaDangKy.listKETQUADANGKY;
    }
}