using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    public class SimpleNumber
    {
        public bool CheckNumber(int numb)
        {
            int d = 0;
            int i = 2;

            while (i < numb)
            {
                if (numb % i == 0)
                {
                    d++;
                }
                i++;
            }

            if (d == 0)
                return true;
            else
                return false;
        }
    }
}
