namespace Board
{
    class Board
    {
        public int lines { get; set; }
        public int columns { get; set; }
        private Part[,] part;

        public Board(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            this.part = new Part[lines, columns];
        }
    }
}
