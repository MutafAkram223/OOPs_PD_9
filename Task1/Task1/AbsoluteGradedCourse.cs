using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class AbsoluteGradedCourse : Course
    {
        public AbsoluteGradedCourse(string name, int marks) : base(name, marks)
        {
            if (grades == "F")
            {
                status = false;
            }
        }
        public override string giveGradefromMarks(int marks)
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
