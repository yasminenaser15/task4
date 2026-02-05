using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    internal class School
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();

        public bool AddStudent(Student student)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentId == student.StudentId)
                {
                    return false;
                }
            }
            Students.Add(student);
            return true;
        }
        public bool AddCourse(Course course)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseId == course.CourseId)
                {
                    return false;
                }
            }
            Courses.Add(course);
            return true;
        }
        public bool AddInstructor(Instructor instructor)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].InstructorId == instructor.InstructorId)
                {
                    return false;
                }
            }
            Instructors.Add(instructor);
            return true;
        }

        public Student FindStudent(int id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].StudentId == id)
                {
                    return Students[i];
                }
            }
            return null;
        }

        public Course FindCourse(int id)
        {
            for (int i = 0; i < Courses.Count; i++)  
            {
                if (Courses[i].CourseId == id)
                {
                    return Courses[i];
                }
            }
            return null;
        }


        public Instructor FindInstructor(int instructorId)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].InstructorId == instructorId)
                {
                    return Instructors[i];
                }
            }
            return null;
        }


        public bool EnrollStudentInCourse(int studentId, int CourseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(CourseId);

            if (student == null || course == null)
            {
                return false;
            }
             return student.Enroll(course); 
        }


        public bool ISEnrollStudentInCourse(int studentId, int CourseId)
        {
            Student student = FindStudent(studentId);
            

            if (student == null)
            {
                return false;
            }

             for(int i = 0; i < student.Courses.Count; i++)
            {
                if (student.Courses[i].CourseId== CourseId)
                {
                    return true;
                }

            }

             return false;
        }

        public string GetInstructorNameByCourseTitle(string courseTitle)
        {
            for (int i = 0; i < Courses.Count; ++i)
            {
                if (Courses[i].Title == courseTitle)
                {
                    if (Courses[i].Instructor != null)
                    {
                        return Courses[i].Instructor.Name;
                    }
                }
            }
            return "course not found";
        }





    }
}
