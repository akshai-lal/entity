using EFCodeFirstDemo.Data;
using EFCodeFirstDemo.Models;
using System;

namespace EFCodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new SchoolContext())
            //{
            //    var student = new Student
            //    {
            //        FirstName = "John",
            //        LastName = "Doe",
            //        EnrollmentDate = DateTime.Now
            //    };

            //    var course = new Course
            //    {
            //        Name = "Mathematics",
            //        Credit = 4
            //    };

            //    context.Students.Add(student);
            //    context.Courses.Add(course);
            //    context.SaveChanges();

            //    Console.WriteLine("Data added successfully!");
            //}

            using (var context =new SchoolContext())
            {
                var students = context.Students.Where(s => s.StudentId == 1).ToList();
                foreach(var s in students)
                {
                    Console.WriteLine($"Id : {s.StudentId}, Name : {s.FirstName} {s.LastName}, Enrollment Date : {s.EnrollmentDate.ToShortDateString()}");
                }
            }
        }
    }
}
