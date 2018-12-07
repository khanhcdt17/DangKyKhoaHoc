<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chart.aspx.cs" Inherits="Admin_Chart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!-- Required meta tags-->
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="au theme template" />
    <meta name="author" content="Nguyen Tinh" />
    <meta name="keywords" content="au theme template" />

    <!-- Title Page-->
    <title>Quản lý khóa học</title>
    <!-- Fontfaces CSS-->
    <link href="css/font-face.css" rel="stylesheet" media="all" />
    <link href="vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all" />
    <link href="vendor/font-awesome-5/css/fontawesome-all.min.css" rel="stylesheet" media="all" />
    <link href="vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all" />

    <!-- Bootstrap CSS-->
    <link href="vendor/bootstrap-4.1/bootstrap.min.css" rel="stylesheet" media="all" />

    <!-- Vendor CSS-->
    <link href="vendor/animsition/animsition.min.css" rel="stylesheet" media="all" />
    <link href="vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css" rel="stylesheet" media="all" />
    <link href="vendor/wow/animate.css" rel="stylesheet" media="all" />
    <link href="vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" media="all" />
    <link href="vendor/slick/slick.css" rel="stylesheet" media="all" />
    <link href="vendor/select2/select2.min.css" rel="stylesheet" media="all" />
    <link href="vendor/perfect-scrollbar/perfect-scrollbar.css" rel="stylesheet" media="all" />

    <!-- Main CSS-->
    <link href="css/theme.css" rel="stylesheet" media="all" />
