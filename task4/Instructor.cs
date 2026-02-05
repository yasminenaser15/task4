using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    internal class Instructor
    {
        public Instructor(int instructorId, string name, string specialization)
        {
            InstructorId = instructorId;
            Name = name;
            Specialization = specialization;
        }

        public int  InstructorId { get; set; }
        public string Name { get; set; }    
        public string Specialization { get; set; }


        public string PrintDetails()
        {
            return $"Name:{Name}, Specialization: {Specialization}";
        }
    }
}
