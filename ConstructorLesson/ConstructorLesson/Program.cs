namespace ConstructorLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Onur";
            employee1.Surname = "Öner";
            employee1.No = 123456;
            employee1.Department = "İnsan Kaynakları";
            Console.WriteLine("*****Çalışan 1*****");
            employee1.EmployeeInfo();
            Console.WriteLine("\n");

            Employee employee2 = new Employee("Akın","Öner",654321,"Arge");
            Console.WriteLine("*****Çalışan 2*****");
            employee2.EmployeeInfo();
            Console.WriteLine("\n");

            Employee employee3 = new Employee("Ahmet", "Yılmaz");
            Console.WriteLine("*****Çalışan 3*****");
            employee3.EmployeeInfo();
            Console.WriteLine("\n");
        }
    }
}