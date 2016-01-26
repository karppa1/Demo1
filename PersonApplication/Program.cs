using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somebody = new Person();
            somebody.FirstName = "John";
            somebody.LastName = "Unknown";
            somebody.Address = "Unknown";
            somebody.Age = 29;
            somebody.PhoneNumber = "123-123456";            
            Console.WriteLine(somebody.ToString());

            Teacher teacher = new Teacher();
            teacher.FirstName = "Ope";
            teacher.LastName = "Opettaja";
            teacher.Address = "Koulukatu";
            teacher.Age = 35;
            teacher.PhoneNumber = "090-098765";
            teacher.Room = "1";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Olli","Opiskelija","S1234");            
            student.Address = "Koulukatu2";
            student.Age = 30;
            student.PhoneNumber = "040-4756438";            
            Console.WriteLine(student.ToString());

            somebody.PersonMethod();
            teacher.PersonMethod();
            teacher.TeacherMethod();
            student.PersonMethod();
            student.StudentMethod();

            Console.ReadLine();
        }
    }
}
