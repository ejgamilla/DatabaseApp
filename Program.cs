using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            context.Database.EnsureCreated();

            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe"
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }
    }
}
