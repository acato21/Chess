namespace board
{
    class Part
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int qtyMovements { get; protected set; }
        public Board board { get; set; }

        public Part(Color color, Board board)
        {
            this.color = color;
            this.board = board;
            this.position = null;
            this.qtyMovements = 0;
        }
    }
}
