<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProductType_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.InsertProductType_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Product Type</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">INSERT PRODUCT TYPE</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Product Type"></asp:Label>
        <asp:TextBox ID="ProductTypeNameTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="DescriptionTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="InsertProductTypeBtn" runat="server" Text="Insert Product" OnClick="InsertProductTypeBtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" style="color:red"></asp:Label>
        <br />
        <asp:Label ID="Successlbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <asp:Button ID="Homebtn" runat="server" Text="Home" OnClick="Homebtn_Click" />
    </form>
</body>
</html>
