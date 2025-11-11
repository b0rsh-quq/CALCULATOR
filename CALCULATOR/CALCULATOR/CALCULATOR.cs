using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR
{
    internal class CALCULATOR
    {
        public static double Count(int numOperation, double firstOperand, double secondOperand)
        {
            switch (numOperation)
            {
                case 1: return firstOperand + secondOperand;



                case 2: return firstOperand - secondOperand;



                case 3:
                    return firstOperand * secondOperand;



                case 4:
                    if (secondOperand == 0) { return Double.PositiveInfinity; }
                    else { return firstOperand / secondOperand; }


                case 5: return Math.Pow(firstOperand, secondOperand);
                default: return 0;
            }
        }
    }
}
