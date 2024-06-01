using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    class Student
    {
        public int StudentNo { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public int AbsenceCount { get; set; }
        public bool HasDuty { get; set; }

        public Student(int studentNo, string name, double gpa, int absenceCount, bool hasDuty)
        {
            StudentNo = studentNo;
            Name = name;
            GPA = gpa;
            AbsenceCount = absenceCount;
            HasDuty = hasDuty;
        }
    }
}
