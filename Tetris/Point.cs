using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char C { get; set; }
        private Point point;

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(C);
            Console.SetCursorPosition(0, 0);
        }

        public Point(int a, int b, char sym)
        {
            X = a; Y = b; C = sym;
        }
        public Point() { }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            C = p.C;
        }

        internal void Move(Direction dir)
        {

            switch (dir)
            {
                case Direction.LEFT:
                    X --;
                    break;
                case Direction.RIGHT:
                    X++;
                    break;
                case Direction.DOWN:
                    Y += 1;
                    break;
                default:
                    break;
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }
}
