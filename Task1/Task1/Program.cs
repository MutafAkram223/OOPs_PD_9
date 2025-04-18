using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Project obj1 = new Project("Research Project");

            obj1.addCourse(new AbsoluteGradedCourse("Research methods", 10));
            obj1.addCourse(new AbsoluteGradedCourse("Literature Review", 80));
            obj1.addCourse(new GradedCourse("Statistical Analysis", 100));
            obj1.addCourse(new GradedCourse("Research Findings Presentation", 90));

            obj1.ProjectDetails();
            Console.ReadKey();
        }
    }
}
