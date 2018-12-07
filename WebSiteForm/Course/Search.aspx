<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Course_About" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <title>Đăng ký khóa học</title>
    <meta charset="UTF-8">
    <meta name="description" content="Academica Learning Page Template">
    <meta name="keywords" content="academica, unica, creative, html">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <!-- Favicon -->
    <link href="img/favicon.ico" rel="shortcut icon" />

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Raleway:400,400i,500,500i,600,600i,700,700i,800" rel="stylesheet">

    <!-- Stylesheets -->
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/font-awesome.min.css" />
    <link rel="stylesheet" href="css/flaticon.css" />
    <link rel="stylesheet" href="css/owl.carousel.css" />
    <link rel="stylesheet" href="css/style.css" />


    <!--[if lt IE 9]>
	  <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
	  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
	<![endif]-->

</head>
<body style="font-family: Tahoma">
    <script>
        function Check() {

            alert("Đăng ký thành công!");

        }
        

    </script>
    <!-- Page Preloder -->
    <div id="preloder">
        <div class="loader"></div>
    </div>

    <!-- Header section -->
    <header class="header-section">
        <div class="header-warp">
            <div class="container">
                <a href="#" class="site-logo">
                    <img style="max-width: 10%" src="img/logodlu.png" alt="">
                </a>
                <div class="user-panel">
                    <!--<a href="#">Login</a><span>/</span><a href="">Register</a>-->
                </div>
                <div class="nav-switch">
                    <i class="fa fa-bars"></i>
                </div>
                <ul class="main-menu">
                    <li><a href="Index.aspx">Trang chủ</a></li>
                    <li><a href="About.aspx">Khóa học</a></li>
                    <li><a href="\Registration/Regis.aspx" target="_blank">Học viên đăng ký</a></li>
                    <!--<li><a href="blog.html">News</a></li>
					<li><a href="contact.html">Contact</a></li>-->
                </ul>
            </div>
        </div>
    </header>
    <!-- Header section end -->


    <!-- Page top section -->
    <section class="page-top-section set-bg" data-setbg="img/page-top-bg.jpg">
        <div class="container text-white">
            <h3>Tìm kiếm khóa học</h3>
        </div>
    </section>
    <!--  Page top end -->



    <!-- Pricing section -->
    <section class="pricing-section spad">
        <div class="container">
            <div class="sec-title text-center">
                <span>Thông tin tìm kiếm</span>
                <h2>Các khóa học tìm được:</h2>
            </div>
            <!-- pricing switch -->
            <div class="pricing-switch-warp">
            </div>
            <!-- Monthly pricing charts -->
            <div class="mp-chart">
                <div class="row">
                    <%foreach (DataAccess.CT_KHOAHOC item in listSearch)
                        {%>
                    <div class="col-lg-3 col-md-6">
                        <div class="pricing-chart pc-populer" style="margin-top: 15px; height: 450px">
                            <div class="offer-info">Thông tin khóa học</div>
                            <h2 style="padding-top: 50px"><%=TimTenKhoaHoc(item.MAKH) %></h2>
                            <p>Giảng viên: <%=TimTenGiangVien(item.MAGV) %></p>
                            <!--<h4>Regular</h4>-->
                            <ul>
                                <li>Ngày khai giảng: <%=NgayKhaiGiang(item.NGAYKHAIGIANG) %></li>
                                <li>Học phí: <%=item.HOCPHI%> Đồng</li>
                                <li>Giờ học: <%=item.GIOHOC.Hour%> giờ <%=item.GIOHOC.Minute%> phút</li>
                                <li>Phòng: <%=item.TENPHONG %></li>
                                <li></li>
                                <li>
                                    <!--<img src="img/icons/check.png" alt="">-->
                                </li>
                            </ul>
                            <form method="post" action="GetDataViaUser.aspx" onsubmit="return Check()">
                                <input hidden value="<%=item.MACTKH %>" name="outData" />
                                <button style="background-color: #0056b3;" type="submit">Đăng ký</button>
                                <%--<a href="#" class="site-btn">Đăng ký <i class="fa fa-angle-right"></i></a>--%>
                            </form>

                        </div>
                    </div>
                    <%} %>
                </div>
            </div>
            <!-- Annual pricing charts -->
        </div>
    </section>
    <!-- Pricing section end -->


    <!-- Footer section -->
    <footer class="footer-section spad pb-0">
        <div class="container">
            <div class="text-center">
                <a href="#" class="site-btn">Quay về trang đầu <i class="fa fa-angle-right"></i></a>
            </div>
            <div class="row text-white spad">
                <div class="col-lg-3 col-sm-6 footer-widget">
                    <h4>Số 1 Phù Đổng Thiên Vương, Phường 8, Đà Lạt, Lâm Đồng.</h4>

                </div>
                <div class="col-lg-3 col-sm-6 footer-widget">
                    <h4>LH: 02633382246</h4>

                </div>

                <div class="col-lg-3 col-sm-6 footer-widget">
                    <h4>Email: info@dlu.edu.vn</h4>

                </div>
                <div class="col-lg-3 col-sm-6 footer-widget">
                    <h4>Website: dlu.edu.vn</h4>

                </div>
            </div>
            <div class="footer-bottom">

                <div class="social">
                    <a href=""><i class="fa fa-pinterest"></i></a>
                    <a href=""><i class="fa fa-facebook"></i></a>
                    <a href=""><i class="fa fa-twitter"></i></a>
                    <a href=""><i class="fa fa-dribbble"></i></a>
                    <a href=""><i class="fa fa-behance"></i></a>
                    <a href=""><i class="fa fa-linkedin"></i></a>
                    <a href=""></a>
                </div>
                <ul class="footer-menu">
                    <li><a href="#">Trang chủ</a></li>
                    <li><a href="#">Khóa học</a></li>
                    <li><a href="#">Học viên đăng ký</a></li>

                </ul>

            </div>

            <div class="row">
                <div class="col-12">
                    <p class="text-white  text-center">
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        Copyright &copy; 2018
					
						<!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </p>
                </div>

            </div>
        </div>



    </footer>
    <!-- Footer section end -->


    <!--====== Javascripts & Jquery ======-->
    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/circle-progress.min.js"></script>
    <script src="js/main.js"></script>


</body>
</html>
