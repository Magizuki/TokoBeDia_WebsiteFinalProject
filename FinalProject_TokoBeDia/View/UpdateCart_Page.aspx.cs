using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Controller;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class UpdateCart_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    int id = Int32.Parse(Request.QueryString["product"]);
                    String email = Session["Email"].ToString();
                    CartList.DataSource = CartHandler.getCartByID(email, id);
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

        private void load()
        {
            int id = Int32.Parse(Request.QueryString["product"]);
            String email = Session["Email"].ToString();
            CartList.DataSource = CartHandler.getCartByID(email, id);
            CartList.DataBind();
        }

        protected void UpdateCartBtn_Click(object sender, EventArgs e)
        {
            
            int id = Int32.Parse(Request.QueryString["product"]);
            int quantity = Int32.Parse(QuantityTxt.Text);
            String email = Session["Email"].ToString();
            String message = CartController.validateUpdatedCart(email, id, quantity);

            if (!message.Equals(""))
            {
                Errorlbl.Text = message;
            }
            else
            {
                load();
            }

            QuantityTxt.Text = "";

        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}