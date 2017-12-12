using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Company_Roster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var employees = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = line[0];
                var salary = decimal.Parse(line[1]);
                var position = line[2];
                var department = line[3];

                if (line.Length == 6)
                {
                    var email = line[4];
                    var age = int.Parse(line[5]);
                    var employee = new Employee(name, salary, position, department, email, age);

                    AddEmployeeToDict(employees, employee, department);

                }
                else if (line.Length == 5)
                {
                    int age;
                    var result = int.TryParse(line[4], out age);

                    if (result)
                    {
                        var employee = new Employee(name, salary, position, department, age);
                        AddEmployeeToDict(employees, employee, department);
                    }
                    else
                    {
                        var email = line[4];
                        var employee = new Employee(name, salary, position, department, email);
                        AddEmployeeToDict(employees, employee, department);
                    }
                }
                else // When lenght is 4
                {
                    var employee = new Employee(name, salary, position, department);
                    AddEmployeeToDict(employees, employee, department);
                }
            }
            //var dict = new Dictionary<string, decimal>();
            decimal totalSalary = 0;
            int count = 0;

            decimal highestAvgSalary = 0;
            string highestDeprtName = "";

            foreach (var employee in employees)
            {
                foreach (var item in employee.Value)
                {
                    totalSalary += item.Salary;
                    count++;
                }
                var avgDepartSalary = totalSalary / count;
                if (avgDepartSalary > highestAvgSalary)
                {
                    highestAvgSalary = avgDepartSalary;
                    highestDeprtName = employee.Key;
                }
                totalSalary = 0;
                count = 0;
            }

            foreach (var employee in employees)
            {
                if (highestDeprtName == employee.Key)
                {
                    Console.WriteLine($"Highest Average Salary: {highestDeprtName}");
                    foreach (var item in employee.Value.OrderByDescending(s => s.Salary))
                    {
                        Console.WriteLine($"{item.Name} {item.Salary:f2} {item.Email} {item.Age}");
                    }
                }
            }
            

        }

        private static void AddEmployeeToDict(Dictionary<string, List<Employee>> employees, Employee employee, string department)
        {
            if (!employees.ContainsKey(department))
            {
                employees.Add(department, new List<Employee>());
            }

            employees[department].Add(employee);
        }
    }
}
