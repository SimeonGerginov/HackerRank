using System;
using System.Linq;

namespace EvenTree
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numberOfNodes = input[0];
            var numberOfEdges = input[1];

            var tree = new Node[numberOfNodes + 1];
            FillTree(tree, numberOfEdges);

            var edgesToRemove = EdgesToRemove(tree, numberOfNodes);
            Console.WriteLine(edgesToRemove);
        }

        private static void FillTree(Node[] tree, int numberOfEdges)
        {
            for (int i = 0; i < numberOfEdges; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var child = input[0];
                var parent = input[1];

                if (tree[parent] == null)
                {
                    tree[parent] = new Node();
                }

                if (tree[child] == null)
                {
                    tree[child] = new Node();
                }

                tree[parent].Children++;
                tree[child].Parent = parent;
            }
        }

        private static int EdgesToRemove(Node[] tree, int numberOfNodes)
        {
            var edgesToRemove = 0;

            for (int i = numberOfNodes; i > 1; i--)
            {
                if (tree[i].Children % 2 == 1)
                {
                    var parent = tree[i].Parent;

                    tree[parent].Children--;
                    edgesToRemove++;
                }
            }

            return edgesToRemove;
        }
    }
}
