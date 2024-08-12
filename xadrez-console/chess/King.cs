using board;

namespace chess
{
    class King : Part
    {
        public King(Color color, Board board) : base(color, board) { }

        public override string ToString()
        {
            return "K";
        }
    }
}
