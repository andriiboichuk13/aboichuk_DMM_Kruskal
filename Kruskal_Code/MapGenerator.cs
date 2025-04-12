namespace Kruskal_Code;

public class MapGenerator
{
    public int[,] GenerateMap(int size, double probability)
    {
        int INFINITY = 999999999;
        Random random = new Random();
        int[,] map = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == j)
                {
                    map[i, j] = 0;
                    continue;
                }
                if (random.NextDouble() < probability)
                {
                    map[i, j] = random.Next(1, 10);
                }
                else
                {
                    map[i, j] = INFINITY;
                }
            }
        }
            
        
        
        return map;
    }

    public void mapPrint(int[,] map)
    {
        string spacing = " ";
        for (int i = 0; i <= map.GetLength(0); i++)
        {
            Console.Write(i+ " ");
        }
        Console.WriteLine();
        for (int i = 0; i < map.GetLength(0); i++)
        {
            Console.Write(i+1 + " ");
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (j > 9 && j < 100)
                {
                    spacing = "  ";
                }

                if (j >= 100)
                {
                    spacing = "   ";
                }

                if (j < 10)
                {
                    spacing = " ";
                }

            if (map[i, j] != 999999999)
                {
                    Console.Write(map[i, j] + spacing);
                    continue;
                }
                Console.Write("\u221e ");
                
                
            }
            Console.WriteLine();
        }
    }
}