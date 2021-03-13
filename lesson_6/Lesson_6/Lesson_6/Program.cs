using System;
using System.Collections.Generic;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphNode node_A = new GraphNode("A");
            GraphNode node_B = new GraphNode("B");
            GraphNode node_C = new GraphNode("C");
            GraphNode node_D = new GraphNode("D");
            GraphNode node_E = new GraphNode("E");
            GraphNode node_F = new GraphNode("F");
            GraphNode node_G = new GraphNode("G");

            node_A.Edges.Add(new Edge(node_B, 1));
            node_A.Edges.Add(new Edge(node_C, 2));

            node_B.Edges.Add(new Edge(node_E, 4));
            node_B.Edges.Add(new Edge(node_D, 2));

            node_C.Edges.Add(new Edge(node_D, 3));

            node_E.Edges.Add(new Edge(node_F, 3));

            node_D.Edges.Add(new Edge(node_F, 5));
            node_D.Edges.Add(new Edge(node_G, 1));

            SearchGraphClass searchGraph = new SearchGraphClass();
            LinkedList<GraphNode> path = searchGraph.DFS(node_A, node_G);

            Console.WriteLine("--------------DFS---------------");
            searchGraph.PrintPath(path);
            Console.WriteLine("--------------BFS---------------");
            searchGraph.BFS(node_A);

        }
    }
}
