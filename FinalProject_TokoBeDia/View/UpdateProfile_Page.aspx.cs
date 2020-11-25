using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_TokoBeDia.View
{
    public partial class UpdateProfile_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("Home_Page.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    emailTxt.Text = Session["Email"].ToString();
                    nameTxt.Text = Session["UserName"].ToString();
                }
            }
            
        }

        protected void updateProfileBtn_Click(object sender, EventArgs e)
        {
            String emailBefore = Session["Email"].ToString();
            String emailAfter = emailTxt.Text;
            String name = nameTxt.Text;
            String gender = "";

            if (Gender.SelectedIndex == 0 || Gender.SelectedIndex == 1)
            {
                gender = Gender.SelectedItem.Text;
            }

            String Message = Controller.UserController.ValidateUpdateUser(name, emailBefore, emailAfter, gender);
            if (Message.Equals("Profile successfully updated!"))
            {
                successLbl.Text = Message;
                Errorlbl.Text = "";
            }
            else
            {
                Errorlbl.Text = Message;
                successLbl.Text = "";
            }
            Session["Email"] = emailAfter;
            Session["UserName"] = name;
            Session["Gender"] = gender;
        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_Page.aspx");
        }
    }
}