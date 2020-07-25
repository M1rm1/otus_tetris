using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    abstract class Figure
    {
        const int LENGHT = 4;
        protected Point[] points = new Point[LENGHT];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
        public void Move(Point[] pList, Direction dir)
        {
            
            foreach (var p in pList)
            {
                p.Move(dir);
            }
            Draw();
        }
        internal void TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);
            if (VerifyPosition(clone))
                points = clone;
            Draw();
        }

        private bool VerifyPosition(Point[] pList)
        {
            foreach (var p in pList)
            {
                if (p.x < 0 || p.y < 0 || p.x >= 40 || p.y >= 30)
                    return false;
            }
            return true;
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGHT];
            for(var i = 0; i < LENGHT; i++)
            {
                newPoints[i] = new Point(points[i]);
            }
            return newPoints;
        }

        public abstract void Rotate();

        public void Hide()
        {
            foreach (var p in points)
            {
                p.Hide();
            }
        }

        
    }
}
