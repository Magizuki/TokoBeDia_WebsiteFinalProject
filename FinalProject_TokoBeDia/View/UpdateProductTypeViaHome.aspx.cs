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
    public partial class UpdateProductTypeViaHome : System.Web.UI.Page
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
                    ProductTypeList.DataSource = ProductTypeHandler.GetAllProductTypeInfo();
                    ProductTypeList.DataBind();
                    ProductTypeNameTxt.Visible = false;
                    DescriptionTxt.Visible = false;
                    Label1.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    Label4.Visible = false;
                    Label5.Visible = false;
                    UpdateProductTypeBtn.Visible = false;
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
            ProductTypeList.Columns[0].Visible = true;
            ProductTypeNameTxt.Visible = false;
            DescriptionTxt.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            UpdateProductTypeBtn.Visible = false;
        }

        protected void UpdateProductType_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            ProductTypeList.DataSource = ProductTypeHandler.GetProductTypeByID(id);
            ProductTypeList.DataBind();
            ProductTypeList.Columns[0].Visible = false;
            ProductTypeNameTxt.Visible = true;
            DescriptionTxt.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label4.Text = id.ToString();
            Label5.Visible = true;
            UpdateProductTypeBtn.Visible = true;
            Successlbl.Text = "";
            Errorlbl.Text = "";
        }

        protected void UpdateProductTypeBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Label4.Text);
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