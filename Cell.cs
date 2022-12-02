using Chess;
using ChessBoard;


namespace CellBoard
{

    public class Cell
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public bool CurrentlyOccupied { get; set; }
        public bool LegalNextMove { get; set; }
        public Cell(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
        }
        public int setCurrentCell { get; set; }

    }
}
