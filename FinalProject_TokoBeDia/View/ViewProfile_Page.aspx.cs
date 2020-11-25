using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class ViewProfile_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("Home_Page.aspx");
            }
            else
            {
                var email = Session["Email"] as string;

                nameLbl.Text = UserHandler.getName(email);
                genderLbl.Text = UserHandler.getGender(email);
                emailLbl.Text = email;
                Rolelbl.Text =  UserHandler.getRoleName(email).ToString();
            }
        }

        protected void updateProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile_Page.aspx");
        }

        protected void changePasswordBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword_Page.aspx");
        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}