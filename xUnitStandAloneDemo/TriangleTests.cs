using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

using System;
using System.IO;
using Xunit;

namespace xUnitDataStructuresDemo
{

    namespace TriangleTests
    {
        public class TriangleTests
        {
            private readonly Triangle _triangle;
            private readonly IsoscelesTriangle _isoscelesTriangle;
            // private readonly IsoscelesTriangle _isoscelesTriangle2;
            private readonly StringWriter _stringWriter;

            public TriangleTests()
            {
                _triangle = new Triangle(3.0, 4.0, 5.0); // Assuming Triangle takes sides as parameters
                _isoscelesTriangle = new IsoscelesTriangle(3.0, 3.0, 2.0);
                //_isoscelesTriangle2 = new IsoscelesTriangle(5.0, 12.0, 13.0);

                _stringWriter = new StringWriter();
                _stringWriter.GetStringBuilder().Clear();
                Console.SetOut(_stringWriter);
            }


            [Fact]
            public void TestPrintCalculatedArea()
            {
                // Arrange
                var expectedOutput = "6"; // Replace with the expected area output

                var stringWriter = new StringWriter();
                stringWriter.GetStringBuilder().Clear();
                Console.SetOut(stringWriter);

                // Act
                _triangle.PrintArea();

                // Assert
                var actualOutput = stringWriter.ToString().Trim();
                Assert.Equal(expectedOutput, actualOutput);
                stringWriter.GetStringBuilder().Clear();
            }

            [Fact]
            public void TestPrintCalculatedPerimeter()
            {
                // Arrange
                var expectedOutput = "12"; // Replace with the expected perimeter output

                var stringWriter = new StringWriter();
                stringWriter.GetStringBuilder().Clear();
                Console.SetOut(stringWriter);

                // Act
                _triangle.PrintPerimeter();

                // Assert
                var actualOutput = stringWriter.ToString().Trim();
                Assert.Equal(expectedOutput, actualOutput);
                stringWriter.GetStringBuilder().Clear();
            }

            [Fact]
            public void TestImproperTriangleRepresentationException()
            {
                // Arrange
                Action act = () => new Triangle(10.0, 2.0, 2.0); // This should throw an exception

                // Assert
                Assert.Throws<ImproperTriangleRepresentation>(act);
            }


            // New tests for IsoscelesTriangle

            [Fact]
            public void TestPrintCalculatedIsoscelesArea()
            {
                // Arrange
                var expectedOutput = "2.8284271247461903"; // Replace with the expected area output

                var stringWriter = new StringWriter();
                stringWriter.GetStringBuilder().Clear();
                Console.SetOut(stringWriter);

                // Act
                _isoscelesTriangle.PrintIsoscelesArea();

                // Assert
                var actualOutput = stringWriter.ToString().Trim();
                Assert.Equal(expectedOutput, actualOutput);
                stringWriter.GetStringBuilder().Clear();
            }

            [Fact]
            public void TestPrintCalculatedIsoscelesPerimeter()
            {
                // Arrange
                var expectedOutput = "8"; // Replace with the expected perimeter output

                var stringWriter = new StringWriter();
                stringWriter.GetStringBuilder().Clear();
                Console.SetOut(stringWriter);

                // Act
                _isoscelesTriangle.PrintPerimeter();

                // Assert
                var actualOutput = stringWriter.ToString().Trim();
                Assert.Equal(expectedOutput, actualOutput);
                stringWriter.GetStringBuilder().Clear();
            }

            [Fact]
            public void TestImproperIsoscelesTriangleRepresentationException()
            {
                // Arrange
                Action act = () => new IsoscelesTriangle(5.0, 12.0, 13.0); // This should throw an exception

                // Assert
                Assert.Throws<ImproperIsoscelesTriangleRepresentation>(act);
            }
            // End of new tests for IsoscelesTriangle

        }
    }
}



