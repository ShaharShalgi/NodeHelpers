using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodeClass;

namespace NodeInserts
{
    public class Student
    {
        private string name;
        private int ID;
        private int year;
        private Node<Grade> grades;
        public Student(string name, int iD, int year, Node<Grade> grades)
        {
            this.name = name;
            this.ID = iD;
            this.year = year;
            this.grades = grades;
        }
        public Node<Grade> GetGrades() { return grades; }
        public string GetName() { return name; } }

    }
}
