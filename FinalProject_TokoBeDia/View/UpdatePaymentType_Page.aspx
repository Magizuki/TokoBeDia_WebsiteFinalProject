<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePaymentType_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.UpdatePaymentType_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Payment Type</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">UPDATE PAYMENT TYPE</h1>
        <hr />
    </div>
    <br />
    <div>
        <h3>Data to be updated :</h3>
        <asp:GridView ID="PaymentTypeList" runat="server"></asp:GridView>
    </div>
    <br />
    <div>
        <asp:Label ID="Label1" runat="server" Text="Payment Type Name"></asp:Label>
        <asp:TextBox ID="PaymentTypeTxt" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="UpdatePaymentTypeBtn" runat="server" Text="Update Payment Type" OnClick="UpdatePaymentTypeBtn_Click" />
        <asp:Label ID="Errorlbl" runat="server" Text="" Style="color:red"></asp:Label>
        <br />
        <asp:Label ID="Successlbl" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <asp:Button ID="HomeBtn" runat="server" Text="Home" OnClick="HomeBtn_Click" />
    </form>
</body>
</html>
