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
            List<int> someList = new List<int>();
            int[] nums = { 2, 4, 6, 8, 10 };
            someList.AddRange(nums);

            var db = new DatabaseManager();
            try
            {
                db.OpenConnection();
                //do something w/ db
            }
            finally
            {
                db.CloseConnection();
            }

            using (var db2 = new DatabaseManager())
            {
                db2.OpenConnection();
                //do db stuffs

            }//Dispose() is called , and resources are cleaned up

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

            var sortedList = stuList
                .OrderBy(stu => stu.Age)
                .ToList();


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
