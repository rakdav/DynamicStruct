using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicStruct
{
    class Monitor
    {
        public string Name { get;}
        public float Diagonal { get; }
        public decimal Price { get; }

        public Monitor(string name, float diagonal, decimal price)
        {
            Name = name;
            Diagonal = diagonal;
            Price = price;
        }
    }
}
