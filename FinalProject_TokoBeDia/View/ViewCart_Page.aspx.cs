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
    public partial class ViewCart_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    String email = Session["Email"].ToString();
                    CartList.DataSource = CartHandler.GetCartDetailInfo(email);
                    CartList.DataBind();
                    GrandTotallbl.Text = CartHandler.GetGrandTotal(email).ToString();

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
            String email = Session["Email"].ToString();
            CartList.DataSource = CartHandler.GetCartDetailInfo(email);
            CartList.DataBind();
            GrandTotallbl.Text = CartHandler.GetGrandTotal(email).ToString();
        }

        protected void UpdateCartBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            String url ="UpdateCart_Page.aspx?product=" + id.ToString();
            Response.Redirect(url);
        }

        protected void DeleteCartBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            String email = Session["Email"].ToString();
            CartHandler.DeleteCart(email, id);
            
        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            String paymentType = PaymentTypeTxt.Text;
            String email = Session["Email"].ToString();
            String message = PaymentTypeController.validatePaymentType(email, paymentType);

            if (message.Equals("Cart Successfully Added to transaction"))
            {
                CartHandler.DeleteAllCart(email);
                Successlbl.Text = message;
                Errorlbl.Text = "";
                load();
            }
            else
            {
                Successlbl.Text = "";
                Errorlbl.Text = message;
            }

            PaymentTypeTxt.Text = "";
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}