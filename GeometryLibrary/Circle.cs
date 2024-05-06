using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            if (Radius < 0)
            {
                throw new ArgumentException("Radius can't be negative!");
            }

            return Math.PI * Radius * Radius;
        }
    }
}
