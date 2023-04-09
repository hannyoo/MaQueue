using System;
namespace MaQueue_
{
    public class Program
    {
        static void Main( string[] args )
        {
            // Sample( );

        }

        staic void CclrQueue()
        {

        }

        static void Sample()
        {
            Console.WriteLine($" Sample Class ");
            Console.WriteLine($"< maQueue >");
            MaQueue<int> maQueue = new MaQueue<int>( );

            maQueue.MaEnqueue(1);
            maQueue.MaEnqueue(2);
            maQueue.MaEnqueue(3);
            maQueue.MaEnqueue(4);
            maQueue.MaEnqueue(5);
            maQueue.MaEnqueue(6);

            maQueue.MaPrint( );
            Console.WriteLine( );

            Console.WriteLine($"< maQueue2 >");
            MaQueue<int> maQueue2 = new MaQueue<int>(3);
            maQueue2.MaEnqueue(10);
            maQueue2.MaEnqueue(20);
            maQueue2.MaEnqueue(30);
            maQueue2.MaEnqueue(40);

            maQueue2.MaPrint( );
        }

    }

}

