<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionReport_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.ViewTransactionReport_Page" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Transaction Report</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">VIEW TRANSACTION REPORT</h1>
        <hr />
    </div>
    <br />
    <div>
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
    </div>
    <br />
    <asp:Button ID="Homebtn" runat="server" Text="Home" OnClick="Homebtn_Click" />
    </form>
</body>
</html>
