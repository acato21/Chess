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
    }
}
