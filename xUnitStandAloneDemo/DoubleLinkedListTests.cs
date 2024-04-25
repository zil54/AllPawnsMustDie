using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using xUnitStandAloneDemo;

namespace xUnitDataStructuresDemo
{
    namespace DoubleLinkedListTests
    {
        public class DoubleLinkedListTests
        {

            private readonly ITestOutputHelper output;

            public DoubleLinkedListTests(ITestOutputHelper output)
            {
                this.output = output;
            }
            [Fact]
            public void AddFirst_AddsElementToEmptyList()
            {
                // Arrange
                var list = new DoublyLinkedList<int>();

                // Act
                list.AddFirst(1);

                // Assert
                Assert.NotNull(list.Find(1));
            }

            [Fact]
            public void AddLast_AddsElementToEmptyList()
            {
                // Arrange
                var list = new DoublyLinkedList<int>();

                // Act
                list.AddLast(1);

                // Assert
                Assert.NotNull(list.Find(1));
            }

            [Fact]
            public void RemoveFirst_RemovesElementFromList()
            {
                // Arrange
                var list = new DoublyLinkedList<int>();
                list.AddFirst(1);

                // Act
                var removedValue = list.RemoveFirst();

                // Assert
                Assert.Equal(1, removedValue);
                Assert.Null(list.Find(1));
            }

            [Fact]
            public void RemoveLast_RemovesElementFromList()
            {
                // Arrange
                var list = new DoublyLinkedList<int>();
                list.AddLast(1);

                // Act
                var removedValue = list.RemoveLast();

                // Assert
                Assert.Equal(1, removedValue);
                Assert.Null(list.Find(1));
            }

            [Fact]
            public void Find_ReturnsNullWhenElementNotFound()
            {
                // Arrange
                var list = new DoublyLinkedList<int>();

                // Act
                var result = list.Find(1);

                // Assert
                Assert.Null(result);
            }

            [Fact]
            public void PrintDLList()
            {
                // Arrange
                var list = new DoublyLinkedList<int>();

                // Act
                list.AddLast(1);
                list.AddLast(4);
                list.AddLast(6);
                list.AddLast(7);
                list.AddLast(8);
                list.AddLast(9);
                list.AddLast(23);
                list.AddLast(56);
                list.AddLast(78);
                list.PrintDLList();

                // Assert
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    list.PrintDLList();

                    // Assert
                    var result = sw.ToString().Trim();
                    var expected = "<--> 56";
                    Assert.Contains(expected, result);

                    // Output the result to the test runner
                    output.WriteLine(result);
                }
            }

            // Additional tests for other methods and edge cases can be added here.
        }


    }
}
