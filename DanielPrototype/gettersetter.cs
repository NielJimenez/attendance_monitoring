using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielPrototype
{
    class gettersetter
    {
        private static int Emp_ID = 0;
        public void setEmp_ID(int ID)
        {
            Emp_ID = ID;

        }
        public int getEmp_ID()
        {   
            return Emp_ID;
        }
    }
}
