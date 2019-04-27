<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CoursePage.aspx.cs" Inherits="CoursePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            margin-left: 110px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:BulletedList ID="BulletedList2" runat="server" CssClass="auto-style2" Height="23px" Width="390px">
    </asp:BulletedList>
<asp:Label ID="Label1" runat="server" Visible="False" ></asp:Label>
    <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
</asp:Content>

