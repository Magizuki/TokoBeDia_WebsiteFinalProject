<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductViaHome.aspx.cs" Inherits="FinalProject_TokoBeDia.View.UpdateProductViaHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Product</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">UPDATE PRODUCT</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:GridView ID="ProductList" runat="server">
            <Columns>
                    <asp:TemplateField HeaderText="Update Product">
                        <ItemTemplate>
                            <asp:LinkButton ID="UpdateProduct" CommandArgument='<%# Eval("ProductID") %>' runat="server" OnClick="UpdateProduct_Click"  Text="Update" ></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
        </asp:GridView>
    </div>
    <br />
    <div>
        <asp:Label ID="Label4" runat="server" Text="ID : "></asp:Label>
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
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
        <asp:Button ID="UpdateProductBtn" runat="server" Text="Update Product" OnClick="UpdateProductBtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" style="color:red"></asp:Label>
        <br />
        <asp:Label ID="Successlbl" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
