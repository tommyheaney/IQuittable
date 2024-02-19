using System;

namespace AbstractClassesAssignment
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has quit the job.");
        }
    }
}
