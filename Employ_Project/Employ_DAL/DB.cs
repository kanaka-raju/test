using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Employ_BO;

namespace Employ_DAL
{
    public class DB
    {

        String constring = "Data Source=localhost;Initial Catalog=raju;uid=raju; password=raju;";


        SqlConnection con;

        SqlCommand cmd;



        public DataSet viewEmployees()
        {
            con = new SqlConnection(constring);

            cmd = new SqlCommand("usp_viewEmployees",con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(ds);

            return ds;

        }

        public int deleteEmployee(string v)
        {
            con = new SqlConnection(constring);

            cmd = new SqlCommand("usp_deleteEmploy", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Employ_id", v);

            con.Open();

            int d = cmd.ExecuteNonQuery();

            return d;


        }

        public DataSet getSingleEmploy(int v)
        {
            con = new SqlConnection(constring);

            cmd = new SqlCommand("usp_singleEmploy", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Employ_id",v);

            DataSet ds = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(ds);

            return ds;
        }

        public int AddEmployee(Employ emp)
        {

            con = new SqlConnection(constring);

            cmd = new SqlCommand("usp_addEmployee", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Employ_id",emp.Emp_id);

            cmd.Parameters.AddWithValue("@Employ_name", emp.Emp_name);

            cmd.Parameters.AddWithValue("@Employ_salary", emp.Emp_salary);

            cmd.Parameters.AddWithValue("@Employ_dept", emp.Emp_dept);

            con.Open();

            int n = cmd.ExecuteNonQuery();

            return n;







        }
    }
}
