using Xunit.Abstractions;
using System;
using System.IO;

namespace xUnitStandAloneDemo
{
    namespace BinaryTreeTests
    {
        public class BinaryTreeTests
        {
            private readonly ITestOutputHelper output;

            public BinaryTreeTests(ITestOutputHelper output)
            {
                this.output = output;
            }

            [Fact]
            public void TestAddAndFind()
            {
                // Arrange
                var binaryTree = new BinaryTree();
                var valuesToAdd = new List<int> { 50, 30, 20, 40, 70, 60, 80 };

                // Act
                foreach (var value in valuesToAdd)
                {
                    binaryTree.Add(value);
                }

                // Assert
                foreach (var value in valuesToAdd)
                {
                    Assert.True(binaryTree.Find(value), $"Value {value} should be found in the tree.");
                }
                Assert.False(binaryTree.Find(10), "Value 10 should not be found in the tree.");
            }

            [Fact]
            public void TestPrintTree()
            {
                // Arrange
                var binaryTree2 = new BinaryTree();
                var valuesToAdd = new List<int> { 1, 17, 89, 44, 23, 901, 128, 22, 88 };

                // Act
                foreach (var value in valuesToAdd)
                {
                    binaryTree2.Add(value);
                }

                binaryTree2.PrintTree();

                // Assert
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    // Act
                    binaryTree2.PrintTree();

                    // Assert
                    var result = sw.ToString().Trim();
                    var expected = "Root---> 1\r\n";
                    Assert.Contains(expected, result);

                    // Output the result to the test runner
                    output.WriteLine(result);
                }
            }
        }

    }
        }

// Implementation of BinaryTree and Node classes would remain the same
