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
    public partial class UpdateProductViaHome : System.Web.UI.Page
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
                    ProductList.DataSource = ProductHandler.GetAllProductInfo();
                    ProductList.DataBind();
                    ProductNameTxt.Visible = false;
                    ProductPriceTxt.Visible = false;
                    StockTxt.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    UpdateProductBtn.Visible = false;
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
            ProductList.DataSource = ProductHandler.GetAllProductInfo();
            ProductList.DataBind();
            ProductList.Columns[0].Visible = true;
            ProductNameTxt.Visible = false;
            ProductPriceTxt.Visible = false;
            StockTxt.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            UpdateProductBtn.Visible = false;
        }

        protected void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Label5.Text);
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

        protected void UpdateProduct_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            ProductList.DataSource = ProductHandler.GetProductByID(id);
            ProductList.DataBind();
            ProductList.Columns[0].Visible = false;
            ProductNameTxt.Visible = true;
            ProductPriceTxt.Visible = true;
            StockTxt.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label5.Text = id.ToString();
            UpdateProductBtn.Visible = true;
            Successlbl.Text = "";
            Errorlbl.Text = "";
        }


    }
    
}