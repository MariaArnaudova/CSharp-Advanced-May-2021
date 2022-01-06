using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {

        private List<Employee> employees;
        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            employees = new List<Employee>();
        }

        //	Getter Count – returns the number of employees.
        public int Count => employees.Count();
        public string Name { get; set; }
        public int Capacity { get; set; }


        // Method Add(Employee employee) – adds an entity to the data if there is room for him/her
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        //	Method Remove(string name) – removes an employee by given name, if such exists, and returns bool.

        public bool Remove(string name)
        {
            bool isExist = employees.Exists(x => x.Name == name);
            if (isExist)
            {
                Employee employeeToRemove = employees.FirstOrDefault(x => x.Name == name);
                employees.Remove(employeeToRemove);
                return true;
            }
            return false;
        }

        // Method GetOldestEmployee() – returns the oldest employee
        public Employee GetOldestEmployee()
        {
            //Employee oldestEmployee = employees.Find(x=> x.Age== employees.Select(x => x.Age).ToList().Max());
            Employee oldestEmployee = employees.OrderBy(x => x.Age).Last();
            return oldestEmployee;
        }

        //	Method GetEmployee(string name) – returns the employee with the given name.
        public Employee GetEmployee(string name)
        {
            Employee foundEmployee = employees.FirstOrDefault(x => x.Name == name);
            return foundEmployee;
        }

        // 	Report() – returns a string in the following format:

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}:");

            foreach (var currentEmpployee in employees)
            {
                sb.AppendLine(currentEmpployee.ToString());
            }
           return  sb.ToString().TrimEnd();
        }
    }
}
