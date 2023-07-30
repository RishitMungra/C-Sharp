using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "Darshan University";

            Console.WriteLine("Length Of Stinrg Is : " + s.Length);
            Console.WriteLine("Substring : " + s.Substring(1));
            Console.WriteLine("Contains: " + s.Contains("Darshan"));
            Console.WriteLine("Replaced : " + s.Replace("Darshan", "darshan"));
            Console.WriteLine("Index of 'Yash': " + s.IndexOf("Darshan"));
            Console.WriteLine("Upper Case Conversion: " + s.ToUpper());
            Console.WriteLine("Lower Case Conversion: " + s.ToLower());
            Console.WriteLine("Formate String : " + string.Format("Hii ! I'm from {0}", s));
        }
    }
}
