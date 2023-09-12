using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLesson
{
    public class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public Employee() { }
        public Employee(string name, string surname, int no, string Department)
        {
            this.Name = name;
            this.Surname = surname;
            this.No = no;
            this.Department = Department;
        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public void EmployeeInfo()
        {
            Console.WriteLine($"Çalışanın Adı: {Name}");
            Console.WriteLine($"Çalışanın Soyadı: {Surname}");
            Console.WriteLine($"Çalışanın Numarası: {No}");
            Console.WriteLine($"Çalışanın Departmanı: {Department}");
        }
    }
}
