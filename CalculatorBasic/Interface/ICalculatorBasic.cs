using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBasic.Interface
{
    public interface ICalculatorBasic
    {
        public double Addition(double value1, double value2);
        public double substaction(double value1, double value2);
        public double multiplication(double value1, double value2);
        public double Divetion(double value1, double value2);
    }
}
