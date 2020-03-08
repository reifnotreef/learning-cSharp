using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public List<double> grades;
        private string name;
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 & grade <= 100)
            {
                grades.Add(grade);
            }
        }
    }
}