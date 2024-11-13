using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1=new Student("Rupesh");
            Console.WriteLine(s1.Print());
            Console.WriteLine(Student.StudCount());

        }
    }
}
