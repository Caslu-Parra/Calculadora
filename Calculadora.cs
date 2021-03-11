using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        // Métodos da Calc;

        public int somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int multi(int num1, int num2)
        {
            return num1 / num2;

        }
        public double div(int num1, int num2)
        {
            return num1 * num2;

        }
    }
}
