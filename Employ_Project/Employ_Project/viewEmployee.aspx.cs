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

    }
}