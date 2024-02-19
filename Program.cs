using System;

namespace AbstractClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { firstName = "Sample", lastName = "Student" };
            employee.SayName();

            IQuittable quittable = employee;
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
