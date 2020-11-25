<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUser_Page.aspx.cs" Inherits="FinalProject_TokoBeDia.View.ViewUser_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View User</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align:center">VIEW USER</h1>
        <hr />
    </div>
    <br />
    <div>
        <asp:GridView ID="UserList" runat="server">
            <Columns>
                    <asp:TemplateField HeaderText="Change Status">
                        <ItemTemplate>
                            <asp:LinkButton ID="ChangeStatusbtn" CommandArgument='<%# Eval("UserEmail") %>' runat="server" OnClick="ChangeStatusbtn_Click"  Text="Active/Blocked" ></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Change Role">
                        <ItemTemplate>
                            <asp:LinkButton ID="ChangeRolebtn" CommandArgument='<%# Eval("UserEmail") %>' runat="server" OnClick="ChangeRolebtn_Click"  Text="Admin/Member" ></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
