using System;

namespace Number_of_Islands
{
    class Program
    {

        static void Main(string[] args)
        {
            char[][] grid = new char[4][];
            grid[0] = new char[5] { '1', '1', '1', '1', '0' };
            grid[0] = new char[5] { '1', '1', '0', '1', '0' };
            grid[0] = new char[5] { '1', '1', '0', '0', '0'};
            grid[0] = new char[5] { '0', '0', '0', '0', '0' };
            Console.WriteLine(NumOfIsland(grid));
        }

        private static int NumOfIsland(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int rows = grid.Length;
            int columns = grid[0].Length;

            var numIslands = 0;
            char sand = '1';

            var visited = new bool[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (grid[row][column].Equals(sand) && !visited[row, column])
                    {
                        numIslands++;
                        SearchIsland(grid, row, column, sand, visited);
                    }
                }
            }

            return numIslands;
        }

        private static void SearchIsland(char[][] grid, int row, int column, char sand, bool[,] visited)
        {
           if(row<0 || row>=grid.Length || column< 0 ||column>=grid[0].Length)
            {
                return;
            }
           if(!visited[row,column])
            {
               if(grid[row][column].Equals(sand))
                {
                    visited[row, column] = true;
                    SearchIsland(grid, row - 1, column, sand, visited);
                    SearchIsland(grid, row + 1, column, sand, visited);
                    SearchIsland(grid, row, column - 1, sand, visited);
                    SearchIsland(grid, row, column + 1, sand, visited);
                }
            }
        }
    }
}
