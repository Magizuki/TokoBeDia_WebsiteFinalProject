using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Controller;

namespace FinalProject_TokoBeDia.View
{
    public partial class Register_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Loginbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Page.aspx");
        }

        protected void Registerbtn_Click(object sender, EventArgs e)
        {
            String Email = EmailTxt.Text;
            String Name = NameTxt.Text;
            String pass = PassTxt.Text;
            String pass2 = Pass2Txt.Text;
            String gender = "";

            if (Gender.SelectedIndex == 0 || Gender.SelectedIndex == 1)
            {
                gender = Gender.SelectedItem.Text;
            }

            String ErrorMessage = UserController.ValidateNewUser(Name, Email, pass, pass2, gender);

            if (ErrorMessage.Equals(""))
            {
                Response.Redirect("Login_Page.aspx");
            }
            else
            {
                Errorlbl.Text = ErrorMessage;
                EmailTxt.Text = "";
                NameTxt.Text = "";
                PassTxt.Text = "";
                Pass2Txt.Text = "";
            }
           

        }
    }
}