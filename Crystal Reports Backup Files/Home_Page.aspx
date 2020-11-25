<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">
            <asp:Label ID="welcomelbl" runat="server" Text=""></asp:Label>
        </h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
        <asp:Button ID="ViewProfileBtn" runat="server" Text="View Profile" OnClick="ViewProfileBtn_Click" />
        <asp:Button ID="ViewCartBtn" runat="server" Text="View Cart" OnClick="ViewCartBtn_Click"/>
        <asp:Button ID="ViewTransactionHistoryBtn" runat="server" Text="View Transaction History" OnClick="ViewTransactionHistoryBtn_Click" />
        <asp:Button ID="ViewUserBtn" runat="server" Text="View User" OnClick="ViewUserBtn_Click" />
        <asp:Button ID="ViewPaymentTypeBtn" runat="server" Text="View Payment Type" OnClick="ViewPaymentTypeBtn_Click" />
        <asp:Button ID="InsertPaymentTypeBtn" runat="server" Text="Insert Payment Type" OnClick="InsertPaymentTypeBtn_Click" />
        <asp:Button ID="UpdatePaymentTypeBtn" runat="server" Text="Update Payment Type" OnClick="UpdatePaymentTypeBtn_Click" />
        <asp:Button ID="ViewProductBtn" runat="server" Text="View Product" OnClick="ViewProductBtn_Click" />
        <asp:Button ID="InsertProductBtn" runat="server" Text="Insert Product" OnClick="InsertProductBtn_Click" />
        <asp:Button ID="UpdateProductBtn" runat="server" Text="Update Product" OnClick="UpdateProductBtn_Click" />
        <asp:Button ID="ViewProductTypeBtn" runat="server" Text="View Product Type" OnClick="ViewProductTypeBtn_Click" />
        <asp:Button ID="InsertProductTypeBtn" runat="server" Text="Insert Product Type" OnClick="InsertProductTypeBtn_Click" />
        <asp:Button ID="UpdateProductTypeBtn" runat="server" Text="Update Product Type" OnClick="UpdateProductTypeBtn_Click" />
        <asp:Button ID="ViewTransactionReportBtn" runat="server" Text="View Transaction Report" OnClick="ViewTransactionReportBtn_Click" />
        <asp:Button ID="LogoutBtn" runat="server" Text="Logout" OnClick="LogoutBtn_Click" />
    </div>
    <br />
    <div>
        <h3> Our Recommendation</h3>
        <br />
        <asp:GridView ID="ProductRecommendationList" runat="server">
            <Columns>
                    <asp:TemplateField HeaderText="Add to Cart">
                        <ItemTemplate>
                            <asp:LinkButton ID="AddToCart"  runat="server" OnClick="AddToCart_Click" CommandArgument='<%#Eval("ProductID") %>'  Text="Add to Cart" ></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
