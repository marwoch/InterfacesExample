using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Food : IDisplayable, ICloneable
    {
        public string Name { get; set; }

        public DateTime ExpirationDate { get; set; }

        public double Rating { get; set; }

        public string DisplayText()
        {
            return $"The {Name} has a rating of {Rating}";
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
