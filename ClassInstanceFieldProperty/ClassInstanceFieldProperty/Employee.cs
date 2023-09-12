using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstanceFieldProperty
{
    public class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;

        public void EmployeeInfo()
        {
            Console.WriteLine($"Çalışanın Adı: {Name}");
            Console.WriteLine($"Çalışanın Soyadı: {Surname}");
            Console.WriteLine($"Çalışanın Numarası: {No}");
            Console.WriteLine($"Çalışanın Departmanı: {Department}");
        }
    }
}
