using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Stick st = new Stick(6, 10, 'X');
            st.Draw();

            Square s = new Square(2, 5, '*');
            s.Draw();
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Point p1 = new Point(2, 3, '*');

            p1.Draw();

            Point p2 = new Point()
            {
                x = 4,
                y = 5,
                c = '#'
            };
            
            p2.Draw();


            Console.ReadLine();
        }
        
    }
}
