using board;

namespace chess
{
    class Horse : Part
    {
        public Horse(Color color, Board board) : base(color, board) { }

        public override string ToString()
        {
            return "H";
        }
    }
}
