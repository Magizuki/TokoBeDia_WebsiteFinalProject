<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProductType_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.ViewProductType_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View  Product Type</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">VIEW PRODUCT TYPE</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:GridView ID="ProductTypeList" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="Update">
                    <ItemTemplate>
                        <asp:LinkButton ID="UpdateProductTypeBtn" runat="server" CommandArgument='<%# Eval("ProductTypeID") %>' OnClick="UpdateProductTypeBtn_Click" Text="Update" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="DeleteProductTypeBtn" runat="server" CommandArgument='<%# Eval("ProductTypeID") %>' OnClick="DeleteProductTypeBtn_Click" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <div>
        <asp:Button ID="InsertProductTypeBtn" runat="server" OnClick="InsertProductTypeBtn_Click" Text="Insert Product Type" />
    </div>
    <br />
    <asp:Button ID="Homebtn" runat="server" Text="Home" OnClick="Homebtn_Click" />
    </form>
</body>
</html>
