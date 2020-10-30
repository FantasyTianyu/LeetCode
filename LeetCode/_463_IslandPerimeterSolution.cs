using System;
namespace LeetCode
{
    public class _463_IslandPerimeterSolution
    {
        public _463_IslandPerimeterSolution()
        {
        }

        public int IslandPerimeter(int[][] grid)
        {
            int landNum = 0;
            int linkNum = 0;
            for (int x = 0; x < grid.Length; x++)
            {
                for (int y = 0; y < grid[0].Length; y++)
                {
                    if (grid[x][y] == 1)
                    {
                        landNum++;
                        if (x < grid.Length - 1 && grid[x + 1][y] == 1)
                        {
                            linkNum++;
                        }

                        if (y < grid[0].Length - 1 && grid[x][y + 1] == 1)
                        {
                            linkNum++;
                        }
                    }
                }
            }
            return landNum * 4 - linkNum * 2;
        }


    }
}
