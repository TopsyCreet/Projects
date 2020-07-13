using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloading
{
    class FunctionOverloading
    {
        public int max(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
        public float max(float number1, float number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
        class MaxCalc
        {
            static void Main(string[] args)
            {
                FunctionOverloading calc = new FunctionOverloading();
                Console.WriteLine("{0}", calc.max(5.4F, 8.6F));
                Console.Write("////////////////");
                Console.WriteLine("{0}", calc.max(4, 8.6F));
                Console.Write("////////////////");
                Console.WriteLine("{0}", calc.max(10, 8));
                Console.ReadLine();
                
            }
        }

    }
}
