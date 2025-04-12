using Kruskal_Code;
Console.OutputEncoding = System.Text.Encoding.UTF8;

MapGenerator map = new MapGenerator();
map.mapPrint(map.GenerateMap(5, 0.5));