namespace EncapsulationAndProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Onur";
            student.Surname = "Öner";
            student.StudentNo = 12345;
            student.Classroom = 3;
            student.GetStudentInfo();
            student.IncreaseClassroom();
            student.GetStudentInfo();

            Student student2 = new Student("Akın","Öner",54321,1);
            student2.DecreaseClassroom();
            student2.DecreaseClassroom();
            student2.GetStudentInfo();
        }
    }
}