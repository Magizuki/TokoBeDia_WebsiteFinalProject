using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Handler;
using FinalProject_TokoBeDia.Controller;

namespace FinalProject_TokoBeDia.View
{
    public partial class AddToCart_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    int id = Int32.Parse(Request.QueryString["product"]);
                    CartList.DataSource = ProductHandler.GetProductInfoByID(id);
                    CartList.DataBind();
                }
                else
                {
                    Response.Redirect("Home_Page.aspx");
                }
            }
            else
            {
                Response.Redirect("Home_Page.aspx");
            }
        }

        protected void AddToCartBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["product"]);
            int quantity = Int32.Parse(QuantityTxt.Text);
            String email = Session["Email"].ToString();

            String message = CartController.validateCart(email, id, quantity);

            if (message.Equals(""))
            {
                Response.Redirect("ViewCart_Page.aspx");
            }

            Errorlbl.Text = message;

        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}