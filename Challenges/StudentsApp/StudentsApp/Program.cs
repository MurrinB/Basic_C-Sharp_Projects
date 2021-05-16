using StudentsApp.Models;
using System;

namespace StudentsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var studentdb = new SchoolContext())
            {
                var student = new Student() { StudentID = 32, StudentName = "Bill"  };
                var grade = new Grade() { GradeId = 98, GradeName = "Test1", Section = "Math" };

                studentdb.Students.Add(student);
                studentdb.SaveChanges();
            }
        }
    }
}
