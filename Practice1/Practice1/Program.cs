using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice1
{
  
    class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo inf = new DirectoryInfo(@"C:\Users\Topsey_Creet\Documents\The Boondocks");
            FileInfo[] files = inf.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine("FileName: {0}, Size: {1}", file.Name, file.LastAccessTime);
               
            }
            Console.ReadLine();

            /*
            FileStream file1 = new FileStream("myfile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter fs = new StreamWriter(file1);
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();
            fs.Write(str);
            fs.Flush();
            fs.Close();
            file1.Close();*/
        }
    }
}
