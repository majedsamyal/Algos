using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Graph
{
    public class GraphMS
    {
        private readonly int V; // No. of vertices  

        // Array of lists for  
        // Adjacency List Representation  
        private readonly List<int>[] adj;

        // Constructor  
        public GraphMS(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        //Function to Add an edge into the graph 
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list.  
        }

        #region Problems 

        public void PrintDFS(int v)
        {
            Stack<int> s = new Stack<int>();
            HashSet<int> seen = new HashSet<int>();
            s.Push(v);
            while (s.Count > 0)
            {
                var current = s.Pop();
                if (!seen.Contains(current))
                {
                    seen.Add(current);
                    Console.WriteLine(current);                    
                }

                // check all connect nodes of current node 
                var adjacent = adj[current];
                adjacent.Reverse();
                foreach (var item in adjacent)
                {
                    if (!seen.Contains(item))
                    {
                        s.Push(item);
                    }
                }
            }
        }

        public void PrintBFS(int v)
        {
            Queue<int> q = new Queue<int>();
            HashSet<int> seen = new HashSet<int>();
            q.Enqueue(v);
            while (q.Count > 0)
            {
                var current = q.Dequeue();
                if (!seen.Contains(current))
                {
                    seen.Add(current);
                    Console.WriteLine(current);
                }

                // check all connect nodes of current node 
                var adjacent = adj[current];
                adjacent.Reverse();
                foreach (var item in adjacent)
                {
                    if (!seen.Contains(item))
                    {
                        q.Enqueue(item);
                    }
                }
            }
        }

        #endregion
    }
}
