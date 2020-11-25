<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProduct_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.ViewProduct_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Product</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">VIEW PRODUCT</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:GridView ID="ProductList" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="Update">
                    <ItemTemplate>
                        <asp:LinkButton ID="UpdateProductBtn" runat="server" CommandArgument='<%# Eval("ProductID") %>' OnClick="UpdateProductBtn_Click" Text="Update" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="DeleteProductBtn" runat="server" CommandArgument='<%# Eval("ProductID") %>' OnClick="DeleteProductBtn_Click" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="AddToCart">
                    <ItemTemplate>
                        <asp:LinkButton ID="AddToCartBtn" runat="server" CommandArgument='<%# Eval("ProductID") %>' OnClick="AddToCartBtn_Click" Text="Add to Cart" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <div>
        <asp:Button ID="InsertProductBtn" runat="server" OnClick="InsertProductBtn_Click" Text="Insert Product" />
    </div>
    <br />
    <asp:Button ID="Homebtn" runat="server" Text="Home" OnClick="Homebtn_Click" />
    </form>
</body>
</html>
