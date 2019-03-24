using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new FileInfo(@"C:\Users\Константин\Desktop\учеба\ООП\Task2\test");
            Console.WriteLine(f.FullName);
        }
    }
}
