using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Student
    {
        private string name;
        private int Rollno;
        private static int count;


        static Student()
        {
             count = 0;
        }
        public Student(string name)
        {
            count++;
            Rollno = count;
            this.name = name;
        }
        public string Print()
        {
            return $"{Rollno},{name}";
        }
        public static int StudCount()
        {
            return count;
        }
    }
}
