using FinalProject_TokoBeDia.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class UpdateProduct_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    Response.Redirect("Home_Page.aspx");
                }

                int id = Int32.Parse(Request.QueryString["product"]);
                ProductList.DataSource = ProductHandler.GetProductByID(id);
                ProductList.DataBind();

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
            int id = Int32.Parse(Request.QueryString["product"]);
            ProductList.DataSource = ProductHandler.GetProductByID(id);
            ProductList.DataBind();
        }

        protected void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["product"]);
            String name = ProductNameTxt.Text;
            int stock = 0;
            int price = 0;
            if (!StockTxt.Text.Equals("")) stock = Int32.Parse(StockTxt.Text);
            if (!ProductPriceTxt.Text.Equals("")) price = Int32.Parse(ProductPriceTxt.Text);

            String Message = ProductController.ValidateUpdatedProduct(id, name, stock, price);


            if (Message.Equals("Product successfully Updated to our database !"))
            {
                Successlbl.Text = Message;
                load();
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