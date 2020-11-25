<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.UpdateProfile_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Profile</title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">UPDATE PROFILE</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButtonList ID="Gender" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </div>
    <br />
    <div>
        <asp:Button ID="updateProfileBtn" runat="server" Text="Update Profile" OnClick="updateProfileBtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" style="color:red"></asp:Label>
        <br />
        <asp:Label ID="successLbl" runat="server" Text="" ></asp:Label>
    </div>
    <br />
    <asp:Button ID="homeBtn" runat="server" Text="Home" OnClick="homeBtn_Click" />
    </form>
</body>
</html>
