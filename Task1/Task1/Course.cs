using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Course
    {
        public bool status = true;
        protected string name;
        protected int marks;
        protected string grades;

        public Course(string name, int marks)
        {
            this.name = name;
            this.marks = marks;
            this.grades = giveGradefromMarks(marks);
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setMarks(int marks)
        {
            marks = this.marks;
        }

        public int getMarks()
        {
            return this.marks;
        }

        public void setGrades(int marks)
        {
            this.grades = giveGradefromMarks(marks);
        }

        public string getGrades()
        {
            return this.grades;
        }

        public virtual string giveGradefromMarks(int marks)
        {
            if (marks >= 90 && marks <= 100)
            {
                return "A+";
            }
            else if (marks >= 80 && marks < 90)
            {
                return "A";
            }
            else if (marks >= 70 && marks < 80)
            {
                return "B";
            }
            else if (marks >= 60 && marks < 70)
            {
                return "C";
            }
            else if (marks >= 50 && marks < 60)
            {
                return "D";
            }
            else if (marks >= 0 && marks < 50)
            {
                return "F";
            }
            else
            {
                return "";
            }
        }
    }
}
