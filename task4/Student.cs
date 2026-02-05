using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    internal class Student
    {

        public int StudentId { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }

        public List<Course> Courses { get; set; }

        public Student(int id, string name, int age)
        {
            StudentId = id;
            Name = name;
            Age = age;
            Courses = new List<Course>();
        }

        public bool Enroll(Course course)
        {

            if (!Courses.Contains(course))
            {
                Courses.Add(course);
                return true;
            }
            else
            {
                return false;
            }


        }

        public string PrintDetails()
        {
            string courses = "";

            if (Courses.Count == 0)
            {
                courses = "No Courses";
            }
            else
            {
                for (int i = 0; i < Courses.Count; i++)
                {
                    courses += Courses[i].Title;

                    //if (i < Courses.Count - 1)
                    //{
                    //    courses += ", ";
                    //}
                }
            }

            return $"ID: {StudentId}, Name: {Name}, Age: {Age}, Courses: {courses}";
        }


    }
}

