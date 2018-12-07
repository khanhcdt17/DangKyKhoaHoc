<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.master" AutoEventWireup="true" CodeFile="TaiKhoan.aspx.cs" Inherits="Admin_TaiKhoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="table-responsive table--no-card m-b-30">
        <table class="table table-borderless table-striped table-earning">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Tên đăng nhập</th>
                    <th>Mật khẩu</th>
                    <th>Mail bảo mật</th>
                    <th>Chức danh</th>
                    <th>Quản lý</th>
                    <th>Trạng thái</th>
                </tr>
            </thead>
            <tbody>
                <%
                    foreach (DataAccess.TAIKHOAN item in taiKhoans)
                    {%>
                <tr>
                    <td><%=item.MATK %></td>
                    <td><%=item.TENDANGNHAP %></td>
                    <td><%=item.MATKHAU %></td>
                    <td><%=item.MAILBAOMAT %></td>
                    <td><%=item.CHUCDANH %></td>
                    <td><%=item.QUANLY %></td>
                    <td><%=item.TRANGTHAI %></td>
                </tr>

                <% }; %>
            </tbody>
        </table>
    </div>
</asp:Content>

