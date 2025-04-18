using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class GradedCourse : Course
    {
        public GradedCourse(string name, int marks) : base(name, marks) 
        {
            if (grades == "0" || grades == "-3")
            {
                status = false;
            }
        }

        public new void setName(string name)
        {
            this.name = name;
        }

        public new string getName()
        {
            return this.name;
        }

        public new void setMarks(int marks)
        {
            marks = this.marks;
        }

        public new int getMarks()
        {
            return this.marks;
        }

        public new void setGrades(int marks)
        {
            this.grades = giveGradefromMarks(marks);
        }

        public new string getGrades()
        {
            return this.grades;
        }
        public override string giveGradefromMarks(int marks)
        {
            if (marks >= 90 && marks <= 100)
            {
                return "12";
            }
            else if (marks >= 80 && marks < 90)
            {
                return "10";
            }
            else if (marks >= 70 && marks < 80)
            {
                return "7";
            }
            else if (marks >= 60 && marks < 70)
            {
                return "4";
            }
            else if (marks >= 50 && marks < 60)
            {
                return "2";
            }
            else if (marks >= 40 && marks < 50)
            {
                return "0";
            }
            else if (marks >= 0 && marks < 40)
            {
                return "-3";
            }
            else
            {
                return "";
            }
        }
    }
}
