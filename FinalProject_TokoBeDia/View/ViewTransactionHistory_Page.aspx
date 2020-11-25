<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionHistory_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.ViewTransactionHistory_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Transaction History</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">VIEW TRANSACTION HISTORY</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:GridView ID="TransactionList" runat="server"></asp:GridView>
    </div>
    <br />
    <div>
        <asp:Button ID="TransactionReportBtn" runat="server" Text="View Transaction Report" OnClick="TransactionReportBtn_Click" />
    </div>
    <br />
    <div>
        <asp:Button ID="Homebtn" runat="server" Text="Home" OnClick="Homebtn_Click" />
    </div>
    </form>
</body>
</html>
