﻿using System;
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
            Student students = new Student();
            
            //List<Student> students = new List<Student>();
            students.addStudent(new Student("Jignesh", 19, "International", "BCS", "12445", "IT"));
            students.addStudent(new Student("Jainam", 21, "International", "BCS", "16945", "IT"));
            students.addStudent(new Student("Akrem", 25, "Domestic", "BCS", "169695", "IT"));
            /* Student s1 = new Student("Jignesh",19,"International","BCS","12445", "IT");

             Student s2 = new Student("Jainam", 21, "International", "BCS", "16945", "IT");

             Student s3 = new Student("Akrem",25, "Domestic", "BCS", "169695", "IT");
            s1.addStudent(s1);
            s2.addStudent(s2);
            s3.addStudent(s3);*/
            
            IIterator iterator = students.CreateIterator();
            while(iterator.HasNext())
            {
                Student std = (Student)iterator.Next();
                Console.WriteLine($"Name: {std.Name}, Student Number: {std.StudentNo}");
            }


            



        }

    }

}
