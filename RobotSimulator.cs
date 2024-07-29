using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toybot
{
    public enum Direction
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }
    internal class RobotSimulator
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Position { get; set; }

        private bool isPlaced;

        public void Place(int x, int y, Direction facing)
        {
            this.X = x;
            this.Y = y;
            this.Position = facing;
            isPlaced = true;
        }

        public void Move() 
        {
            if (!isPlaced) return;

            switch (Position)
            {
                case Direction.NORTH: if (Y < 4) Y++; break;
                case Direction.EAST: if (X < 4) X++; break;
                case Direction.SOUTH: if (Y > 0) Y--; break;
                case Direction.WEST: if (X > 0) X--; break;
            }
        }

        public void Left()
        {
            if (!isPlaced) return;

            Position = (Direction)(((int)Position + 3) % 4);

        }

        public void Right()
        {
            if (!isPlaced) return;

            Position = (Direction)(((int)Position + 1) % 4);
        }

        public void Report()
        {
            if (!isPlaced) return;

            Console.WriteLine($"{X},{Y},{Position}");
        }



    }
}
