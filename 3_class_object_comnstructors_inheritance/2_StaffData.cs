using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Staff
    {
        public String Name;
        public String Post;

        public Staff(String Name, String Post)
        {
            this.Name = Name;
            this.Post = Post;
        }

        public void displayData()
        {
            if (Post == "HOD")
            {
                Console.WriteLine("Name : " + Name + " Post : " + Post);
            }
        }
    }
    class StaffData
    {
        static void Main(string[] args)
        {
            Staff s1 = new Staff("Rishit", "Admin");
            Staff s2 = new Staff("Dev", "TA");
            Staff s3 = new Staff("Om", "HOD");
            Staff s4 = new Staff("Yash", "Dean");
            Staff s5 = new Staff("Raj", "HOD");
            s1.displayData();
            s2.displayData();
            s3.displayData();
            s4.displayData();
            s5.displayData();

        }
    }
}
