using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndProperty
{
    public class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int classroom;

        

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int Classroom { 
            get => classroom;
            set { 
                if(value < 1)
                {
                    Console.WriteLine("Sınıf 1'den küçük olamaz.");
                    classroom = 1;
                }
                else
                {
                    classroom = value;
                }
            } 
        }

        public Student(string name, string surname, int studentNo, int classroom)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            Classroom = classroom;
        }

        public Student() { }

        public void GetStudentInfo()
        {
            Console.WriteLine("*****Öğrenci Bilgileri*****");
            Console.WriteLine($"Öğrencinin Adı: {Name}");
            Console.WriteLine($"Öğrencinin Soyadı: {Surname}");
            Console.WriteLine($"Öğrencinin Numarası: {StudentNo}");
            Console.WriteLine($"Öğrencinin Sınıfı: {Classroom}");
            Console.WriteLine("\n");
        }
        public void IncreaseClassroom()
        {
            this.Classroom += 1;
        }

        public void DecreaseClassroom()
        {
            this.Classroom -= 1;
        }
    }
}
