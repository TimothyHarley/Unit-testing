using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class CalculationEngine
    {
        public int DoMath(string stuffToCalculate)
        {
            try
            {
                var splitNumbers = stuffToCalculate
                    .Split('+')
                    .Select(int.Parse);
                return splitNumbers.Sum();
            }
            catch(FormatException)
            {
                throw new InvalidInputException();
            }


        }
    }
}
