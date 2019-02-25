using System;
using Models;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student student = new Student() {
                StudentId="A00123456",
                FirstName="Jane",
                LastName="Bond"
            };

            Console.WriteLine(student);
        }
    }
}
