using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Employ_BO;
using Employ_BLL;

namespace Employ_Project
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_employ(object sender, EventArgs e)
        {

            Employ emp = new Employ();

            emp.Emp_name = txt_name.Text;

            emp.Emp_salary = Convert.ToDouble(txt_salary.Text);

            emp.Emp_dept = txt_dept.Text;

            BLLClass bLLClass = new BLLClass();

            int id = bLLClass.AddEmploy(emp);








        }
    }
}