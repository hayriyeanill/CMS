<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Course Management System Login</title>
    <style>
html {
  background-color: #56baed;
}

body {
  font-family: "Poppins", sans-serif;
  height: 100vh;
}
a {
  color: #92badd;
  display:inline-block;
  text-decoration: none;
  font-weight: 400;
}

h2 {
  text-align: center;
  font-size: 16px;
  font-weight: 600;
  text-transform: uppercase;
  display:inline-block;
  margin: 40px 8px 10px 8px; 
  color: #cccccc;
}
#formContent {
  -webkit-border-radius: 10px 10px 10px 10px;
  border-radius: 10px 10px 10px 10px;
  background: #fff;
  padding: 30px;
  width: 90%;
  max-width: 450px;
  position: relative;
  padding: 0px;
  -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
  box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
  text-align: center;
}

h2.inactive {
  color: #cccccc;
}

h2.active {
  color: #0d0d0d;
  border-bottom: 2px solid #5fbae9;
}

input[type=button], input[type=submit], input[type=reset]  {
  background-color: #56baed;
  border: none;
  color: white;
  padding: 15px 80px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  text-transform: uppercase;
  font-size: 13px;
  -webkit-box-shadow: 0 10px 30px 0 rgba(95,186,233,0.4);
  box-shadow: 0 10px 30px 0 rgba(95,186,233,0.4);
  -webkit-border-radius: 5px 5px 5px 5px;
  border-radius: 5px 5px 5px 5px;
  margin: 5px 20px 40px 20px;
  -webkit-transition: all 0.3s ease-in-out;
  -moz-transition: all 0.3s ease-in-out;
 
  -o-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}

input[type=text]:focus {
  background-color: #fff;
  border-bottom: 2px solid #5fbae9;
}

.fadeInDown {
  -webkit-animation-name: fadeInDown;
  animation-name: fadeInDown;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-fill-mode: both;
  animation-fill-mode: both;
}

@-webkit-keyframes fadeInDown {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
  100% {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInDown {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
  100% {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

        .auto-style1 {
            left: 105px;
            top: 15px;
        }
        .auto-style2 {
            left: 430px;
            top: 120px;
        }
        .auto-style3 {
            height: 100px;
        }





        .auto-style4 {
            left: 473px;
            top: 93px;
            margin-top: 0px;
        }





    </style>
</head>
<body style="margin-right: 0">
    <div class="wrapper fadeInDown">
    <div id="formContent" class="auto-style4">
         <!-- Icon -->
    <form id="form1" runat="server">
         
  <div class="fadeIn first">
       &nbsp;<asp:Image ID="imgCMS" runat="server" ImageUrl="~/cms1.png" Width="70px" />
    </div>
         
        <table class="auto-style5">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblUserId" runat="server" Text="User ID:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUserID" runat="server" TextMode="SingleLine" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="Rfv_userID" runat="server" ControlToValidate="txtUserID" ErrorMessage="Please Enter Your User ID"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:RequiredFieldValidator ID="Rfv_password" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please Enter Your Password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log In" Height="53px" />
                </td>
                <td class="auto-style7">
                    <asp:Label ID="lblErrorMessage" runat="server">Invalid Name or Password</asp:Label>
                </td>
            </tr>
        </table>
            
    </form>
         &nbsp;</div>
             </div>
  
</body>
</html>
