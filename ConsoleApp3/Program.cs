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
            Console.ReadKey();
            double [] arr = new double[90];
            double[] arr2 = new double[100000];
            float deg = 0.0174532f;
            arr[0] = 0;
            for (int i = 0; i < 90;i++,deg += 0.0174532f)
            {
                Console.Write(i + ": " + EMath.Sin(i));
                Console.WriteLine(".  Original = " + Math.Sin(i * Math.PI / 180));
            }
            Console.ReadKey();
        }
    }
}
