using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class ViewProductType_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    Response.Redirect("Home_Page.aspx");
                }
                else
                {
                    ProductTypeList.DataSource = ProductTypeHandler.GetAllProductTypeInfo();
                    ProductTypeList.DataBind();
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
            ProductTypeList.DataSource = ProductTypeHandler.GetAllProductTypeInfo();
            ProductTypeList.DataBind();
        }

        protected void UpdateProductTypeBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            String url = "UpdateProductType_Page.aspx?productType=" + id.ToString();
            Response.Redirect(url);
        }

        protected void DeleteProductTypeBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            ProductTypeHandler.DeleteProductType(id);
            load();
        }

        protected void InsertProductTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType_Page.aspx");
        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}