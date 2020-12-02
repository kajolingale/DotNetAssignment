using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralManager e1 = new GeneralManager("kajol", 10, 12000.0m, "HR", "hhhh");
            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e1.Name);
            Console.WriteLine(e1.DeptNo);
            Console.WriteLine(e1.Basic);
            Console.WriteLine(e1.CalcNetSalary());
            Console.WriteLine(e1.Designation);
            Console.WriteLine(e1.Perks);
            Console.WriteLine("==================");
            GeneralManager e2 = new GeneralManager("ram", 20, 13000.0m, "cs", "hhhh");
            Console.WriteLine(e2.EmpNo);
            Console.WriteLine(e2.Name);
            Console.WriteLine(e2.DeptNo);
            Console.WriteLine(e2.Basic);
            Console.WriteLine(e2.CalcNetSalary());
            Console.WriteLine(e2.Designation);
            Console.WriteLine(e2.Perks);
            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(e2.EmpNo);
            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        private string name;
        public string Name
        {
            set
            {
                if(value != "")
                    name = value;
                else
                    Console.WriteLine("invalid");
            }
            get
            {
                return name;
            }
        }

        private static int count=0;
        private int empNo;
        public int EmpNo
        {
            private set
            {
                empNo=value;
            }
            get
            {
                return empNo;
            }
        }

        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("invalid");
            }
            get
            {
                return deptNo;
            }
        }

        //private decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
        }

        public abstract decimal CalcNetSalary();

        public Employee(string Name, short DeptNo, decimal Basic)
        {
            count++;
            EmpNo = count;
            this.Basic = Basic;
            this.Name = Name;
            this.DeptNo = DeptNo;
        }
    }

    class Manager : Employee
    {
        private string designation;
        public string Designation
        {
            set
            {
                if (value != "")
                    designation = value;
                else
                    Console.WriteLine("invalid");
            }
            get
            {
                return designation;
            }
        }

        private decimal basic;
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }
        public Manager(string Name, short DeptNo, decimal Basic, string Designation):base(Name, DeptNo, Basic)
        {
            this.Designation = Designation;
        }
        public override decimal CalcNetSalary()
        {
            decimal salary = Basic * 12;
            return salary;
        }
    }

    class GeneralManager : Manager
    {
        private string perks;
        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }

        public GeneralManager(string Name, short DeptNo, decimal Basic, string Designation, string Perks):base(Name,DeptNo,Basic,Designation)
        {
            this.Perks = Perks;
        }
    }

    class CEO : Employee
    {
        public sealed override decimal CalcNetSalary()
        {
            throw new NotImplementedException();
        }
        private decimal basic;
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                basic = value;
            }
        }
        public CEO(string Name, short DeptNo, decimal Basic) :base(Name, DeptNo, Basic)
        {

        }
    }
}

