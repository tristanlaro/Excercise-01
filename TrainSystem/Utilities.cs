using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem
{
    public class Utilities
    {
        public static bool IsPositiveNonZero(int value)
        {
            if (value <= 0)
            {
               

                return false;


            }
            return true;
        }
        public static bool InHundreds(int value)
        {
            if (value % 100 != 0)
            {
               

                return false;
            }

            return true;
        }
    }
}
