using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class ViewTransactionHistory_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("1"))
                {
                    TransactionList.DataSource = TransactionHandler.GetAllTransactionInfoViaAdmin();
                    TransactionList.DataBind();
                }
                else if (Session["RoleID"].ToString().Equals("2"))
                {
                    String email = Session["Email"].ToString();
                    TransactionList.DataSource = TransactionHandler.GetAllTransactionViaMember(email);
                    TransactionList.DataBind();
                    TransactionReportBtn.Visible = false;
                }
            }
            else
            {
                Response.Redirect("Home_Page.aspx");
            }
        }

        protected void TransactionReportBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionReport_Page.aspx");
        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}