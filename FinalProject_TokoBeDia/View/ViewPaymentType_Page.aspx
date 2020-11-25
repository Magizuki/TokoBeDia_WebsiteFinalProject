<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPaymentType_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.ViewPaymentType_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Payment Type</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">VIEW PAYMENT TYPE</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:GridView ID="PaymentTypeList" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="Update">
                    <ItemTemplate>
                        <asp:LinkButton ID="UpdatePaymentTypeBtn" runat="server" CommandArgument='<%# Eval("PaymentTypeName") %>' OnClick="UpdatePaymentTypeBtn_Click" Text="Update" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="DeletePaymentTypeBtn" runat="server" CommandArgument='<%# Eval("PaymentTypeName") %>' OnClick="DeletePaymentTypeBtn_Click" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <div>
        <asp:Button ID="InsertPaymentTypeBtn" runat="server" Text="Insert Payment Type" OnClick="InsertPaymentTypeBtn_Click"/>
        <asp:Button ID="HomeBtn" runat="server" Text="Home" OnClick="HomeBtn_Click"/>
    </div>
    </form>
</body>
</html>
