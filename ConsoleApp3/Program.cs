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
            DataTable table = new DataTable();
            table.AddAttribute("Id");
            table.AddAttribute("Name");
            table.AddAttribute("Age");
            table.AddData(1, "Koby", 28);
            table.AddData(2, "Moria", 26);
            Console.WriteLine(table);
            Console.ReadKey();
        }
    }
}
