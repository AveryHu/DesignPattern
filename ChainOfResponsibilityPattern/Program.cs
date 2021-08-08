using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Chain of Responsibility, dynamic add or remove the responsibility chain. Only do what it should do.
            // It's easy to add new handler, however, it's not guarantee that handle can be processed.
            // A long chain might cause the system performance and make client more complex.
            // Try this when you have to specify a componment to handle the request or you have no idea who can handle this request.
            RunChainOfResponsibility();
        }

        public static void RunChainOfResponsibility()
        {
            King king = new King();
            Knight knight = new Knight();
            Village village = new Village();
            king.SetNext(knight);
            knight.SetNext(village);

            Console.WriteLine(" ====== Request : Find Someone to Destory the Kingdom ====== ");
            king.HandleRequest("destory kingdom A");
            Console.WriteLine();
            Console.WriteLine(" ====== Request : Find Someone to Build a House ====== ");
            king.HandleRequest("build a house");
            Console.WriteLine();
            Console.WriteLine(" ====== Request : Ask Knight to Kill a Dragon Directly ====== ");
            knight.HandleRequest("kill the dragon");

        }
    }
}
