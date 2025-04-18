using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Project
    {
        private int passCount = 0;
        private string projectName;
        private List<Course> courses = new List<Course>();

        public Project(string projectName)
        {
            this.projectName = projectName;
        }

        public string getProjectName()
        {
            return this.projectName;
        }

        public void addCourse(Course course)
        {
            this.courses.Add(course);
        }

        public void ProjectDetails()
        {
            int count = 0;
            Console.WriteLine(projectName + ":");
            Console.WriteLine();
            for (int i = 0; i < this.courses.Count; i++)
            {
                Console.WriteLine("CourseName: " + courses[i].getName());
                Console.WriteLine("CourseMarks: " + courses[i].getMarks());
                Console.WriteLine("CourseGrade: " + courses[i].getGrades());
                Console.WriteLine();
                if (courses[i].status)
                {
                    count++;
                }
            }

            if (count >= 3)
            {
                Console.WriteLine("You have been passed");
            }
            else
            {
                Console.WriteLine("You have been failed");
            }
        }
    }
}
