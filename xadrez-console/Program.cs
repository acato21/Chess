using board;
using xadrez_console;

namespace chess
{
    class Program
    {
        public static void Main(string[] args)
        {
            Board bd = new Board(8,8);

            Screen.printBoard(bd);

            Console.ReadLine();
        }
    }
}