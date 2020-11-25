<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCart_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.ViewCart_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Cart</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">VIEW CART</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:GridView ID="CartList" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="Update">
                    <ItemTemplate>
                        <asp:LinkButton ID="UpdateCartBtn" runat="server" CommandArgument='<%# Eval("ProductID") %>' OnClick="UpdateCartBtn_Click" Text="Update" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="DeleteCartBtn" runat="server" CommandArgument='<%# Eval("ProductID") %>' OnClick="DeleteCartBtn_Click" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Grand Total: "></asp:Label>
        <asp:Label ID="GrandTotallbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Payment Type"></asp:Label>
        <asp:TextBox ID="PaymentTypeTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" OnClick="CheckoutBtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" Style="color:red"></asp:Label>
        <br />
        <asp:Label ID="Successlbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <asp:Button ID="HomeBtn" runat="server" Text="Home" OnClick="HomeBtn_Click" />
    </form>
</body>
</html>
