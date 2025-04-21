using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SolidPrincplesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Mohammad - Alkhazaleh";
            student.Grade = 99;

            var SavedData = new DataBase();
            var Report = new Reports();

            SavedData.SaveToDataBase(student);
            Report.PrintReport(student);
        }
    }
    
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student()
        {

        }
       public Student(string name,int grade)
        {
            Name = name;
            Grade = grade;
        }

    }
    public class DataBase
    {
        public  void SaveToDataBase(Student student)
        {
            Console.WriteLine("Saving " + student.Name + " to database...");
        }
    }
    public class Reports
    {
        public  void PrintReport(Student student)
        {
            Console.WriteLine("Printing report for " + student.Name);
            Console.WriteLine("Grade : " + student.Grade);
        }
    }

}

