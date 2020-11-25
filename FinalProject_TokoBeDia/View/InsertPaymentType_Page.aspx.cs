﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Controller;

namespace FinalProject_TokoBeDia.View
{
    public partial class InsertPaymentType_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    Response.Redirect("Home_Page.aspx");
                }
            }
            else
            {
                
                Response.Redirect("Home_Page.aspx");
                
            }
        }

        protected void PaymentTypeBtn_Click(object sender, EventArgs e)
        {
            String name = PaymentTypeTxt.Text;
            String Message = PaymentTypeController.ValidateNewPaymentType(name);

            if (Message.Equals("Payment Type successfully added to our database !"))
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