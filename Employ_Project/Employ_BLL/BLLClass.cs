using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employ_BO;
using Employ_DAL;

namespace Employ_BLL
{
    public class BLLClass
    {
        DB dB = new DB();

        public DataSet bindEmployees()
        {
            
            return dB.viewEmployees();
        }

        public int AddEmploy(Employ emp)
        {
            return dB.AddEmployee(emp);
        }

        public DataSet getSingleEmpoly(int v)
        {
            return dB.getSingleEmploy(v);
        }

        public int deleteEmploy(string v)
        {
            return dB.deleteEmployee(v);
        }
    }
}
