using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[5];
            for (int i = 0; i < s.Length; i++)
            {
                int rollNo= Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                decimal marks = Convert.ToDecimal(Console.ReadLine());
                 
                Student s1 = new Student(rollNo,name, marks);
                s[i] = s1;
            }

           
            for (int i = 0; i < s.Length; i++)
            {
                s[i].Display();
            }


            Console.ReadLine();
        }
    }

    struct Student
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                    Console.WriteLine("invalid name");
            }
        }


        private static int count = 0;
        private int rollNo;

        public int RollNo
        {
            get
            {

                return rollNo;
            }
            set
            {
                rollNo = value;
            }
        }


        private decimal marks;
        public decimal Marks
        {
            get
            {
                return marks;
            }
            set
            {
               
                    marks = value;
                
            }
        }

        public Student(int RollNo, string Name, decimal Marks):this()
        {
            this.Marks = Marks;
            this.RollNo = RollNo;
            this.Name = Name;
        }

        public void Display()
        {
            Console.WriteLine(RollNo + " " + Name + " " + Marks);
        }
    }
}
