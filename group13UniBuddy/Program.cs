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

    }

}
