using EFCoreTutorials.Model;
using System;
using System.Linq;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SchoolContext())
            {
                //var std = new Student()
                //{
                //    Name = "jicwang"
                //};
                //context.Students.Add(std);
                //context.SaveChanges();
                var query = context.Students.Where(s => s.Name == "jicwang").ToList();
                foreach (var item in query)
                {
                    Console.WriteLine($"jicwang -- {item.Name}");
                }
            }
        }
    }
}
