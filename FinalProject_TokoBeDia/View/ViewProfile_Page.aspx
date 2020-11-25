<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.ViewProfile_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Profile</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
        <h1 style="text-align:center">VIEW PROFILE</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <asp:Label ID="nameLbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
        <asp:Label ID="emailLbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label3" runat="server" Text="Gender: "></asp:Label>
        <asp:Label ID="genderLbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label4" runat="server" Text="Role: "></asp:Label>
        <asp:Label ID="Rolelbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
         <asp:Button ID="updateProfileBtn" runat="server" Text="Update Profile" OnClick="updateProfileBtn_Click"/>
         <asp:Button ID="changePasswordBtn" runat="server" Text="Change Password" OnClick="changePasswordBtn_Click"/>
         <asp:Button ID="homeBtn" runat="server" Text="Home" OnClick="homeBtn_Click"/>
    </div>
    </div>
    </form>
</body>
</html>
