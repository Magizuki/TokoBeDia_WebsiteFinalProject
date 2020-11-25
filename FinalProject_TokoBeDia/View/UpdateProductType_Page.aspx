<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductType_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.UpdateProductType_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Product Type</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">UPDATE PRODUCT TYPE</h1>
        <hr />
    </div>
    <br />
    <div>
        <h5>Data to be updated :</h5>
        <br />
        <asp:GridView ID="ProductTypeList" runat="server">
        </asp:GridView>
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
        <asp:Button ID="UpdateProductTypeBtn" runat="server" Text="Update Product Type" OnClick="UpdateProductTypeBtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" style="color:red"></asp:Label>
        <br />
        <asp:Label ID="Successlbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <asp:Button ID="Homebtn" OnClick="Homebtn_Click" runat="server" Text="Home" />
    </form>
</body>
</html>
