<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container ">
        <div class="row">
            <div class="login-content">
                <div class="login-logo">
                    <a href="#">
                        <img class=" center-block" src="images/icon/logo.png" alt="login">
                    </a>
                </div>
                <div class="login-form">
                    <form class="form-horizontal center-block" style="max-width: 540px" action="#" method="post">
                        <div class="form-group">
                            <label>Tên đăng nhập</label>
                            <input class="form-control" type="text" name="username" placeholder="Tên đăng nhập">
                        </div>
                        <div class="form-group">
                            <label>Mật khẩu</label>
                            <input class="form-control" type="password" name="password" placeholder="Mật khẩu">
                        </div>
                        <div class="checkbox text-center">
                            <label>
                                <input type="checkbox" name="remember">Ghi nhớ đăng nhập
                            </label>
                            <label>
                                <a href="#">Quên mật khẩu?</a>
                            </label>
                        </div>
                        <div class="form-group text-center">
                            <br />
                            <button class="btn btn-success" type="submit">Đăng nhập</button>
                        </div>
                         <div class="register-link">
                        <p>
                            Bạn chưa có tại khoản?
                                    <a href="#">Đăng ký ở đây</a>
                        </p>
                    </div>
                    </form>
                   
                </div>
            </div>
        </div>
    </div>
</asp:Content>

