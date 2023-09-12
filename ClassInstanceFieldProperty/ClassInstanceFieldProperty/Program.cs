namespace ClassInstanceFieldProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Name = "Onur";
            employee.Surname = "Öner";
            employee.No = 123456;
            employee.Department = "İnsan Kaynakları";

            employee.EmployeeInfo();

        }
    }
}