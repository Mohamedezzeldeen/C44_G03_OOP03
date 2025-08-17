using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03.Company
{
    public class Employee
    {
        private int Id { get; set; }
        private string? Name { get; set; }
        private SecurityLevel SecurityLevel { get; set; }
        private decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        private Gender Gender;

        public Employee(int id, string? name, SecurityLevel security, decimal salary, HiringDate hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public Gender MyProperty
        {
            get { return Gender; }
            set
            {
                if (value == Gender.M || value == Gender.F)
                    Gender = value;
                else
                    Console.WriteLine("Enter M Or F Only");
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nSecurity: {SecurityLevel}\nSalary: {Salary}\nHire Date: {HireDate:yyyy-MM-dd}\nGender: {Gender}";
        }
    }
}
