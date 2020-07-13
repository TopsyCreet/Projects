using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut
{
    class Program
    {
        public Program(int x)
        {
            Console.WriteLine("I am a A");
        }
        
       
       
    }
    class b: Program
    {
        public b(int x)
            : base(x)
        {
            Console.WriteLine("I am a B");
        }

        static void Main(string[] args)
        {

            b g = new b(3);
            Console.ReadLine();
            
        }
    }
}
