<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.InsertProduct_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Product</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">INSERT PRODUCT</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="ProductNameTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Stock"></asp:Label>
        <asp:TextBox ID="StockTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="ProductPriceTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="InsertProductBtn" runat="server" Text="Insert Product" OnClick="InsertProductBtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" style="color:red"></asp:Label>
        <br />
        <asp:Label ID="Successlbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <asp:Button ID="Homebtn" runat="server" Text="Home" OnClick="Homebtn_Click" />
    </form>
</body>
</html>
