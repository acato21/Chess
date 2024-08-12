using board;
using xadrez_console;

namespace chess
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Board bd = new Board(8, 8);

                bd.PlacePart(new Tower(Color.Black, bd), new Position(0, 0));
                bd.PlacePart(new Tower(Color.Black, bd), new Position(1, 9));
                bd.PlacePart(new King(Color.Black, bd), new Position(0, 2));

                Screen.printBoard(bd);

            }
            catch (BoardException e) 
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}