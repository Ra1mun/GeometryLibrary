using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double CalculateArea()
        { 

            if (isPossibleTriangle())
            {
                throw new NotImplementedException("Triangle is imposible");
            }

            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool isRectangular()
        {
            if (isPossibleTriangle())
            {
                throw new NotImplementedException("Triangle is imposible");
            }

            return (SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA);
        }

        private bool isPossibleTriangle()
        {
            double a2 = SideA * SideA;
            double b2 = SideB * SideB;
            double c2 = SideC * SideC;

            return a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2;
        }
    }
}
