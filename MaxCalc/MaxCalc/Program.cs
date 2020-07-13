using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MaxCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Topsey_Creet\Documents\New folder\hai to gensou no grimgar\myfile.txt", FileMode.Append, FileAccess.Write); 
        }
   

        
    }
}
