using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Square s = new Square(3, 1, '*');
            s.Draw();

            Thread.Sleep(1500);
            s.Hide();
            s.Move(Direction.LEFT);
            s.Draw();



            Console.ReadLine();
        }
        
    }
}
