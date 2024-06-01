using Xunit.Abstractions;
using System;
using System.IO;
using xUnitDataStructuresDemo;

namespace xUnitStandAloneDemo
{
    namespace BinaryTreeTests
    {
        public class BinaryTreeTests
        {    
       
            private readonly StringWriter _stringWriter2;
            private readonly BinaryTree _bt1;
            private readonly BinaryTree _bt2;
      
            public BinaryTreeTests()
            {
                _bt1 = new BinaryTree();
                _bt2 = new BinaryTree();
                _stringWriter2 = new StringWriter();
                _stringWriter2.GetStringBuilder().Clear();
                Console.SetOut(_stringWriter2);

            }

            [Fact]
            public void TestAddAndFind()
            {
                // Arrange
                var valuesToAdd = new List<int> { 50, 30, 20, 40, 70, 60, 80 };
                

                // Act
                foreach (var value in valuesToAdd)
                {
                    _bt1.Add(value);
                }

                // Assert
                foreach (var value in valuesToAdd)
                {
                    Assert.True(_bt1.Find(value), $"Value {value} should be found in the tree.");
                }
                Assert.False(_bt1.Find(10), "Value 10 should not be found in the tree.");
            }

            [Fact]
            public void TestPrintTree()
            {
                // Arrange
                var valuesToAdd = new List<int> { 1, 17, 89, 44, 23, 901, 128, 22, 88 };
                var expectedOutput = "Root---> 1\r\n"; // Replace with the expected output

                var stringWriter = new StringWriter();
                stringWriter.GetStringBuilder().Clear();
                Console.SetOut(stringWriter);

                // Act
                foreach (var value in valuesToAdd)
                {
                    _bt2.Add(value);
                }
                _bt2.PrintTree();

                // Assert
                var actualOutput = stringWriter.ToString().Trim();
                Assert.Contains(expectedOutput, actualOutput);

                // Reset the StringWriter for the next test
                stringWriter.GetStringBuilder().Clear();
            }
        }

    }
  }

// Implementation of BinaryTree and Node classes would remain the same
