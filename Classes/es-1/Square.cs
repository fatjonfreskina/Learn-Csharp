using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Square
    {
        public float Area {get; private set;}
        public float SideLength {get; private set;}

        public Square(float sideLength)
        {
            this.SideLength = sideLength;
            CalculateArea();
        }

        private void CalculateArea()
        {
            Area = SideLength*SideLength;
        }

        public string PrintSquare()
        {
            return "Side: " + string.Format("{0:N1}", SideLength) + "; Area: " + string.Format("{0:N1}", Area);
        }
    }
}