using System;
using System.Collections.Generic;
using System.Text;

namespace fishlike
{
    class cellOverlord
    {
        private Dictionary<int[], int> distances_;
        private cell[,] dungeonMap_;
        private const int mapSize_ = 9;

        public Dictionary<int[], int> distances { get { return distances_; } set { distances_ = value; } }
        public cell[,] dungeonMap { get { return dungeonMap_; } set { dungeonMap_ = value; } }
        public int mapSize { get { return mapSize_; } } //read only

        public cellOverlord()
        {
            dungeonMap = new cell[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    dungeonMap[i, j] = new cell(new int[] { i,j });
                }
            }
        }

        public bool hasRoom(int x, int y) { return dungeonMap[x, y].roomType == cell.rT.empty ? false : true; }
        public int findDistance(int x, int y) { return (Math.Abs(x - 4) + Math.Abs(y - 4)); }
    }

}
