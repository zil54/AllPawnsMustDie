using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace xUnitDataStructuresDemo
{
    public class ImproperTriangleRepresentation : Exception
    {
        public ImproperTriangleRepresentation()

                    : base("Not all properties of the Triangle object have been satisfied, not a valid " +
                         "representation of the Triangle")
        { }
    }

    public class ImproperIsoscelesTriangleRepresentation : Exception
    {
        public ImproperIsoscelesTriangleRepresentation()
                    : base("Two side equality of the isosceles triangle object have not been satisfied, not a valid " +
                         "representation of the Isosceles Triangle")
        { }
    }

    public class ImproperEqTriangleRepresentation : Exception
    {
        public ImproperEqTriangleRepresentation()

                    : base("All side equality of the equilateral triangle object have not been satisfied, not a valid " +
                         "representation of the Eq. Triangle")
        { }
    }



    public class Triangle
    {
        protected double side1;
        protected double side2;
        protected double side3;
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

    public class IsoscelesTriangle : Triangle
    {
        double iso_side1;
        double iso_side2;
        double iso_side3;
        public IsoscelesTriangle(double side1, double side2, double side3)
            : base(side1, side2, side3)
        {
            iso_side1 = side1;
            iso_side2 = side2;
            iso_side3 = side3;

            if (!((iso_side1.Equals(iso_side2)) || (iso_side1.Equals(iso_side3)) || (iso_side2.Equals(iso_side3))))
            {
                throw new ImproperIsoscelesTriangleRepresentation();
            }
        }

        public new double CalcPerimeter()
        {
            return iso_side1 + iso_side2 + iso_side3;
        }

        public double CalcIsoscelesArea()
        {
            return CalcArea();
        }

        public new void PrintPerimeter()
        {
            Console.WriteLine(CalcPerimeter());
        }

        public void PrintIsoscelesArea()
        {
            Console.WriteLine(CalcIsoscelesArea());
        }
    }

    public class EquilateralTriangle : Triangle
    {
        double eq_side1;
        double eq_side2;
        double eq_side3;
        public EquilateralTriangle(double side1, double side2,double side3)
            : base(side1, side2, side3)
        {
            eq_side1 = side1;
            eq_side2 = side2;
            eq_side3 = side3;

            if (! (eq_side1.Equals(eq_side2)) || (! eq_side2.Equals(eq_side3)))
            {
                throw new ImproperEqTriangleRepresentation();
            }
        }

        public new double CalcPerimeter()
        {
            double eq_side = eq_side1;
            return eq_side * 3;
        }

        public double CalcEqArea()
        {
            return CalcArea();
        }

        public new void PrintPerimeter()
        {
            Console.WriteLine(CalcPerimeter());
        }

        public void PrintEqArea()
        {
            Console.WriteLine(CalcEqArea());
        }


    }
}


  
