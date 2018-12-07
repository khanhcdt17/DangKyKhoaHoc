<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Regis.aspx.cs" Inherits="Registration_Regis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    
    <!-- Required meta tags-->
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="Colorlib Templates" />
    <meta name="author" content="Colorlib" />
    <meta name="keywords" content="Colorlib Templates" />

    <!-- Title Page-->
    <title>Đăng ký</title>

    <!-- Icons font CSS-->
    <link href="vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all" />
    <link href="vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all" />
    <!-- Font special for pages-->
    <link href="https://fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet" />

    <!-- Vendor CSS-->
    <link href="vendor/select2/select2.min.css" rel="stylesheet" media="all" />
    <link href="vendor/datepicker/daterangepicker.css" rel="stylesheet" media="all" />

    <!-- Main CSS-->
    <link href="css/main.css" rel="stylesheet" media="all" />
</head>

<body>
    <script>
        function Check() {
            var ten = document.getElementById('ten').value;
            var email = document.getElementById("email").value;
            var addr = document.getElementById("addr").value;
            var bd = document.getElementById("birthday").value;
            var phone = document.getElementById("phone").value;

            if (ten == '' || email == '' || addr == '' || bd == '' || phone == '') {
                alert("Bạn chưa nhập đủ thông tin!");
                return false;
            }
            else {
                alert("Đăng ký thành công!");
                return true;
            }
        } 

    </script>
    <div class="page-wrapper bg-gra-02 p-t-130 p-b-100 font-poppins">
        
        <div class="wrapper wrapper--w680">
            <div class="card card-4">
                <div class="card-body">
                    <h2 class="title">Đăng ký khóa học</h2>
                    <form action="GetData.aspx" method="post" onsubmit="return Check()">
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Họ và tên</label>
                                    <input class="input--style-4" type="text" name="name" id="ten" />
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Địa chỉ</label>
                                    <input class="input--style-4" type="text" name="address" id="addr"/>
                                </div>
                            </div>
                        </div>
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Ngày sinh</label>
                                    <div class="input-group-icon">
                                        <input class="input--style-4 js-datepicker" type="text" name="birthday" id="birthday"/>
                                        <i class="zmdi zmdi-calendar-note input-icon js-btn-calendar"></i>
                                    </div>
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Giới tính</label>
                                    <div class="p-t-10">
                                        <label class="radio-container m-r-45">
                                            Nam
                                            <input type="radio" checked="checked" name="gender" value="men" />
                                            <span class="checkmark"></span>
                                        </label>
                                        <label class="radio-container">
                                            Nữ
                                            <input type="radio" name="gender" value="women" />
                                            <span class="checkmark"></span>
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Email</label>
                                    <input class="input--style-4" type="email" name="email" id="email"/>
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                    <label class="label">Số điện thoại</label>
                                    <input class="input--style-4" type="text" name="phone" id="phone" />
                                </div>
                            </div>
                        </div>
                        <div class="input-group">
                            <label class="label">Khóa học</label>
                            <div class="rs-select2 js-select-simple select--no-search">
                                <select name="subject">
                                    <option disabled="disabled" selected="selected">Chọn khóa học</option>
                                    <% 
                                        foreach (DataAccess.KHOAHOC item in listKhoaHoc)
                                        {%>
                                    <option><%=item.TENKHOAHOC%></option>

                                    <%} %>
                                </select>
                                <div class="select-dropdown"></div>
                            </div>
                        </div>
                        <div class="p-t-15">
                            <button class="btn btn--radius-2 btn--blue" type="submit" >Gửi</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <!-- Jquery JS-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <!-- Vendor JS-->
    <script src="vendor/select2/select2.min.js"></script>
    <script src="vendor/datepicker/moment.min.js"></script>
    <script src="vendor/datepicker/daterangepicker.js"></script>

    <!-- Main JS-->
    <script src="js/global.js"></script>

</body>
<!-- This templates was made by Colorlib (https://colorlib.com) -->

</html>
