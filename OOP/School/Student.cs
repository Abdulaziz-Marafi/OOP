using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.School
{
  public   class Student
    {
    
        protected string fName ;
        protected string lName;
        protected string major;
        protected int age;
        protected double gpa;

        public Student(string fName, string lName, string major, int age, double gpa)
        {
            this.fName = fName;
            this.lName = lName; 
            this.major = major; 
            this.age = age;
            this.gpa = gpa;
        }

        public void studentSummary()
        {
            Console.WriteLine("Welcome "+this.fName+" "+this.lName+" to the student portal.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Major: " + this.major);
            Console.WriteLine("GPA: "+ Math.Round(this.gpa));
        }

    }
}
