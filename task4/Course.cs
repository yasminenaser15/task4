using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    internal class Course
    {
       
        public int CourseId { get; set; }

        public string Title { get; set; }
        public Instructor Instructor { get; set; }

        public Course(int id,string title, Instructor instructor)
        {
            CourseId = id;
            Title = title;
            Instructor = instructor;
        }

        public string PrintDetails()
        {
            return $"Course: {Title}, Instructor: {Instructor.Name}";
        }
    }
}
