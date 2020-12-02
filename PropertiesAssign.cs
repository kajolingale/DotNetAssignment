﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Kajol", 12000, 10);

            //e1.Name = "Kajol";
            Console.WriteLine("Emp No = " + e1.EmpNo);
            Console.WriteLine("Name = " + e1.Name);
            //e1.Basic = 12000.0m;
            Console.WriteLine("Basic = " + e1.Basic);
            ////Console.WriteLine("Name = " + e1.Name);
            //e1.DeptNo = 1;
            Console.WriteLine("Dept No.= " + e1.DeptNo);
            Console.WriteLine("Salary = " + e1.GetNetSalary());
            Console.WriteLine("==============================");
            Employee o2 = new Employee("Amol", 12346);
            Console.WriteLine("Emp No = " + o2.EmpNo);
            Console.WriteLine("Name = " + o2.Name);
            Console.WriteLine("Basic = " + o2.Basic);
            Console.WriteLine("Salary = " + o2.GetNetSalary());
            Console.WriteLine("==============================");
            Employee o3 = new Employee("Amol");
            Console.WriteLine("Emp No = " + o3.EmpNo);
            Console.WriteLine("Name = " + o3.Name);
            Console.WriteLine("==============================");
            Console.WriteLine(e1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(e1.EmpNo);
            Console.ReadLine();
        }
    }

    class Employee
    {
        //Properties
        // ----------
        //string Name -> no blank names should be allowed
        // int EmpNo -> must be readonly and autogenerated
        // decimal Basic -> must be between some range
        // short DeptNo -> must be > 0
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
        private int empNo;

        public int EmpNo
        {
            get
            {

                return empNo;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if (value > 1000.0m || value < 50000.0m)
                    basic = value;
                else
                    Console.WriteLine("invalid");
            }
        }

        private short deptNo;
        public short DeptNo
        {
            get
            {
                return deptNo;
            }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("invalid");
            }
        }

        public decimal GetNetSalary()
        {
            return basic * 12.0m;
        }
        public Employee(string Name, decimal Basic, short DeptNo)
        {

            count++;
            this.empNo = count;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
        public Employee(string Name, decimal Basic)
        {
            count++;
            this.empNo = count;
            this.Name = Name;
            this.Basic = Basic;
        }

        public Employee(string Name)
        {
            count++;
            this.empNo = count;
            this.Name = Name;
        }
        public Employee()
        {
            count++;
            this.empNo = count;
        }

    }

}