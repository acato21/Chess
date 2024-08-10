namespace Board
{
    class Part
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int qtyMovements { get; protected set; }
        public Board board { get; set; }

        public Part(Position position, Color color, Board board)
        {
            this.position = position;
            this.color = color;
            this.qtyMovements = 0;
            this.board = board;
        }
    }
}
