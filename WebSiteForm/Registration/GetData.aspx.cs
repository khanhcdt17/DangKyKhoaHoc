using DataAccess;
using DataAccess.QuanLyDoiTuong;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration_GetData : System.Web.UI.Page
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

    //public string TebTaiKhoan;

    string maCTKH;

    protected void Page_Load(object sender, EventArgs e)
    {
        QLTaiKhoan.GetAll();
        listTAIKHOAN = QLTaiKhoan.listTAIKHOAN;

        GetData();

        int maKQ = LayMaKQ();
        KETQUAHOC kqHoc = new KETQUAHOC(maKQ, 0,"", false, "Chưa học", true);
        try
        {
            QLKetQuaHoc.Insert(kqHoc);
            string time = DateTime.Now.ToString().Replace("/", "");
            KETQUADANGKY kqdk = new KETQUADANGKY(maKQ, hocVien.MAHV, maCTKH, time, "", "Online", true);
            QLKetQuaDangKy.Insert(kqdk);
         
        }
        catch (Exception)
        {
            Response.Redirect("\\404.html");
        
        }

       // SendEmail("Test", "caodothinhkhanh@gmail.com", "test");
        Response.Redirect("Regis.aspx");
    }
    bool GetData()
    {
        NameValueCollection data = Request.Form;
        hocVien.HOTEN = data["name"];
        hocVien.DIACHI = data["address"];
        hocVien.NGAYSINH = data["birthday"];
        hocVien.GIOITINH = false;
        hocVien.GIOITINH = data["gender"] == "men";

        hocVien.E_MAIL = data["email"];
        hocVien.SODIENTHOAI = data["phone"];
        string tenKhoaHoc = data["subject"];
        string maKH=  QLKhoaHoc.FindKeyWord(tenKhoaHoc)[0].MAKH;

        maCTKH = LayMaCTKH(maKH);

        string ten = convertToUnSign3(hocVien.HOTEN);
        int chieuDai = ten.Split(' ').Length;
        //string username = ten.Split(' ')[chieuDai - 2] + ten.Split(' ')[chieuDai - 1]+listTAIKHOAN.Count.ToString();
        string username = ten.Replace(" ","") + listTAIKHOAN.Count.ToString();
        while (true)
        {
            TAIKHOAN tk = new TAIKHOAN(username, "123456", hocVien.E_MAIL, "HV", "", true);
            int i = 0;
            if (QLTaiKhoan.Insert(tk))
            {
                break;
            }
            else
            {
                username += i;
                i++;
            }

        }
        //TebTaiKhoan = username;
        hocVien.MATK = QLTaiKhoan.FindKeyWord(username)[0].MATK;
        hocVien.MAHV = LayMaHV();
        //if (1 > 0)
        //    Response.Redirect("DangKyOK.aspx");
        return QLHocVien.Insert(hocVien);
    }
    public static string convertToUnSign3(string s)
    {
        Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
        string temp = s.Normalize(NormalizationForm.FormD);
        return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
    }
    string LayMaHV()
    {
        QLHocVien.GetAll();
        listHOCVIEN = QLHocVien.listHOCVIEN;
        int maHV = listHOCVIEN.Count;
        while (true)
        {
            if (QLHocVien.SelectByID(maHV.ToString()).Count==0)
            {
                return maHV.ToString();
            }
            else
            {
                maHV++;
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
    [HttpPost]
    public JsonResult SendEmail(string _name, string _email, string _description)
    {
        string senderID = "cao.khanh.1997@gmal.com";
        string senderPassword = "";
        string result = "Email Sent Successfully";

        string body ="Gửi "+_name+ " Thông báo từ trung tâm thông tin thư viện đến " + _email;
        
        body +=" "+ _description;
        try
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(senderID);
            mail.From = new MailAddress(senderID);
            mail.Subject = "Thông báo đăng ký khóa học!";
            mail.Body = body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Credentials = new System.Net.NetworkCredential(senderID, senderPassword);
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
        catch (Exception ex)
        {
            result = "problem occurred";
            Response.Write("Exception in sendEmail:" + ex.Message);
        }
        return JsonResult(result);
    }

    private JsonResult JsonResult(string result)
    {
        throw new NotImplementedException();
    }
}