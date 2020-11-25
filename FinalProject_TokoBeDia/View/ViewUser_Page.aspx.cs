using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FinalProject_TokoBeDia.Handler;

namespace FinalProject_TokoBeDia.View
{
    public partial class ViewUser_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RoleID"] != null)
            {
                if (Session["RoleID"].ToString().Equals("2"))
                {
                    Response.Redirect("Home_Page.aspx");
                }

                UserList.DataSource = UserHandler.GetAllUserData(Session["Email"].ToString());
                UserList.DataBind();

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
            UserList.DataSource = UserHandler.GetAllUserData(Session["Email"].ToString());
            UserList.DataBind();
        }

        protected void ChangeStatusbtn_Click(object sender, EventArgs e)
        {
            String email = ((sender as LinkButton).CommandArgument).ToString();
            String status = UserHandler.getStatus(email);

            if (status.Equals("Active"))
            {
                UserHandler.ChangeStatusToBlocked(email);
            }
            else
            {
                UserHandler.ChangeStatusToActive(email);
            }

            load();

        }

        protected void ChangeRolebtn_Click(object sender, EventArgs e)
        {

            String email = ((sender as LinkButton).CommandArgument).ToString();
            int roleID = UserHandler.getRoleID(email);

            if (roleID == 1)
            {
                UserHandler.ChangeRoleToMember(email);
            }
            else
            {
                UserHandler.ChangeRoleToAdmin(email);
            }

            load();
        }
    }
}