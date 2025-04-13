using Kruskal_Code;
Console.OutputEncoding = System.Text.Encoding.UTF8;

MapGenerator map = new MapGenerator();
Kruskal kruskal = new Kruskal();
var res = map.GenerateMap(50, 0.5);
map.mapPrint(res);
var list = map.adjList(res);

//var mintree =kruskal.MinSpanTree(list, 200);
var mintree = kruskal.MinSpanTree(res, 50);


if (mintree != null)
{
    Console.WriteLine("\n");
    Console.WriteLine("Minimal span tree for this graph is: ");
    foreach (var edge in mintree)
    {
        
        Console.WriteLine($"{edge.coord1+1}------({edge.val})------{edge.coord2+1}");
    }
}

