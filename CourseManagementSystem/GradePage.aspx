<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GradePage.aspx.cs" Inherits="GradePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="EXAM" HeaderText="EXAM" />
            <asp:BoundField DataField="GRADE" HeaderText="GRADE" />

            </Columns>
    </asp:GridView>
</asp:Content>

