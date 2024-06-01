using System.Xml.Linq;

namespace xUnitStandAloneDemo
{

    public class BinaryTree
    {
        private Node? root;

        public BinaryTree()
        {
            root = null;
        }



        public void Add(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                AddTo(root, value);
            }
        }

        private void AddTo(Node node, int value)
        {
            // Value is less than the current node value
            if (value < node.Value)
            {
                // If no left child exists, add value here
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                // If no right child exists, add value here
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        public bool Find(int value)
        {
            return FindIn(root, value);
        }

        private bool FindIn(Node node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if (node.Value == value)
            {
                return true;
            }

            if (value < node.Value)
            {
                return FindIn(node.Left, value);
            }
            else
            {
                return FindIn(node.Right, value);
            }
        }

        private class Node
        {
            public int Value { get; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }

        public void PrintTree()
        {
            PrintTree(root, "", true);
        }

        private void PrintTree(Node node, string indent, bool last)
        {
            // Base case: if the node is null, return
            if (node == null)
            {
                return;
            }

            Console.Write(indent);
            if (last)
            {
                Console.Write("Root---> ");
                indent += "   ";
            }
            else
            {
                Console.Write("Branch---> ");
                indent += "|  ";
            }

            Console.WriteLine(node.Value);

            // Recursively call the method for left and then right child
            PrintTree(node.Left, indent, false);
            PrintTree(node.Right, indent, true);
        }

        // ... (Node class and other methods)
    }
 }
