using board;

namespace xadrez_console
{
    class Screen
    {
        public static void printBoard(Board board)
        {

            for (int i = 0; i < board.lines; i++) 
            { 
                for (int j = 0; j < board.columns; j++) 
                {
                    if(board.part(i,j) == null)
                    {
                        Console.Write("- ");
                    } else
                    {
                        Console.WriteLine($"{board.part(i, j)} ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
