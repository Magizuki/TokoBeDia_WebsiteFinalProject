using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Controller;

namespace FinalProject_TokoBeDia.View
{
    public partial class InsertProduct_Page : System.Web.UI.Page
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

        protected void InsertProductBtn_Click(object sender, EventArgs e)
        {
            String name = ProductNameTxt.Text;
            int stock = 0;
            int price = 0;
            if(!StockTxt.Text.Equals("")) stock = Int32.Parse(StockTxt.Text);
            if(!ProductPriceTxt.Text.Equals("")) price = Int32.Parse(ProductPriceTxt.Text);


            String Message = ProductController.ValidateNewProduct(name,stock,price);
            

            if(Message.Equals("Product successfully added to our database !"))
            {
                Successlbl.Text = Message;
                Errorlbl.Text = "";
            }
            else
            {
                Errorlbl.Text = Message;
                Successlbl.Text = "";
            }

            ProductNameTxt.Text = "";
            StockTxt.Text = "";
            ProductPriceTxt.Text = "";

        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}