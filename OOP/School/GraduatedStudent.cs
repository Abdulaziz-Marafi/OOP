using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.School
{
    class  GraduatedStudent : Student
    {
        string classification;
        DateOnly dateGraduated;
        
       
        public GraduatedStudent(string fName, string lName, string major, int age, double gpa, string classification, DateOnly dateGraduated): base(fName,  lName, major, age, gpa) 
        {

            this.classification = classification;
            this.dateGraduated = dateGraduated;
        }

        public void studentSummary()
        {
            Console.WriteLine("Congradulations " + this.fName + " " + this.lName + $", you graduated at {this.dateGraduated }.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Major: " + this.major);
            Console.WriteLine("GPA: " + Math.Round(this.gpa));
            Console.WriteLine("Classification Earned: "+ this.classification);
        }
    }
}
