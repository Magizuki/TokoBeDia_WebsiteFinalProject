<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCart_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.UpdateCart_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Cart</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">UPDATE CART</h1>
        <hr />
    </div>
    <br />
    <div>
        <h3>Data to be updated :</h3>
        <br />
        <asp:GridView ID="CartList" runat="server"></asp:GridView>
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="QuantityTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="UpdateCartBtn" runat="server" Text="Update Cart" OnClick="UpdateCartBtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" style="color:red"></asp:Label>
    </div>
    <br />
    <asp:Button ID="HomeBtn" runat="server" Text="Home" OnClick="HomeBtn_Click" />
    </form>
</body>
</html>
