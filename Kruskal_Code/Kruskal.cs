using System.Diagnostics;

namespace Kruskal_Code;

public class Kruskal
{
    public List<Edge> MinSpanTree(Dictionary<int, List<Tuple<int, int>>> map, int n)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        PriorityQueue<Edge, int> PQ = new();
        List<Tuple<int, int>> inPq = new();
        foreach (int start in map.Keys)
        {
            foreach (Tuple<int,int> endlst in map[start])
            {
                if (endlst.Item2 != 0 && !inPq.Contains(new Tuple<int, int>(endlst.Item1, start)))
                {
                    inPq.Add(new Tuple<int, int>(start, endlst.Item1));
                    PQ.Enqueue(new Edge(start, endlst.Item1, endlst.Item2), endlst.Item2);
                }
            }
        }
        List<Edge> mintree = new();
        Cycle cycle = new(n);

        while (mintree.Count < n - 1 && PQ.Count > 0)
        {
            var edge = PQ.Dequeue();
            if (cycle.Union(edge.coord1, edge.coord2))
            {
                mintree.Add(edge);
            }
        }

        if (mintree.Count != n - 1)
        {
            Console.WriteLine("Impossible to use Kruskal's algorithm, not all vertexes are connected");
            sw.Stop();
            Console.WriteLine("Kruskal's algorithm took " + sw.ElapsedMilliseconds + " milliseconds");
            return null;
        }
        sw.Stop();
        Console.WriteLine("Kruskal's algorithm took " + sw.ElapsedMilliseconds + " milliseconds");
        return mintree;
        
        
        
    }
    
    public List<Edge> MinSpanTree(int[,] map, int n)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        PriorityQueue<Edge, int> PQ = new();
        List<Tuple<int, int>> inPq = new();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (map[i, j] != 0 && !inPq.Contains(new Tuple<int, int>(j, i)) && map[i, j] != 999999999)
                {
                    inPq.Add(new Tuple<int, int>(i, j));
                    PQ.Enqueue(new Edge(i, j, map[i,j]), map[i, j]);
                }
            }
        }
        List<Edge> mintree = new();
        Cycle cycle = new(n);

        while (mintree.Count < n - 1 && PQ.Count > 0)
        {
            var edge = PQ.Dequeue();
            if (cycle.Union(edge.coord1, edge.coord2))
            {
                mintree.Add(edge);
            }
        }

        if (mintree.Count != n - 1)
        {
            Console.WriteLine("Impossible to use Kruskal's algorithm, not all vertexes are connected");
            sw.Stop();
            Console.WriteLine("Kruskal's algorithm took " + sw.ElapsedMilliseconds + " milliseconds");
            return null;
        }
        sw.Stop();
        Console.WriteLine("Kruskal's algorithm took " + sw.ElapsedMilliseconds + " milliseconds");
        return mintree;
        
        
        
    }
}