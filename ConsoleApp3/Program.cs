using ConsoleApp3.ExtendMath;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(byte i = 0; i<94;i++)
            {
                Console.WriteLine(EMath.Fibonachi(i));
            }
            Console.ReadKey();
        }
    }
}