</head>
<body>
    <script>
        function Check() {

            try {

                //pie chart
                var ctx = document.getElementById("pieChart");
                if (ctx) {
                    ctx.height = 200;
                    var myChart = new Chart(ctx, {
                        type: 'pie',
                        data: {
                            datasets: [{
                                data: [45, 25, 20, 10],
                                backgroundColor: [
                                    "rgba(0, 123, 255,0.9)",
                                    "rgba(0, 123, 255,0.7)",
                                    "rgba(0, 123, 255,0.5)",
                                    "rgba(0,0,0,0.07)"
                                ],
                                hoverBackgroundColor: [
                                    "rgba(0, 123, 255,0.9)",
                                    "rgba(0, 123, 255,0.7)",
                                    "rgba(0, 123, 255,0.5)",
                                    "rgba(0,0,0,0.07)"
                                ]

                            }],
                            labels: [
                                "Blue",
                                "Blue",
                                "Red"
                            ]
                        },
                        options: {
                            legend: {
                                position: 'top',
                                labels: {
                                    fontFamily: 'Poppins'
                                }

                            },
                            responsive: true
                        }
                    });
                }


            } catch (error) {
                console.log(error);
            }



        }

    </script>
    <div class="page-wrapper">
        <!-- HEADER MOBILE-->
        <header class="header-mobile d-block d-lg-none">
            <div class="header-mobile__bar">
                <div class="container-fluid">
                    <div class="header-mobile-inner">
                        <a class="logo" href="index.html">
                            <img src="images/icon/logo.png" alt="logo" />
                        </a>
                        <button class="hamburger hamburger--slider" type="button">
                            <span class="hamburger-box">
                                <span class="hamburger-inner"></span>
                            </span>
                        </button>
                    </div>
                </div>
            </div>
            <nav class="navbar-mobile">
                <div class="container-fluid">
                    <ul class="navbar-mobile__list list-unstyled">
                        <li class="has-sub">
                            <a class="js-arrow" href="#">
                                <i class="fas fa-book"></i>Quản lý khóa học</a>
                        </li>
                        <li>
                            <a href="chart.html">
                                <i class="fas fa-user"></i>Quản lý học viên</a>
                        </li>
                        <li>
                            <a href="Chart.aspx">
                                <i class="fas fa-edit"></i>Quản lý đăng ký khóa học</a>
                        </li>
                        <li>
                            <a href="Recepi.aspx">
                                <i class="fas fa-edit"></i>Quản lý hóa đơn</a>
                        </li>
                        <li>
                            <a href="form.html">
                                <i class="fas fa-newspaper"></i>Quản lý cổng thông tin</a>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>
        <!-- END HEADER MOBILE-->
        <!-- MENU SIDEBAR-->
        <aside class="menu-sidebar d-none d-lg-block">
            <div class="logo">
                <a href="#">
                    <img src="images/icon/logo.png" alt="logo" />
                </a>
            </div>
            <div class="menu-sidebar__content js-scrollbar1">
                <nav class="navbar-sidebar">
                    <ul class="list-unstyled navbar__list">
                        <li class="active has-sub">
                            <a class="js-arrow" href="#">
                                <i class="fas fa-book"></i>Quản lý khóa học</a>
                        </li>
                        <li>
                            <a href="chart.html">
                                <i class="fas fa-user"></i>Quản lý học viên</a>
                        </li>
                        <li>
                            <a href="Chart.aspx">
                                <i class="fas fa-edit"></i>Quản lý đăng ký khóa học</a>
                        </li>
                        <li>
                            <a href="Recepi.aspx">
                                <i class="fas fa-edit"></i>Quản lý hóa đơn</a>
                        </li>
                        <li>
                            <a href="form.html">
                                <i class="fas fa-newspaper"></i>Quản lý cổng thông tin</a>
                        </li>
                    </ul>
                </nav>
            </div>
        </aside>
        <!-- END MENU SIDEBAR-->
        <!-- PAGE CONTAINER-->
        <div class="page-container">
            <!-- HEADER DESKTOP-->
            <header class="header-desktop">
                <div class="section__content section__content--p30">
                    <div class="container-fluid">
                        <div class="header-wrap">
                            <form class="form-header" action="" method="post">
                                <input class="au-input au-input--xl" type="text" name="search" placeholder="Tìm kiếm &amp; truy xuất dữ liệu ..." />
                                <button class="au-btn--submit" type="submit">
                                    <i class="zmdi zmdi-search"></i>
                                </button>
                            </form>
                            <div class="header-button">
                                <div class="noti-wrap">
                                    <%-- Mail --%>
                                    <div class="noti__item js-item-menu">
                                        <i class="zmdi zmdi-email"></i>
                                        <span class="quantity">1</span>
                                        <div class="email-dropdown js-dropdown">
                                            <div class="email__title">
                                                <p>Bạn có 3 Email mới</p>
                                            </div>
                                            <div class="email__item">
                                                <div class="image img-cir img-40">
                                                    <img src="images/icon/avatar-06.jpg" alt="Cynthia Harvey" />
                                                </div>
                                                <div class="content">
                                                    <p>Cập nhật đăng ký học</p>
                                                    <span>Cynthia Harvey, 3 phút trước</span>
                                                </div>
                                            </div>
                                            <div class="email__item">
                                                <div class="image img-cir img-40">
                                                    <img src="images/icon/avatar-05.jpg" alt="Cynthia Harvey" />
                                                </div>
                                                <div class="content">
                                                    <p>Kiểm tra danh sách đăng ký khóa học</p>
                                                    <span>Cynthia Harvey, hôm qua</span>
                                                </div>
                                            </div>
                                            <div class="email__item">
                                                <div class="image img-cir img-40">
                                                    <img src="images/icon/avatar-04.jpg" alt="Cynthia Harvey" />
                                                </div>
                                                <div class="content">
                                                    <p>Thông báo kết quả khóa học</p>
                                                    <span>Cynthia Harvey, April 12,,2018</span>
                                                </div>
                                            </div>
                                            <div class="email__footer">
                                                <a href="#">Xem tất cả emails</a>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- End mail -->

                                    <%-- Notifications --%>
                                    <div class="noti__item js-item-menu">
                                        <i class="zmdi zmdi-notifications"></i>
                                        <span class="quantity">3</span>
                                        <div class="notifi-dropdown js-dropdown">
                                            <div class="notifi__title">
                                                <p>Bạn có 3 thông báo</p>
                                            </div>
                                            <div class="notifi__item">
                                                <div class="bg-c1 img-cir img-40">
                                                    <i class="zmdi zmdi-email-open"></i>
                                                </div>
                                                <div class="content">
                                                    <p>Bạn vừa nhận được 1 email</p>
                                                    <span class="date">April 12, 2018 06:50</span>
                                                </div>
                                            </div>
                                            <div class="notifi__item">
                                                <div class="bg-c2 img-cir img-40">
                                                    <i class="zmdi zmdi-account-box"></i>
                                                </div>
                                                <div class="content">
                                                    <p>Tài khoản của bạn đã bị khóa</p>
                                                    <span class="date">April 12, 2018 06:50</span>
                                                </div>
                                            </div>
                                            <div class="notifi__item">
                                                <div class="bg-c3 img-cir img-40">
                                                    <i class="zmdi zmdi-file-text"></i>
                                                </div>
                                                <div class="content">
                                                    <p>You got a new file</p>
                                                    <span class="date">April 12, 2018 06:50</span>
                                                </div>
                                            </div>
                                            <div class="notifi__footer">
                                                <a href="#">Tất cả thông báo</a>
                                            </div>
                                        </div>
                                    </div>
                                    <%-- End Notifications --%>
                                </div>
                                <%-- User --%>
                                <div class="account-wrap">
                                    <div class="account-item clearfix js-item-menu">
                                        <div class="image">
                                            <img src="images/icon/avatar-01.jpg" alt="John Doe" />
                                        </div>
                                        <div class="content">
                                            <a class="js-acc-btn" href="#">Nguyễn Tĩnh</a>
                                        </div>
                                        <div class="account-dropdown js-dropdown">
                                            <div class="info clearfix">
                                                <div class="image">
                                                    <a href="#">
                                                        <img src="images/icon/avatar-01.jpg" alt="John Doe" />
                                                    </a>
                                                </div>
                                                <div class="content">
                                                    <h5 class="name">
                                                        <a href="#">nguyentinh</a>
                                                    </h5>
                                                    <span class="email">nguyentinh@gmail.com</span>
                                                </div>
                                            </div>
                                            <div class="account-dropdown__body">
                                                <div class="account-dropdown__item">
                                                    <a href="#">
                                                        <i class="zmdi zmdi-account"></i>Tài khoản</a>
                                                </div>
                                                <div class="account-dropdown__item">
                                                    <a href="#">
                                                        <i class="zmdi zmdi-settings"></i>Cài đặt</a>
                                                </div>
                                            </div>
                                            <div class="account-dropdown__footer">
                                                <a href="#">
                                                    <i class="zmdi zmdi-power"></i>Đăng xuất</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <%-- End user --%>
                            </div>
                        </div>
                    </div>
                </div>
            </header>
            <!-- HEADER DESKTOP-->

            <!-- MAIN CONTENT-->
            <div class="main-content">
                <div class="section__content section__content--p30">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-lg-6">
                                <div class="au-card m-b-30">
                                    <div class="au-card-inner">
                                        <h3 class="title-2 m-b-40">Học viên đăng ký</h3>
                                        <canvas id="sales-chart"></canvas>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6">
                                <div class="au-card m-b-30">
                                    <div class="au-card-inner">
                                        <h3 class="title-2 m-b-40">Thống kê theo khóa học</h3>
                                        <canvas id="pieChart"></canvas>
                                    </div>
                                </div>
                            </div>



                            <div class="col-md-12">
                                <!-- DATA TABLE -->
                                <h3 class="title-5 m-b-35" style="text-align: center">Kết quả đăng ký</h3>



                                <div class="table-responsive table-responsive-data2">
                                    <table class="table table-data2">
                                        <thead>
                                            <tr>

                                                <th style="padding-left: 20px">Mã KQ</th>
                                                <th style="padding-left: 20px">Mã HV</th>
                                                <th style="padding-left: 20px">Mã CTKH</th>
                                                <th style="padding-left: 20px">Thời Gian DK</th>
                                                <th style="padding-left: 20px">Ghi chú</th>
                                                <th style="padding-left: 20px">Hình thức</th>
                                                <th style="padding-left: 20px">Trạng thái</th>

                                            </tr>
                                            <%-- <tr>

                                                    <th style="padding-left:20px"><input name="MaKQ" id="MaKQ" style="height:30px;max-width:50px"/></th>
                                                    <th style="padding-left:20px"><input name="MaHV" id="MaHV" style="height:30px;max-width:50px"/></th>
                                                    <th style="padding-left:20px"><input name="MaCTKH" id="MaCTKH" style="height:30px;max-width:70px"/></th>
                                                    <th style="padding-left:20px"><input name="ThoiGian" id="ThoiGian" style="height:30px;max-width:100px"/></th>
                                                    <th style="padding-left:20px"><input name="GhiChu" id="GhiChu" style="height:30px;max-width:70px"/></th>
                                                    <th style="padding-left:25px"><input name="HinhThuc" id="HinhThuc" style="height:30px;max-width:70px"/></th>
                                                    <th style="padding-left:20px"><input name="TrangThai" id="TrangThai" style="height:30px;max-width:70px"/></th>

                                                </tr>--%>
                                        </thead>
                                        <%if (listKETQUADANGKY.Count == 0)
                                            {%>
                                        <form action="DataRegistration.aspx" method="post">
                                            <div>
                                                <tr class="tr-shadow">

                                                    <td>
                                                        <input name="MaKQ" style="height: 30px; max-width: 50px" /></td>
                                                    <td>
                                                        <input name="MaHV" style="height: 30px; max-width: 50px" />
                                                    </td>
                                                    <td>
                                                        <input name="MaCTKH" style="height: 30px; max-width: 50px" /></td>
                                                    <td>
                                                        <input name="ThoiGian" style="height: 30px; max-width: 70px" />
                                                    </td>
                                                    <td>
                                                        <input name="GhiChu" style="height: 30px; max-width: 100px" />
                                                    </td>
                                                    <td>
                                                        <input name="HinhThuc" style="height: 30px; max-width: 50px" />
                                                    </td>
                                                    <td>
                                                        <input name="TrangThai" style="height: 30px; max-width: 50px" /></td>
                                                    <td>
                                                        <div class="table-data-feature">
                                                            <button class="item" type="submit" title="Thêm" name="Them" value="Them">
                                                                <i class="zmdi zmdi-mail-send"></i>
                                                            </button>
                                                            <button class="item" type="submit" title="Sửa" name="Sua" value="Sua">
                                                                <i class="zmdi zmdi-edit"></i>
                                                            </button>
                                                            <button class="item" type="submit" title="Xóa" name="Xoa" value="Xoa">
                                                                <i class="zmdi zmdi-delete"></i>
                                                            </button>

                                                        </div>
                                                    </td>

                                                </tr>

                                            </div>
                                        </form>
                                        <% } %>

                                        <%foreach (DataAccess.KETQUADANGKY item in listKETQUADANGKY)
                                            { %>
                                        <form action="DataRegistration.aspx" method="post">
                                            <div>
                                                <tr class="tr-shadow">

                                                    <td>
                                                        <input name="MaKQ" value="<%=item.MAKQ %>" style="height: 30px; max-width: 50px" /></td>
                                                    <td>
                                                        <input name="MaHV" value="<%=item.MAHV %> " style="height: 30px; max-width: 50px" />
                                                    </td>
                                                    <td>
                                                        <input name="MaCTKH" value="<%=item.MACTKH %>" style="height: 30px; max-width: 50px" /></td>
                                                    <td>
                                                        <input name="ThoiGian" value="<%=item.THOIGIANDK %>" style="height: 30px; max-width: 70px" />
                                                    </td>
                                                    <td>
                                                        <input name="GhiChu" value="<%=item.GHICHU %>" style="height: 30px; max-width: 100px" />
                                                    </td>
                                                    <td>
                                                        <input name="HinhThuc" value="<%=item.HINHTHUCDANGKY %>" style="height: 30px; max-width: 50px" />
                                                    </td>
                                                    <td>
                                                        <input name="TrangThai" value="<%=item.TRANGTHAI %>" style="height: 30px; max-width: 50px" /></td>
                                                    <td>
                                                        <div class="table-data-feature">
                                                            <button class="item" type="submit" title="Thêm" name="Them" value="Them">
                                                                <i class="zmdi zmdi-mail-send"></i>
                                                            </button>
                                                            <button class="item" type="submit" title="Sửa" name="Sua" value="Sua">
                                                                <i class="zmdi zmdi-edit"></i>
                                                            </button>
                                                            <button class="item" type="submit" title="Xóa" name="Xoa" value="Xoa">
                                                                <i class="zmdi zmdi-delete"></i>
                                                            </button>
                                                            <input hidden value="<%=item.MAKQ %>" name="outCourse" />
                                                        </div>
                                                    </td>

                                                </tr>

                                            </div>

                                        </form>
                                        <% } %>
                                    </table>
                                </div>

                                <!-- END DATA TABLE -->
                            </div>


                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <div class="copyright">
                                    <p>Copyright © 2018 Colorlib. All rights reserved. Template by <a href="https://colorlib.com">Colorlib</a>.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- END MAIN CONTENT-->
            <!-- END PAGE CONTAINER-->
        </div>

    </div>
    <!-- Jquery JS-->
    <script src="vendor/jquery-3.2.1.min.js"></script>
    <!-- Bootstrap JS-->
    <script src="vendor/bootstrap-4.1/popper.min.js"></script>
    <script src="vendor/bootstrap-4.1/bootstrap.min.js"></script>
    <!-- Vendor JS       -->
    <script src="vendor/slick/slick.min.js">
    </script>
    <script src="vendor/wow/wow.min.js"></script>
    <script src="vendor/animsition/animsition.min.js"></script>
    <script src="vendor/bootstrap-progressbar/bootstrap-progressbar.min.js">
    </script>
    <script src="vendor/counter-up/jquery.waypoints.min.js"></script>
    <script src="vendor/counter-up/jquery.counterup.min.js">
    </script>
    <script src="vendor/circle-progress/circle-progress.min.js"></script>
    <script src="vendor/perfect-scrollbar/perfect-scrollbar.js"></script>
    <script src="vendor/chartjs/Chart.bundle.min.js"></script>
    <script src="vendor/select2/select2.min.js">
    </script>

    <!-- Main JS-->
    <script src="js/main.js"></script>

</body>
</html>
