<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.Login_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">LOGIN</h1>
        <hr />
    </div>
    <br />
    <div>
        Dont't have account ? 
        <asp:LinkButton ID="Registerbtn" runat="server" OnClick="Registerbtn_Click">Register here</asp:LinkButton>
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="EmailTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PassTxt" runat="server"  TextMode="Password"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:CheckBox ID="RememberMeCheck" runat="server"  />
        <asp:Label ID="Label3" runat="server" Text="Remember me"></asp:Label>
    </div>
    <br />
    <div>
        <asp:Button ID="Loginbtn" runat="server" Text="Login" OnClick="Loginbtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" style="color:red"></asp:Label>
    </div>
    </form>
</body>
</html>
