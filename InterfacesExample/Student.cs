using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Student : IDisplayable, IComparable<Student>
    {
        public string StudentID { get; set; }

        public string Name { get; set; }

        public byte Age { get; set; }

        public string DisplayText()
        {
            return $"{StudentID}: {Name}";
        }

        int IComparable<Student>.CompareTo(Student other)
        {
            if (other == null)
            {
                return 1;
            }
            if (this.Age > other.Age)
            {
                return 1;
            }
            else if (this.Age == other.Age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
