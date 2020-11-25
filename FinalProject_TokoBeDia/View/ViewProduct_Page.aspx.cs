using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Handler;


namespace FinalProject_TokoBeDia.View
{
    public partial class ViewProduct_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InsertProductBtn.Visible = false;
            ProductList.Columns[0].Visible = false;
            ProductList.Columns[1].Visible = false;
            ProductList.Columns[2].Visible = false;

            if (Session["RoleID"]!=null)
            {
                if (Session["RoleID"].ToString().Equals("1"))
                {
                    InsertProductBtn.Visible = true;
                    ProductList.Columns[0].Visible = true;
                    ProductList.Columns[1].Visible = true;
                    
                }
                else
                {
                    ProductList.Columns[2].Visible = true;
                }
            }

            ProductList.DataSource = ProductHandler.GetAllProductInfo();
            ProductList.DataBind();
        }

        private void load()
        {
            ProductList.DataSource = ProductHandler.GetAllProductInfo();
            ProductList.DataBind();
        }

        protected void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            ProductHandler.DeleteProduct(id);
            load();
        }

        protected void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            String url = "UpdateProduct_Page.aspx?product=" + id.ToString();
            Response.Redirect(url);
        }

        protected void InsertProductBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct_Page.aspx");
        }

        protected void AddToCartBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            String url = "AddToCart_Page.aspx?product=" + id.ToString();
            Response.Redirect(url);
        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}