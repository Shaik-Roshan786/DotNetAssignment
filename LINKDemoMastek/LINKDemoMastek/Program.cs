using System;
using System.Linq;
using System.Collections.Generic;namespace LINQDemoMastek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] numbers = { 44, 55, 66, 77, 88, 99 };
            ////declarative
            //int[] evendata = (from n in numbers
            // where n % 2 == 0
            // select n).ToArray(); ////method
            //int[] evendatausingMethod = numbers.Where(n => n % 2 == 0).ToArray();
            //for (int i = 0; i < evendata.Length; i++)
            //{
            // Console.WriteLine(evendata[i]);
            //}
            //Console.WriteLine("\n Using Method \n");
            //for (int i = 0; i <evendatausingMethod.Length; i++)
            //{
            // Console.WriteLine(evendatausingMethod[i]);
            //}
            #endregion #region List
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { EmpNo = 101, EmpName = "bhavana", Address = "mumbai", Dept = "hr", Salary = 15000 });
            empList.Add(new Employee() { EmpNo = 102, EmpName = "amit", Address = "mumbai", Dept = "sales", Salary = 25000 });
            empList.Add(new Employee() { EmpNo = 103, EmpName = "vishal", Address = "pune", Dept = "sales", Salary = 20000 });
            empList.Add(new Employee() { EmpNo = 104, EmpName = "priya", Address = "mumbai", Dept = "hr", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 105, EmpName = "asha", Address = "mumbai", Dept = "sales", Salary = 30000 });
            empList.Add(new Employee() { EmpNo = 106, EmpName = "pankaj", Address = "pune", Dept = "hr", Salary = 35000 });
            empList.Add(new Employee() { EmpNo = 107, EmpName = "anil", Address = "mumbai", Dept = "sales", Salary = 18000 });
            empList.Add(new Employee() { EmpNo = 108, EmpName = "preeti", Address = "pune", Dept = "hr", Salary = 25000 });

            
            foreach (Employee item in empList)
{
                Console.WriteLine(item);
            }
        }
    }
}


