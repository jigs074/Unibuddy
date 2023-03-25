using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace group13UniBuddy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            student();
            Console.WriteLine("\n");
            faculty();
            Console.WriteLine("\n");
            courses();

        }

        public static void student()
        {
            List<Student> students = new List<Student>()
              {
             new Student("Jignesh", 19, "International", "BCS", "12445", "IT"),
              new Student("Jainam", 21, "International", "BCS", "16945", "IT"),
            new Student("Akrem", 25, "Domestic", "BCS", "169695", "IT")
                };


            IIterator iterator = new StudentIterator(students);
            while (iterator.HasNext())
            {
                Student std = (Student)iterator.Next();
                Console.WriteLine("Name: " + std.Name);
            }

        }

        public static void courses()
        {
            List<Courses> courses = new List<Courses>()
              {
             new Courses("Mobile Networking"),
              new Courses("Software Design Techniques"),
            new Courses("Probability and Stats")
                };


            IIterator iterator = new CoursesIterator(courses);
            while (iterator.HasNext())
            {
                Courses course = (Courses)iterator.Next();
                Console.WriteLine("Name: " + course.Name);
            }
        }

        public static void faculty()
        {
            List<Faculty> faculties = new List<Faculty>()
              {
             new Faculty("David",23,"IT"),
              new Faculty("Jainam", 32 ,"IT"),
            new Faculty("Akrem",23,"IT")
                };


            IIterator iter = new FacultyIterator(faculties);
            while (iter.HasNext())
            {
                Faculty fac = (Faculty)iter.Next();
                Console.WriteLine("Name: " + fac.Name);
            }
        }
       

    }

}
