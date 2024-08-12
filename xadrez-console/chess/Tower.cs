using board;

namespace chess
{
    class Tower : Part
    {
        public Tower(Color color, Board board) : base(color, board) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
