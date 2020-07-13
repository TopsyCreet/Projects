using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
    class Tester
    {
        static void Main(string[] args)
        {
            string t = "les Mise\u0301rables";
            char[] a = t.ToCharArray();
            System.Array.Reverse(a);
            string r = new string(a);
            Console.WriteLine("hello\u0301world!!!");
            Console.ReadKey();
             r = "This is a str\u0301ing Literal";
             Console.WriteLine(t);

          
             Console.WriteLine(r);

             Console.Read();
        }
    }
         
    
}
