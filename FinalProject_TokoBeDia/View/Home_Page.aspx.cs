using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class Home_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ProductRecommendationList.DataSource = ProductHandler.GetProductRecommendation();
            ProductRecommendationList.DataBind();

            LoginBtn.Visible = true;
            ViewProfileBtn.Visible = false;
            ViewCartBtn.Visible = false;
            ViewTransactionHistoryBtn.Visible = false;
            ViewUserBtn.Visible = false;
            ViewPaymentTypeBtn.Visible = false;
            InsertPaymentTypeBtn.Visible = false;
            UpdatePaymentTypeBtn.Visible = false;
            ViewProductBtn.Visible = false;
            InsertProductBtn.Visible = false;
            UpdateProductBtn.Visible = false;
            ViewProductTypeBtn.Visible = false;
            InsertProductTypeBtn.Visible = false;
            UpdateProductTypeBtn.Visible = false;
            ViewTransactionReportBtn.Visible = false;
            LogoutBtn.Visible = false;
            ProductRecommendationList.Columns[0].Visible = false;

            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("1"))
                {
                    LoginBtn.Visible = false;
                    ViewProductBtn.Visible = true;
                    ViewProfileBtn.Visible = true;
                    ViewUserBtn.Visible = true;
                    ViewPaymentTypeBtn.Visible = true;
                    InsertPaymentTypeBtn.Visible = true;
                    UpdatePaymentTypeBtn.Visible = true;
                    ViewProductBtn.Visible = true;
                    InsertProductBtn.Visible = true;
                    UpdateProductBtn.Visible = true;
                    ViewProductTypeBtn.Visible = true;
                    InsertProductTypeBtn.Visible = true;
                    UpdateProductTypeBtn.Visible = true;
                    ViewTransactionReportBtn.Visible = true;
                    ViewTransactionHistoryBtn.Visible = true;
                    LogoutBtn.Visible = true;
                }
                else if (Session["RoleID"].ToString().Equals("2"))
                {
                    LoginBtn.Visible = false;
                    ViewProductBtn.Visible = true;
                    ViewProfileBtn.Visible = true;
                    ViewCartBtn.Visible = true;
                    ViewTransactionHistoryBtn.Visible = true;
                    LogoutBtn.Visible = true;
                    ProductRecommendationList.Columns[0].Visible = true;
                }

                welcomelbl.Text = "Welcome " + Session["UserName"].ToString();

            }
            else
            {
                welcomelbl.Text = "Welcome Anonymous" ;
                ViewProductBtn.Visible = true;
                ProductRecommendationList.Columns[0].Visible = false;
            }

        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.RemoveAll();
            Response.Cookies["User"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Login_Page.aspx");
        }

        protected void ViewProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile_Page.aspx");
        }

        protected void ViewCartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart_Page.aspx");
        }

        protected void ViewTransactionHistoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionHistory_Page.aspx");
        }

        protected void ViewUserBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser_Page.aspx");
        }

        protected void ViewPaymentTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPaymentType_Page.aspx");
        }

        protected void InsertPaymentTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentType_Page.aspx");
        }

        protected void UpdatePaymentTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdatePaymentTypeViaHome.aspx");
        }

        protected void ViewProductBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct_Page.aspx");
        }

        protected void InsertProductBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct_Page.aspx");
        }

        protected void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProductViaHome.aspx");
        }

        protected void ViewProductTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProductType_Page.aspx");
        }

        protected void InsertProductTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType_Page.aspx");
        }

        protected void UpdateProductTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProductTypeViaHome.aspx");
        }

        protected void ViewTransactionReportBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactionReport_Page.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Page.aspx");
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            String url = "AddToCart_Page.aspx?product=" + id.ToString();
            Response.Redirect(url);
        }
    }
}