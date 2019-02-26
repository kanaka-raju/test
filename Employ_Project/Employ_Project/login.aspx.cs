using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Employ_BO;
using Employ_BLL;
using System.Data;

namespace Employ_Project
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            BLLClass bLLClass = new BLLClass();

            int l = bLLClass.verifyLogin(username,password);

            if (l > 0)
            {
                lbl_message.Text = "Login successful";
                Session["login"] = "yes";
                Response.Redirect("viewEmployee.aspx");
            }
            else

                lbl_message.Text = "Login unsuccessful";
               
        }
        
    }
}