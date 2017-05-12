﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");

            Employee emp = new Employee("Marvin", 456, 30000);

            // NOPE.
            //emp.empName = "Marv";

            emp.GiveBonus(1000);
            emp.DisplayStats();

            //emp.SetName("Marv");
            //Console.WriteLine("Employee is named: {0}", emp.GetName());

            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);

            Console.ReadLine();
        }
    }
}
