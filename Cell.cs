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
        public string CurrentPeice {get;set;}
        public string TeamColor{get; set;}
        public Cell(int x, int y,string peice="", string color="")
        {
            RowNumber = x;
            ColumnNumber = y;
            CurrentPeice = peice;
            TeamColor= color;
        }
        public int setCurrentCell { get; set; }

    }
}