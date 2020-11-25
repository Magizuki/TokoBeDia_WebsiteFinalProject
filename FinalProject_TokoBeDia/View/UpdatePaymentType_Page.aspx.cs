using FinalProject_TokoBeDia.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Controller;

namespace FinalProject_TokoBeDia.View
{
    public partial class UpdatePaymentType_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    Response.Redirect("Home_Page.aspx");
                }

                String nameBefore = Request.QueryString["paymentType"];
                PaymentTypeList.DataSource = PaymentTypeHandler.GetPaymentTypeByName(nameBefore);
                PaymentTypeList.DataBind();

            }
            else
            {

                Response.Redirect("Home_Page.aspx");

            }
        }

        private void load()
        {
            String nameBefore = Request.QueryString["paymentType"];
            PaymentTypeList.DataSource = PaymentTypeHandler.GetPaymentTypeByName(nameBefore);
            PaymentTypeList.DataBind();
        }

        protected void UpdatePaymentTypeBtn_Click(object sender, EventArgs e)
        {
            String nameBefore = Request.QueryString["paymentType"];
            String nameAfter = PaymentTypeTxt.Text;
            String Message = PaymentTypeController.ValidateUpdatedPaymentType(nameBefore, nameAfter);

            if (Message.Equals("Payment Type successfully updated to our database !"))
            {
                Successlbl.Text = Message;
                Errorlbl.Text = "";
            }
            else
            {
                Errorlbl.Text = Message;
                Successlbl.Text = "";
            }

            PaymentTypeTxt.Text = "";

        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}