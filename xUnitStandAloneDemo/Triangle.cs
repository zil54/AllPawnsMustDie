using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitDataStructuresDemo
{
    public class ImproperTriangleRepresentation : Exception
    {
        public ImproperTriangleRepresentation()

                    : base("Not all proprties of the Triangle object have been satisfied, not a valid" +
                         "representation of the Triangle")
        { }
    }
    
     public class Triangle
     {
        private double side1;
        private double side2;
        private double side3;
        public Triangle(double side1, double side2, double side3)
        {
              this.side1 = side1;
              this.side2 = side2;
              this.side3 = side3;
        if ((this.side1 >= this.side2 + this.side3) || (this.side2 >= this.side1 + this.side3) || (this.side3 >= this.side2 + this.side1))
            {
                throw new ImproperTriangleRepresentation();
            }
               
        }
        
        public double CalcPerimeter()
        {
            return side1 + side2 + side3;
        }

        public void PrintPerimeter()
        {
            Console.WriteLine(CalcPerimeter());
        }

        public double CalcArea()
        {
            double tempS = CalcPerimeter() / 2;
            double area = Math.Sqrt(tempS * (tempS - side1) * (tempS - side2) * (tempS - side3));
            return area;
        }

        public void PrintArea()
        {
            Console.WriteLine(CalcArea());
        }

    }
}
