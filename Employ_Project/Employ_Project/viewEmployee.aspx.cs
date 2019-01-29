using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Employ_BLL;

namespace Employ_Project
{
    public partial class viewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindEmployee();
            }
        }


        private void bindEmployee()
        {
            BLLClass bLLClass = new BLLClass();

            DataSet ds = new DataSet();

            ds = bLLClass.bindEmployees();

            grdView.DataSource = ds;

            grdView.DataBind();



        }

        protected void grdView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName== "cmdEdit")
            {
                Response.Redirect("AddEmployee.aspx?Employ_id="+Convert.ToString(e.CommandArgument));
            }


            if (e.CommandName == "cmdDelete")
            {
                BLLClass bLLClass = new BLLClass();

                int d = bLLClass.deleteEmploy(Convert.ToString(e.CommandArgument));

                Response.Redirect("viewEmployee.aspx");

            }


        }
    }
}
