﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static group13UniBuddy.Clubs;

namespace group13UniBuddy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
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
            
            /*  {
             new Courses("Mobile Networking"),
              new Courses("Software Design Techniques"),
            new Courses("Probability and Stats")
                };*/


            IIterator iterator = new CoursesIterator(courses);
            while (iterator.HasNext())
            {
                Courses course = (Courses)iterator.Next();
                Console.WriteLine("Name: " + course.Name);
            }
        }

        public static void clubs()
        {
            List<Clubs> clubs = new List<Clubs>()
            {
                new Clubs("Google Devs","Research Club"),
              new Clubs ("Awareness Initiative","Community Club"),
            new Clubs("Spirit Up","Sports Club")
            };

            IIterator iterator = new ClubsIterator(clubs);
            while (iterator.HasNext())
            {
                Clubs club = (Clubs)iterator.Next();
                Console.WriteLine("Name: " + club.ClubName);
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

        public static void recreeation()
        {
            string[] activityNames = { "BasketBall", "Football", "Baseball", "Tennis" };

            // Create an activity object for each activity name and print the details
            foreach (string activityName in activityNames)
            {
                Activity activity = new Activity(activityName);
                Console.WriteLine($"Activity: {activity.Name}, Scheduled Time: {activity.ScheduledTime}");
            }

            Console.ReadLine();
        }
       
        public static void Department()
        {
            List<Department> departments = new List<Department>();
            Department department1 = new Department("Computer Science");
            Department department2 = new Department("IT");
            departments.Add(department1);
            departments.Add(department2);
            Console.WriteLine(department1.departmentName);
            Console.WriteLine(department2.departmentName); 



        }

    }

}
