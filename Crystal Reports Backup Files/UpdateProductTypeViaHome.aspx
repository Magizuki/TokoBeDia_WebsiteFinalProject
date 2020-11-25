<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductTypeViaHome.aspx.cs" Inherits="FinalProject_TokoBeDia.View.UpdateProductTypeViaHome" %>

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
        <br />
        <asp:Label ID="Label5" runat="server" Text="Data to be updated :"></asp:Label>
    </div>
    <br />
    <div>
        <asp:GridView ID="ProductTypeList" runat="server">
            <Columns>
                    <asp:TemplateField HeaderText="Update Product Type">
                        <ItemTemplate>
                            <asp:LinkButton ID="UpdateProductType" CommandArgument='<%# Eval("ProductTypeID") %>' runat="server" OnClick="UpdateProductType_Click"  Text="Update" ></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
        </asp:GridView>
    </div>
    <br />
    <div>
        <asp:Label ID="Label3" runat="server" Text="ID : "></asp:Label>
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
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
    <asp:Button ID="Homebtn" runat="server" Text="Home" OnClick="Homebtn_Click" />
    </form>
</body>
</html>
