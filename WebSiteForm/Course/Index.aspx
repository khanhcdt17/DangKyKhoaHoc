<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Course_Index" %>

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
<body>
    <!-- Page Preloder -->
    <div id="preloder">
        <div class="loader"></div>
    </div>

    <!-- Header section -->
    <header class="header-section">
        <div class="header-warp">
            <div class="container">
                <a href="Index.aspx" class="site-logo">
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


    <!-- Hero section -->
    <section class="hero-section set-bg" data-setbg="img/aa.jpg">
        <div class="container">
            <div class="row">
                <div class="col-lg-7">
                    <div class="hero-text text-white">
                        <h2>Trung tâm TT</h2>
                        <p>
                            Trung tâm TT là một trung tâm có chất lượng tại vùng Tây Nguyên,
						có trụ sở tại thành phố Đà Lạt.
						Trung tâm TT có thế mạnh đào tạo nhóm khóa học về ngành công nghệ thông tin.
						Các khóa học được giảng dạy với đội ngũ giảng viên đạt trình độ từ
						Ths trở lên và một số giảng viên người nước ngoài.
                        </p>
                        <div class="hero-author">
                            <div class="hero-author-pic set-bg" data-setbg="img/ThayHiep.jpg"></div>
                            <h5>Người sáng lập: <span>Nguyễn Minh Hiệp</span></h5>
                            <a href="#" class="site-btn">Xem thêm... <i class="fa fa-angle-right"></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Hero section end -->


    <!-- Search section -->
    <section class="multi-search-section">
        <div class="msf-warp">
            <div class="container">
                <h5>Tìm kiếm khóa học</h5>
                <form class="multi-search-form" method="post" action="Search.aspx">
                    <input type="text" placeholder="Khóa học" name="KhoaHoc">
                    <input type="text" placeholder="Ngày khai giảng" name="NgayKhaiGiang">
                    <input type="text" placeholder="Giờ học" name="GioHoc">
                    <input type="text" placeholder="Giảng viên" name="GiangVien">
                    <input type="text" placeholder="Học phí" name="HocPhi">
                    <button class="site-btn">Tìm kiếm <i class="fa fa-angle-right"></i></button>
                </form>


            </div>
        </div>
    </section>
    <!-- Search section end -->


    <!-- Services section -->
    <!--<section class="services-section spad">
		
	</section>-->
    <!-- Services section end -->


    <!-- Review section -->
    <section class="review-section spad set-bg" data-setbg="img/review-bg.jpg">

        <div class="row">
            <div class="col-lg-10 offset-lg-1">
                <div class="review-slider owl-carousel text-white">
                    <%foreach (DataAccess.GIANGVIEN item in listGiangVien)
                        {%>
                    <div class="rs-item">

                        <!--<div class="quota">“</div>-->
                        <h2>Thông tin giảng viên</h2>
                        <br>
                        <!--<span>our students</span>-->
                        <div class="review-avator set-bg" data-setbg="img/hinhdemo.jpg"></div>
                        <h6><%=item.TRINHDO %> <span><%=item.HOTEN %></span></h6>
                        <h5>Thông tin cơ bản</h5>
                        <p>Giảng viên <%=item.HOTEN %> sinh năm <%=item.NGAYSINH.Substring(4) %> đã tốt nghiệp <%=item.TRINHDO %> và là người có nhiều năm kinh nghiệm trên bục giảng về chuyên nghành về kỹ thuật phần mềm, thông tin liên hệ: <%=item.E_MAIL %>.</p>

                    </div>

                    <%} %>
                </div>
            </div>
        </div>

    </section>
    <!-- Review section end -->


    <!-- Courses section  -->
    <section class="courses-section spad">
        <div class="container">
            <div class="sec-title text-center">
                <!--<span>Only  the best</span>-->
                <h2>Các khóa học</h2>
            </div>

            <div class="course-slider owl-carousel">
                <!-- course -->
                <%foreach (DataAccess.KHOAHOC item in listKhoaHoc)
                    {%>
                <div class="course-item">
                    <figure class="course-preview">
                        <img src="img/courses/TQ.jpg" alt="">
                    </figure>
                    <div class="course-content">
                        <div class="cc-text">

                            <h5><a href="#">Tên khóa học: <%=item.TENKHOAHOC %></a></h5>
                            <ul>
                                <li>Mô tả: <%=item.MOTA %></li>
                                <li>Thời gian: <%=item.THOIGIAN%> tháng</li>
                                <li>Nội dung: <%=item.NOIDUNG %></li>

                            </ul>

                        </div>

                        <div class="seller-info">
                            <div class="seller-pic set-bg"></div>
                            <h6>Giảng viên: <span><%=TimTenGiangVien(item.MAKH) %></span></h6>
                        </div>
                    </div>
                </div>
                <%} %>
                <!-- course -->

            </div>

        </div>
    </section>
    <!-- Courses section end -->



    <!-- Fact section -->
    <!--<section class="fact-section spad">
		
	</section>-->
    <section class="fact-section spad">
        <div class="container">
            <div class="row" style="text-align: center">
                <div class="col-lg-3 col-sm-6 fact-item">
                    <figure>
                        <img src="img/icons/1.png" alt="">
                    </figure>
                    <h2><%=listCT_KhoaHoc.Count %></h2>
                    <p>Lớp học</p>
                </div>
                <div class="col-lg-3 col-sm-6 fact-item">
                    <figure>
                        <img src="img/icons/2.png" alt="">
                    </figure>
                    <h2><%=listHocVien.Count %></h2>
                    <p>Học viên</p>
                </div>
                <div class="col-lg-3 col-sm-6 fact-item">
                    <figure>
                        <img src="img/icons/3.png" alt="">
                    </figure>
                    <h2><%= listGiangVien.Count %></h2>
                    <p>Giảng viên</p>
                </div>
                <div class="col-lg-3 col-sm-6 fact-item">
                    <figure>
                        <img src="img/icons/4.png" alt="">
                    </figure>
                    <h2><%=listKhoaHoc.Count %></h2>
                    <p>Môn học</p>
                </div>
            </div>
        </div>
    </section>
    <!-- Fact section end -->






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
                    <!--<li><a href="#">Courses</a></li>
					<li><a href="#">Contact</a></li>-->
                </ul>
                <div class="footer-logo">
                </div>
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
