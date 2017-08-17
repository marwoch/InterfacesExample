using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student();
            s.StudentID = "975018367";
            s.Name = "jane programmer";
            s.Age = 45;
            Print(s);

            var s2 = new Student()
            {
                StudentID = "123456789",
                Name = "Bob Smith",
                Age = 19
            };

            List<Student> stuList = new List<Student>();
            stuList.Add(s);
            stuList.Add(s2);

            stuList.Sort();
            
            
            var f = new Food();
            f.Name = "Apple";
            f.Rating = 5.5;
            f.ExpirationDate = DateTime.Now;
            Print(f);

            Console.ReadKey();
        }

        static void Print(IDisplayable entity)
        {
            Console.WriteLine(entity.DisplayText());
        }
    }
}
