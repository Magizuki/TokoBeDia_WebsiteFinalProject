using FinalProject_TokoBeDia.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_TokoBeDia.View
{
    public partial class ChangePassword_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("Home_Page.aspx");
            }
           
        }

        protected void changePasswordBtn_Click(object sender, EventArgs e)
        {
            String oldPassword = currentPasswordTxt.Text;
            String newPassword = newPasswordTxt.Text;
            String confirmPassword = confirmNewPasswordTxt.Text;
            String email = Session["Email"].ToString();

            String Message = UserController.ValidateChangePassword(email, oldPassword, newPassword, confirmPassword);
            if (Message.Equals("Password successfully changed"))
            {
                successLbl.Text = Message;
                Errorlbl.Text = "";
            }
            else
            {
                Errorlbl.Text = Message;
                successLbl.Text = "";
            }
        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}