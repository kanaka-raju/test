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

        public int verifyLoginDetails(string username, string password)
        {
            con = new SqlConnection(constring);

            cmd = new SqlCommand("usp_verifyLogin", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);

            cmd.Parameters.AddWithValue("@password", password);

            SqlParameter param = new SqlParameter("@login_out", SqlDbType.Int);

            param.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(param);

            con.Open();

            int n = cmd.ExecuteNonQuery();


            return Convert.ToInt32(cmd.Parameters["@login_out"].Value); 

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

            SqlParameter param = new SqlParameter("@emp_out",SqlDbType.Int);

            param.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(param);

            con.Open();

            int n = cmd.ExecuteNonQuery();

            int emp_out=0;

            if (n > 0)
            {
                emp_out= Convert.ToInt32(cmd.Parameters["@emp_out"].Value);
            }

            return emp_out;



        }
    }
}
