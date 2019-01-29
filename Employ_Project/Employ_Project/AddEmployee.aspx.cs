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
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.QueryString["Employ_id"] != null)
                {
                    bindEmployee();
                }
            }
        }

        private void bindEmployee()
        {
           

            DataSet ds = new DataSet();

            BLLClass bLLClass = new BLLClass();

            ds = bLLClass.getSingleEmpoly(Convert.ToInt32(Request.QueryString["Employ_id"]));

            if(ds!=null && ds.Tables.Count>0 && ds.Tables[0].Rows.Count > 0)
            {
                txt_name.Text = ds.Tables[0].Rows[0]["Employ_name"].ToString();
                txt_salary.Text= ds.Tables[0].Rows[0]["Employ_salary"].ToString();
                txt_dept.Text= ds.Tables[0].Rows[0]["Employ_dept"].ToString();

            }



        }

        protected void create_employ(object sender, EventArgs e)
        {

            Employ emp = new Employ();

            if(Request.QueryString["Employ_id"]!=null)
            {
                emp.Emp_id = Convert.ToInt32(Request.QueryString["Employ_id"]);
            }


            emp.Emp_name = txt_name.Text;

            emp.Emp_salary = Convert.ToDouble(txt_salary.Text);

            emp.Emp_dept = txt_dept.Text;

            BLLClass bLLClass = new BLLClass();

            int id = bLLClass.AddEmploy(emp);

            if (id > 0)
            {
                lbl_message.Text = "Employee inserted successfully";

            }

            else
            {
                lbl_message.Text = "Insert unsuccessful";
            }








        }
    }
}