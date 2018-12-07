<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="Course_About" %>

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
            <h3>Khóa học</h3>
        </div>
    </section>
    <!--  Page top end -->


    <!-- Search section -->
    <section class="multi-search-section">
        <div class="msf-warp">
            <div class="container">
                <h5>Tìm kiếm khóa học</h5>
                <form class="multi-search-form" method="post" action="Search.aspx">
                    <input type="text" placeholder="Khóa học" name="KhoaHoc">
                    <input type="text" placeholder="Ngày khai giảng dd/MM/yyyy" name="NgayKhaiGiang">
                    <input type="text" placeholder="Giờ học " name="GioHoc">
                    <input type="text" placeholder="Giảng viên" name="GiangVien">
                    <input type="text" placeholder="Học phí" name="HocPhi">
                    <button class="site-btn">Tìm kiếm <i class="fa fa-angle-right"></i></button>
                </form>
            </div>
        </div>
    </section>
    <!-- Search section end -->


    <!-- About section -->
    <section class="about-section spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-7 about-text">
                    <h3>Giới thiệu về trung tâm TT</h3>
                    <p>Sứ mạng của Trung Tâm TT: "Giúp ngày càng nhiều người đưa ứng dụng công nghệ thông tin vào
                        trong thực tế cuộc sống".Trung Tâm TT là một trung tâm tin học uy tín hoạt động trong lĩnh vực
                        đào tạo công nghệ thông tin đã hơn chục năm nay tại TP.Đà Lạt. Chúng tôi cam kết đảm bảo chất lượng đào tạo.
                        Học ở Trung Tâm TT thì phải làm được việc.Trung tâm TT cam kết cho học viên được học lại hoàn toàn MIỄN PHÍ 
                        khóa sau nếu khi kết thúc khóa học mà học viên chưa đạt được kết quả như mong muốn. Luôn có giờ giấc linh động cho học viên lựa chọn</p>
                    <p>Mặt khác: Trung tâm TT luôn có các chương trình ưu đãi để khuyến khích học viên khi đăng ký học và 
                        trong suốt quá trình học.
                    <p>Học ở TRUNG TÂM Tt bạn sẽ được đảm bảo chất lượng và phương pháp giảng dạy.</p>
                        <p>TRUNG TÂM TT – Luôn đặt lợi ích học viên lên hàng đầu. </p>
                    
                </div>
                <div class="col-lg-5">
                    <figure class="pt-lg-0 pt-5">
                        <img src="img/about.jpg" alt="">
                    </figure>
                </div>
            </div>
        </div>
    </section>
    <!-- About section end -->

    <!-- Pricing section -->
    <section class="pricing-section spad">
        <div class="container">
            <div class="sec-title text-center">
                <span>Thông tin tìm kiếm</span>
                <h2>Các khóa học</h2>
            </div>
            <!-- pricing switch -->
            <div class="pricing-switch-warp">
            </div>
            <!-- Monthly pricing charts -->
            <div class="mp-chart">
                <div class="row">
                    <%foreach (DataAccess.CT_KHOAHOC item in listCT_KhoaHoc)
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
