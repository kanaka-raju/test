using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employ_DAL;

namespace Employ_BLL
{
    public class BLLClass
    {
        public DataSet bindEmployees()
        {
            DB dB = new DB();
            return dB.viewEmployees();
        }
    }
}
