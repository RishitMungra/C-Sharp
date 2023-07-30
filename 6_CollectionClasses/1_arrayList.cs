using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            Console.WriteLine("Press 1 To To Add new student in list");
            Console.WriteLine("Press 2 To Remove Student with specified index");
            Console.WriteLine("Press 3 To Remove student with specified range.");
            Console.WriteLine("Press 4 To clear all the student from the list");
            while (true)
            {
                Console.WriteLine("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name Of Student : ");
                        String name = Convert.ToString(Console.ReadLine());
                        a1.Add(name);
                        printArrayList(a1);
                        break;
                    case 2:
                        printArrayList(a1);
                        Console.WriteLine("Enter Index To Remove Student : ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        a1.RemoveAt(index);
                        printArrayList(a1);
                        break;
                    case 3:
                        printArrayList(a1);
                        Console.WriteLine("Enter Starting Range : ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Ending Range : ");
                        int end = Convert.ToInt32(Console.ReadLine());
                        a1.RemoveRange(start, end);
                        printArrayList(a1);
                        break;
                    case 4:
                        a1.Clear();
                        printArrayList(a1);
                        break;
                }
            }

        }
        public void printArrayList(ArrayList a1)
        {
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
