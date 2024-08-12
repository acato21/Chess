using board;
using xadrez_console;

namespace chess
{
    class Program
    {
        public static void Main(string[] args)
        {
            ChessPosition pos = new ChessPosition('c', 7);
           
            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosition());

            Console.WriteLine(7 - 'a');
        }
    }
}