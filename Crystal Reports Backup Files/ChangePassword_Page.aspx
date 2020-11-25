<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.ChangePassword_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">ChangePassword</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Current Password"></asp:Label>
        <asp:TextBox ID="currentPasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
        <asp:TextBox ID="newPasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label3" runat="server" Text="Confirm New Password"></asp:Label>
         <asp:TextBox ID="confirmNewPasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="changePasswordBtn" runat="server" Text="Change Password" OnClick="changePasswordBtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" style="color:red"></asp:Label>
        <br />
        <asp:Label ID="successLbl" runat="server" Text="" style=""></asp:Label>
        <br />
    </div>
    <br />
    <asp:Button ID="homeBtn" runat="server" Text="Home" OnClick="homeBtn_Click" />
    </form>
</body>
</html>
