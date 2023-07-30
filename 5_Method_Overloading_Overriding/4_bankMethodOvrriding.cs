using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RBI r1 = new RBI();
            HDFC h1 = new HDFC();
            SBI s1 = new SBI();
            ICICI i1 = new ICICI();

            r1.calculateIntrest();
            h1.calculateIntrest();
            s1.calculateIntrest();
            i1.calculateIntrest();

        }
    }

    class RBI
    {
        public virtual void calculateIntrest()
        {
            Console.WriteLine("Intrest In RBI");
        }
    }
    class HDFC : RBI
    {
        override public void calculateIntrest()
        {
            Console.WriteLine("Intrest In HDFC");
        }
    }
    class SBI : RBI
    {
        override public void calculateIntrest()
        {
            Console.WriteLine("Intrest In SBI");
        }
    }
    class ICICI : RBI
    {
        override public void calculateIntrest()
        {
            Console.WriteLine("Intrest In ICICI");
        }
    }

}
