using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class Grade
    {
        private int grade;
        private int CourseID;
        public Grade(int grade, int courseID)
        {
            this.grade = grade;
            CourseID = courseID;
        }
        public int GetGrade() { return grade; }
    }
}
