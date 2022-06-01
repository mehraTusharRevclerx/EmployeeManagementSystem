using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        string name;
        string employeeId;
        string designation;
        string bloodGroup;
        string mobileNo;

    }
    internal class Program
    {
        static void Main()
        {
            UserInput();
        }


        static void UserInput()
        {

            Console.WriteLine("Welcome To Employee Management System");
            Console.WriteLine($"\nHow Many Employye You Want To Add?");
            string numm1 = Console.ReadLine();
            int num1;
            while (!int.TryParse(numm1, out num1))
            {
                Console.WriteLine("Please Enter Details In The Correct Format(IN NUMBERS)!");
                numm1 = Console.ReadLine();
            }

            for (int i = 1; i <= num1; i++)
            {

                Console.WriteLine($"Please Enter The Details of Employee {i}");
                Console.Write("Please Enter Name: ");
                string employeeName = Console.ReadLine();
                while (string.IsNullOrEmpty(employeeName))
                {
                    Console.WriteLine("Please Enter Name In The Correct Format!");
                    employeeName = Console.ReadLine();
                }

                Console.Write("Please Enter Employee Id: ");
                string employeeIdd = Console.ReadLine();
                while (!int.TryParse(employeeIdd, out int employeeId))
                {
                    Console.WriteLine("Please Enter Employee ID In The Correct Format!");
                    employeeIdd = Console.ReadLine();
                }

                Console.Write("Please Enter Employee Desigination: ");
                string employeeDes = Console.ReadLine();
                while (string.IsNullOrEmpty(employeeDes))
                {
                    Console.WriteLine("Please Enter Employee Desigination In The Correct Format!");
                    employeeDes = Console.ReadLine();
                }


                Console.Write("Please Enter Employee Blood Group: ");
                string employeeBG = Console.ReadLine();
                while (string.IsNullOrEmpty(employeeBG))
                {
                    Console.WriteLine("Please Enter Employee Blood Group In The Correct Format!");
                    employeeBG = Console.ReadLine();
                }

                Console.Write("Please Enter Employee Mobile No: ");
                string employeeNoo = Console.ReadLine();
                while (!int.TryParse(employeeNoo, out int employeeNo))
                {
                    Console.WriteLine("Please Enter Employee ID In The Correct Format!");
                    employeeNoo = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
