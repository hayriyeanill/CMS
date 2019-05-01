<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContentAssignment.aspx.cs" Inherits="ContentAssignment" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="width: 553px">
        <tr>
            <td class="auto-style4" style="width: 428px">
                <asp:Label ID="lblAssignmentNo" runat="server" Text="lblAssigment"></asp:Label>
            </td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="height: 239px; width: 428px">
                Content:</td>
            <td class="auto-style7" style="height: 239px">
                <asp:Label ID="lblContent" runat="server"></asp:Label>
            </td>
            <td class="auto-style9" style="height: 239px">
                </td>
        </tr>
        <tr>
            <td class="auto-style4" style="height: 167px; width: 428px">
                Answer Here</td>
            <td class="auto-style6" style="height: 167px">
                <asp:TextBox ID="txtAnswer" runat="server" Height="154px" TextMode="MultiLine" 
                    Width="400px"></asp:TextBox>
            </td>
            <td class="auto-style2" style="height: 167px">
                </td>
        </tr>
 
        
        <tr>
            <td class="auto-style4" style="width: 428px">
                <asp:Literal ID="ltrlMessage" runat="server"></asp:Literal>
            </td>
            <td class="auto-style6">
                <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
            </td>
            <td class="auto-style2">
                &nbsp;</td>
        </tr>
        
    </table>
    </asp:Content>

