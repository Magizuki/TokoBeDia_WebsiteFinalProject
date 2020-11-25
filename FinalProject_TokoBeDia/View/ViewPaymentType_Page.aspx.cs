using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class ViewPaymentType_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    Response.Redirect("Home_Page.aspx");
                }

                PaymentTypeList.DataSource = PaymentTypeHandler.GetAllPaymentTypeInfo();
                PaymentTypeList.DataBind();

            }
            else
            {
                
                Response.Redirect("Home_Page.aspx");
                
            }
        }

        private void load()
        {
            PaymentTypeList.DataSource = PaymentTypeHandler.GetAllPaymentTypeInfo();
            PaymentTypeList.DataBind();
        }

        protected void UpdatePaymentTypeBtn_Click(object sender, EventArgs e)
        {
            String name = (sender as LinkButton).CommandArgument.ToString();
            String url = "UpdatePaymentType_Page.aspx?paymentType=" + name;
            Response.Redirect(url);
        }

        protected void DeletePaymentTypeBtn_Click(object sender, EventArgs e)
        {
            String name = (sender as LinkButton).CommandArgument.ToString();
            PaymentTypeHandler.DeletePaymentType(name);
            load();
        }

        protected void InsertPaymentTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentType_Page.aspx");
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}