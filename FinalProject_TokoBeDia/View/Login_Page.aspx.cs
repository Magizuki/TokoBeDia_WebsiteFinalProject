using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Controller;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class Login_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie RequestCookie = Request.Cookies["User"];
                if (Request.Cookies["User"] != null)
                {
                    EmailTxt.Text = RequestCookie["email"].ToString(); 
                    PassTxt.Attributes.Add("value", RequestCookie["password"].ToString());
                }
            }

        }

        private void makeSession(String email)
        {
            Session["UserID"] = UserHandler.getUserID(email);
            Session["UserName"] = UserHandler.getName(email);
            Session["RoleID"] = UserHandler.getRoleID(email);
            Session["Status"] = UserHandler.getStatus(email);
            Session["Email"] = email;
            Session["Gender"] = UserHandler.getGender(email);
        }

        protected void Registerbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register_Page.aspx");
        }

        protected void Loginbtn_Click(object sender, EventArgs e)
        {
            String email = EmailTxt.Text;
            String pass = PassTxt.Text;
            Boolean rememberme = RememberMeCheck.Checked;

            String ErrorMessage = UserController.ValidateUser(email, pass);

            if (ErrorMessage.Equals(""))
            {
                makeSession(email);
                if (!Session["Status"].Equals("Active"))
                {
                    Errorlbl.Text = "This Account is Blocked by Admin";
                }
                else
                {
                    if (RememberMeCheck.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("User");
                        cookie.Expires = DateTime.Now.AddMinutes(30);
                        cookie["email"] = email;
                        cookie["password"] = pass;
                        Response.Cookies.Add(cookie);
                    }
                    Response.Redirect("Home_Page.aspx");
                }     
            }
            else
            {
                Errorlbl.Text = ErrorMessage;
                EmailTxt.Text = "";
                PassTxt.Text = "";
            }

        }
    }
}