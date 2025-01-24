using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem
{
    public class Utilities
    {
        public static void IsPositiveNonZero(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(" must be a positive, non-zero number.");




            }
        }
        public static void InHundreds(int value)
        {
            if (value % 100 != 0)
            {
                throw new ArgumentException( " must be in increments of 100 units.");
            }
        }
    }
}
