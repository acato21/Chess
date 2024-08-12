namespace board
{
    class Board
    {
        public int lines { get; set; }
        public int columns { get; set; }
        private Part[,] parts;

        public Board(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            this.parts = new Part[lines, columns];
        }

        public Part part(int line, int colum)
        {
            return this.parts[line,colum];
        }

        public Part part(Position pos) 
        { 
            return this.parts[pos.line, pos.column];
        }

        public void PlacePart(Part part, Position pos) 
        {
            if (ExistsPart(pos))
            {
                throw new BoardException("There is already a piece in that position");
            }

            parts[pos.line, pos.column] = part;
            part.position = pos;
        }

        public bool ExistsPart(Position pos)
        {
            ValidatePosition(pos);
            return parts[pos.line, pos.column] != null;
        }

        public bool ValidPosition(Position pos)
        {
            if(pos.line < 0 || pos.column < 0 || pos.line >= this.lines || pos.column >= this.columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new BoardException("Invalid position");
            }       
        }
    }
}
