using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
    }
}
