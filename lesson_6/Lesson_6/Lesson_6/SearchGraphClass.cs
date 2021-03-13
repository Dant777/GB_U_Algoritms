using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6
{
    public class SearchGraphClass
    {
        // Список посещенных вершин
        private HashSet<GraphNode> _visited;
        // Путь из начальной вершины в целевую.
        private LinkedList<GraphNode> _path;
        private GraphNode _goal;

        public LinkedList<GraphNode> DFS(GraphNode start, GraphNode goal)
        {
            _visited = new HashSet<GraphNode>();
            _path = new LinkedList<GraphNode>();
            _goal = goal;
            DFS(start);
            if (_path.Count > 0)
            {
                _path.AddFirst(start);
            }
            return _path;
        }

        private bool DFS(GraphNode node)
        {
            if (node == _goal)
            {
                return true;
            }
            _visited.Add(node);
            foreach (var child in node.Edges)
            {
                if (_visited.Contains(child.Node)) continue;

                if (DFS(child.Node))
                {
                    _path.AddFirst(child.Node);
                    return true;
                }
            }
            return false;
        }

        public void BFS(GraphNode root)
        {
            Queue<GraphNode> path = new Queue<GraphNode>();

            Queue<GraphNode> queue = new Queue<GraphNode>();    
            HashSet<GraphNode> visited = new HashSet<GraphNode>();
            queue.Enqueue(root);
            visited.Add(root);

            while (queue.Count > 0)
            {
                GraphNode e = queue.Dequeue();
                path.Enqueue(e);

                foreach (var emp in e.Edges)
                {
                    if (!visited.Contains(emp.Node))
                    {
                        queue.Enqueue(emp.Node);
                        visited.Add(emp.Node);
                    }
                }
            }

            while (path.Count > 0)
            {
                GraphNode e = path.Dequeue();
                Console.Write(e.Name + " ");
            }
        }

        public void PrintPath(LinkedList<GraphNode> path)
        {
            Console.WriteLine();
            if (path.Count == 0)
            {
                Console.WriteLine("You shall not pass!");
            }
            else
            {
                foreach (var item in path)
                {
                    Console.Write($"{ item.Name } ");
                }

            }
            
        }
    }
}
