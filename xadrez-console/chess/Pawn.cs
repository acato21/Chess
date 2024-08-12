using board;

namespace chess
{
    class Pawn : Part
    {
        public Pawn(Color color, Board board) : base(color, board) { }

        public override string ToString()
        {
            return "P";
        }
    }
}
