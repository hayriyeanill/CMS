                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    <%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<%-- Add content controls here --%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
   
    <style> 

        li{
            list-style-type:none;
            text-align: left;
        }
        .auto-style2 {
            height: 74px;
            width: 125px;
        }
        .auto-style3 {
            width: 125px;
        }
        .auto-style4 {
            width: 800px;
        }
        .auto-style5 {
            height: 74px;
            width: 800px;
        }
        .auto-style6 {
            position: relative;
            display: block;
            margin-bottom: -1px;
            background-color: #fff;
            left: 0px;
            top: 5px;
        }
    </style>
   
    <table class="w-100">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4" rowspan="2">
                <div class="auto-style6">
                    <asp:BulletedList ID="BulletedList1" runat="server" style="margin-bottom: 3px; left: 0px; top: -1px;" BorderWidth="2px" CssClass="list-group-item list-group-item-action list-group-item-primary">
                    </asp:BulletedList>  
                    <asp:BulletedList ID="BulletedList2" runat="server" style="margin-bottom: 3px" BorderWidth="2px" CssClass="list-group-item list-group-item-action list-group-item-success">
                    </asp:BulletedList>
                    <asp:BulletedList ID="BulletedList3" runat="server" style="margin-bottom: 3px" BorderWidth="2px" CssClass="list-group-item list-group-item-action list-group-item-info">
                    </asp:BulletedList>
                    <script></script>
                    </div>
   <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
     <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style5">&nbsp;</td>
            <td style="height: 74px"></td>
        </tr>
    </table>
       
     </asp:Content>

