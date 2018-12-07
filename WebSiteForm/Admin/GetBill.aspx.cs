using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_GetBill : System.Web.UI.Page
{

    public List<BIENLAI> listBIENLAI = new List<BIENLAI>();
    private QLBienLai QLBienLai = new QLBienLai();

    BIENLAI bill = new BIENLAI();
        
    protected void Page_Load(object sender, EventArgs e)
    {
        GetData();
        try
        {
            QLBienLai.Insert(bill);
        }
        catch (Exception)
        {
            Response.Redirect("\\404.html");
            throw;
        }
        Response.Redirect("Recepi.aspx");
    }
    void GetData()
    {

        NameValueCollection data = Request.Form;
        bill.MAHV = data["MaHocVien"];
        bill.MACTKH = data["MaKhoaHoc"];
        bill.NGUOINOP = data["TenNguoiNop"];
        bill.LYDO = data["LyDo"];
        bill.NGUOITHU = data["NguoiThu"];
        if (data["MienGiamHocPhi"] != "")
        {
            bill.MIENGIAMHOCPHI = long.Parse(data["MienGiamHocPhi"]);
        }
        else
            bill.MIENGIAMHOCPHI = 0;


        bill.LYDOMIENGIAM = data["LyDoMienGiam"];
        bill.NgayNop = DateTime.Now.ToShortDateString();
        bill.NgayNop = data["NgayNop"];
        bill.MABL = LayMaBL();
    }
    string LayMaBL()
    {
        QLBienLai.GetAll();
        listBIENLAI = QLBienLai.listBienLai;
        int maBL = listBIENLAI.Count;
        while (true)
        {
            if (QLBienLai.SelectByID(maBL.ToString()).Count == 0)
            {
                return maBL.ToString();
            }
            else
            {
                maBL++;
            }
        }
    }
}