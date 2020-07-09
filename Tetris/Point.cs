using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class Point
    {
        public int x;
        public int y;
        public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        public Point(int a, int b, char sym)
        {
            x = a; y = b; c = sym;
        }
        public Point() { }

        internal void Move(Direction dir)
        {

            switch (dir)
            {
                case Direction.LEFT:
                    x --;
                    break;
                case Direction.RIGHT:
                    x++;
                    break;
                case Direction.DOWN:
                    y += 1;
                    break;
                default:
                    break;
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
