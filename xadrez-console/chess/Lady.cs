﻿using board;

namespace chess
{
    class Lady : Part
    {
        public Lady(Color color, Board board) : base(color, board) { }

        public override string ToString()
        {
            return "L";
        }
    }
}
