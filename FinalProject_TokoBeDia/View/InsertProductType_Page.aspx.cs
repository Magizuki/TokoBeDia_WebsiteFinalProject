using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Controller;

namespace FinalProject_TokoBeDia.View
{
    public partial class InsertProductType_Page : System.Web.UI.Page
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
                if (Session["RoleID"] == null)
                {
                    Response.Redirect("Home_Page.aspx");
                }
            }
        }

        protected void InsertProductTypeBtn_Click(object sender, EventArgs e)
        {
            String name = ProductTypeNameTxt.Text;
            String description = DescriptionTxt.Text;

            String Message = ProductTypeController.ValidateNewProductType(name, description);

            if (Message.Equals("Product Type successfully added to our database !"))
            {
                Successlbl.Text = Message;
                Errorlbl.Text = "";
            }
            else
            {
                Errorlbl.Text = Message;
                Successlbl.Text = "";
            }

            ProductTypeNameTxt.Text = "";
            DescriptionTxt.Text = "";

        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}