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
    public partial class UpdateProductType_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    Response.Redirect("Home_Page.aspx");
                }

                int id = Int32.Parse(Request.QueryString["productType"]);
                ProductTypeList.DataSource = ProductTypeHandler.GetProductTypeByID(id);
                ProductTypeList.DataBind();

            }
            else
            {
                
                Response.Redirect("Home_Page.aspx");
                
            }
        }
        
        private void load()
        {
            int id = Int32.Parse(Request.QueryString["productType"]);
            ProductTypeList.DataSource = ProductTypeHandler.GetProductTypeByID(id);
            ProductTypeList.DataBind();
        }

        protected void UpdateProductTypeBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["productType"]);
            String name = ProductTypeNameTxt.Text;
            String description = DescriptionTxt.Text;

            String Message = ProductTypeController.ValidateUpdatedProductType(id, name, description);


            if (Message.Equals("Product Type successfully added to our database !"))
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

            ProductTypeNameTxt.Text = "";
            DescriptionTxt.Text = "";

        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
    
}