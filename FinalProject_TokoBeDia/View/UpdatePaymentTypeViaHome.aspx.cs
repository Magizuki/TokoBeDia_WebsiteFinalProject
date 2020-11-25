using FinalProject_TokoBeDia.Controller;
using FinalProject_TokoBeDia.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_TokoBeDia.View
{
    public partial class UpdatePaymentTypeViaHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    Response.Redirect("Home_Page.aspx");
                }

                if (!IsPostBack)
                {
                    PaymentTypeList.DataSource = PaymentTypeHandler.GetAllPaymentTypeInfo();
                    PaymentTypeList.DataBind();
                    PaymentTypeList.Columns[0].Visible = true;
                    PaymentTypeTxt.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    UpdatePaymentTypeBtn.Visible = false;
                }
               

            }
            else
            {
                if (Session["RoleID"] == null)
                {
                    Response.Redirect("Home_Page.aspx");
                }
            }
        }

        private void load()
        {
            PaymentTypeList.DataSource = PaymentTypeHandler.GetAllPaymentTypeInfo();
            PaymentTypeList.DataBind();
            PaymentTypeList.Columns[0].Visible = true;
            PaymentTypeTxt.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            UpdatePaymentTypeBtn.Visible = false;
        }

        protected void UpdatePaymentType_Click(object sender, EventArgs e)
        {
            String name = (sender as LinkButton).CommandArgument.ToString();
            PaymentTypeList.DataSource = PaymentTypeHandler.GetPaymentTypeByName(name);
            PaymentTypeList.DataBind();
            PaymentTypeList.Columns[0].Visible = false;
            PaymentTypeTxt.Text = "";
            PaymentTypeTxt.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label2.Text = name;
            Label3.Visible = true;
            Label4.Visible = true;
            UpdatePaymentTypeBtn.Visible = true;
            Successlbl.Text = "";
            Errorlbl.Text = "";
            
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }

        protected void UpdatePaymentTypeBtn_Click(object sender, EventArgs e)
        {
            String nameBefore = Label2.Text;
            String nameAfter = PaymentTypeTxt.Text;
            String Message = PaymentTypeController.ValidateUpdatedPaymentType(nameBefore, nameAfter);

            if (Message.Equals("Payment Type successfully updated to our database !"))
            {
                Successlbl.Text = Message;
                Errorlbl.Text = "";
                load();
            }
            else
            {
                Errorlbl.Text = Message;
                Successlbl.Text = "";
            }

            PaymentTypeTxt.Text = "";
        }
    }
}