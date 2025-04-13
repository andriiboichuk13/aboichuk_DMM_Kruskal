namespace Kruskal_Code;

public class Cycle //ChatGPT helped write this part
{
    public List<int> parent = new();
    public Cycle(int size)
    {
        for (int i = 0; i < size; i++)
            parent.Add(i);
    }

    public int Find(int node)
    {
        if (parent[node] != node)
            parent[node] = Find(parent[node]);
        return parent[node];
    }

    public bool Union(int r1, int r2)
    {
        int root1 = Find(r1);
        int root2 = Find(r2);
        if (root1 == root2)
            return false;
        parent[root1] = root2;
        return true;
    }
}