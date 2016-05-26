using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BusinessManager
    {
        public void DoBusinessStuff(Exception exceptionToThrow)
        {
            throw exceptionToThrow;
        }

        public bool CheckIfBusinessIsViable(bool resultToReturn)
        {
            return resultToReturn;
        }
    }
}
