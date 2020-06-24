using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp14
{
    class Employees<T> where T : Employee
    {
        public List<T> employees = new List<T>();
        public Employees(List<T> employees)
        {
            this.employees = employees;
        }
        public void display()
        {
            foreach(var employee in employees)
            {
                employee.ToString();
            }
        }
        public void sort()
        {
            try
            {
                string criteria = Console.ReadLine();
                employees = employees.OrderBy(e => e.GetType().GetProperty(criteria).GetValue(e, null)).ToList();
                display();
            } catch (Exception e)
            {
                Console.WriteLine("Enter some criteria for sorting!");
            }
        }
        public void search()
        {
            string key = Console.ReadLine();
            foreach(var employee in employees)
            {
                if (employee.Name.ToString().ToLower().Contains(key.ToLower()))
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }
    }
    class Employee
    {
        string name;
        int year;
        double salary;
        public Employee()
        {
            name = "";
            year = 0;
            salary = 0;
        }
        public Employee(string name, int year, double salary)
        {
            this.name = name;
            this.year = year;
            this.salary = salary;
        }
        public string Name { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Year { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return "{Name: " + this.name + ";year:" + this.year + ";salary:" + this.salary + "}";
        }
        public static void Main(string[] args)
        {
        }
    }
}