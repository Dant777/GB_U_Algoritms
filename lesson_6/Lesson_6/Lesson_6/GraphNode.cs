using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6
{
    public class GraphNode
    {
        public GraphNode(string name)
        {
            Name = name;
            Edges = new List<Edge>();

        }
        public string Name { get; set; }
        public List<Edge> Edges{ get; set; }

    }

    public class Edge
    {
        public Edge(GraphNode node, int weight)
        {
            Node = node;
            Weight = weight;
        }
        public int Weight { get; set; }
        public GraphNode Node { get; set; }
    }

}
