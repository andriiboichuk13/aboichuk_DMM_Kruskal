using Kruskal_Code;
Console.OutputEncoding = System.Text.Encoding.UTF8;

MapGenerator map = new MapGenerator();
Kruskal kruskal = new Kruskal();
var res = map.GenerateMap(20, 0.1);
map.mapPrint(res);
var list = map.adjList(res);

//var mintree =kruskal.MinSpanTree(list, 200);
var mintree = kruskal.MinSpanTree(res, 20);


if (mintree != null)
{
    foreach (var edge in mintree)
    {
        Console.WriteLine("\n");
        Console.WriteLine("Minimal span tree for this graph is: ");
        Console.WriteLine($"{edge.coord1+1}------({edge.val})------{edge.coord2+1}");
    }
}

