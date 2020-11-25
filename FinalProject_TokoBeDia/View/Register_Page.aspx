<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.Register_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">REGISTER</h1>
        <hr />
    </div>
    <div>
        Already have account ?
        <asp:LinkButton ID="Loginbtn" runat="server" OnClick="Loginbtn_Click">Login here</asp:LinkButton>
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="EmailTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PassTxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="Pass2Txt" runat="server"  TextMode="Password"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButtonList ID="Gender" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </div>
    <br />
    <div>
        <asp:Button ID="Registerbtn" runat="server" Text="Register" onclick="Registerbtn_Click"/>
        <asp:Label ID="Errorlbl" runat="server" Text="" style="color:red"></asp:Label>
    </div>
    </form>
</body>
</html>
