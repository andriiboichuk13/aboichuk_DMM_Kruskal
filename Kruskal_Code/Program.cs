using Kruskal_Code;
Console.OutputEncoding = System.Text.Encoding.UTF8;

MapGenerator map = new MapGenerator();
var res = map.GenerateMap(5, 0.5);
map.mapPrint(res);
var list = map.adjList(res);
