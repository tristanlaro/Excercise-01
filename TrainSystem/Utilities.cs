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
                throw new ArgumentOutOfRangeException(
            
             "Value must be greater than 0 (positive and non-zero).");




            }
            return true;
        }
        public static bool InHundreds(int value)
        {
            if (value % 100 != 0)
            {
                throw new ArgumentException( " must be in increments of 100 units.");
            }

            return true;
        }
    }
}
