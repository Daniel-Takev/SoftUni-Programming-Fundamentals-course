using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            students = ReadStudents(studentsCount);

            var topStudents = students
                  .Where(x => x.AverageGrade >= 5.00)
                  .OrderBy(x => x.Name)
                  .ThenByDescending(x => x.AverageGrade)
                  .ToList();

            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }

        private static List<Student> ReadStudents(int studentsCount)
        {
            var students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                var currentStudent = Console.ReadLine().Split();
                var name = currentStudent[0];
                var studentGrades = new List<double>();

                studentGrades.AddRange(currentStudent.Where((x, index) => index > 0).Select(double.Parse));

                var student = new Student(name, studentGrades);

                students.Add(student);
            }

            return students;
        }
    }
}
public class Student
{
    public Student(string name, List<double> grades)
    {
        this.Name = name;
        this.Grades = grades;
    }

    public string Name { get; set; }

    public List<double> Grades { get; set; }

    public double AverageGrade
    {
        get
        {
            return this.Grades.Average();
        }
    }
}