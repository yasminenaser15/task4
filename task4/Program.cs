using System.Diagnostics;
using System.Xml.Serialization;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            int choice;
            do
            {
                Console.WriteLine("\n1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find Student by ID");
                Console.WriteLine("9. Find Course by ID");
                Console.WriteLine("10. Check if student enrolled in course");
                Console.WriteLine("11. Get instructor name by course title");
                Console.WriteLine("12. Exit");
                Console.WriteLine(" What is Your Choice ? ");


                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice){
                    case 1:
                        Console.WriteLine("Enter Student Id");
                        int studentid=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        string name=Console.ReadLine();
                        Console.WriteLine("enter Age");
                        int age=Convert.ToInt32(Console.ReadLine());
                        school.AddStudent(new Student(studentid, name, age));
                        break;

                        case 2:
                        Console.Write("Instructor ID: ");
                        int iid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name: ");
                        string iname = Console.ReadLine();
                        Console.Write("Specialization: ");
                        string spec = Console.ReadLine();

                        school.AddInstructor(new Instructor(iid, iname, spec));
                        break;


                    case 3:
                        Console.WriteLine("Enter Course Id");
                        int courseid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Instructor ID: ");
                        int instId = Convert.ToInt32(Console.ReadLine());
                        Instructor instructor=school.FindInstructor(instId);
                        if (instructor != null)
                        {
                            school.AddCourse(new Course(courseid, title, instructor));
                        }
                        else
                        {

                            Console.WriteLine("instructor not found");
                        }
                        break;

                        case 4:
                        Console.Write("Student ID: ");
                        int stId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Course ID: ");
                        int coId = Convert.ToInt32(Console.ReadLine());
                        if (!school.EnrollStudentInCourse(stId, coId))
                        {
                            Console.WriteLine("cant enroll this student in course");
                        }
                        else
                        {
                            Console.WriteLine("student enrolled successfully in course");
                        }

                            break; 

                        case 5:

                        for(int i = 0; i < school.Students.Count; i++)
                        {
                            Console.WriteLine(school.Students[i].PrintDetails());
                        }
                        break ;

                        case 6:
                        for (int i = 0; i < school.Courses.Count; i++)
                        {
                            Console.WriteLine(school.Courses[i].PrintDetails());
                        }
                        break;

                        case 7:
                        for (int i = 0; i < school.Instructors.Count; i++)
                        {
                            Console.WriteLine(school.Instructors[i].PrintDetails());
                        }
                        break;

                    case 8:
                        Console.Write("Student ID: ");
                        int stutId = Convert.ToInt32(Console.ReadLine());
                        var student = school.FindStudent(stutId);

                        if (student == null)
                        {
                            Console.WriteLine("Not found");
                        }
                        else
                        {
                            Console.WriteLine(student.PrintDetails());
                        }
                        break;

                    case 9:
                        Console.Write("Enter Course ID: ");
                        int courid = Convert.ToInt32(Console.ReadLine());
                        var course = school.FindCourse(courid);

                        if (course == null)
                        {
                            Console.WriteLine("Not found");
                        }
                        else
                        {
                            Console.WriteLine(course.PrintDetails());
                        }
                        break;

                    case 10:

                        Console.Write("Student ID: ");
                        int sid = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Course ID: ");
                        int cid = Convert.ToInt32(Console.ReadLine());

                        if (school.ISEnrollStudentInCourse(sid, cid))
                            Console.WriteLine("Student is enrolled in this course");
                        else
                            Console.WriteLine("Student is NOT enrolled in this course");
                        break;

                        case 11:
                        Console.Write("Course Title: ");
                        string tit = Console.ReadLine();

                        string instructorName = school.GetInstructorNameByCourseTitle(tit);
                        Console.WriteLine("Instructor Name: " + instructorName);
                        break;



                }

            } while (choice != 12);
        }
    }
}
