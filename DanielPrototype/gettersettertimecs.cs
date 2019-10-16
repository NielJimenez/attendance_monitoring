using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielPrototype
{
    class gettersettertimecs
    {
        private static int Time_ID = 0;
        public void setTime_ID(int ID)
        {
            Time_ID = ID;

        }
        public int getTime_ID()
        {
            return Time_ID;
        }
    }
}
