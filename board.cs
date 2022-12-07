
using CellBoard;

namespace ChessBoard
{
    class Board
    {
        public int currentRow = 0;
        public int currentCol = 0;

        public int Size { get; set; }

        public Cell[,] theGrid { get; set; }

        public Board(int s)
        {
            Size = s;
            theGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }

            }

        }
        public void MarkNextLegalMove()
        {
            Cell currentCell = new Cell(currentRow, currentCol);
            string chessPiece = "";
            string colorChessPiece = "";

            Console.WriteLine("Enter the piece:");
            try
            {
                chessPiece = Console.ReadLine();
                currentCell.CurrentPeice = chessPiece;
            }
            catch
            {
                Console.WriteLine("Not valid.");
            }
            Console.WriteLine("Enter the color of the piece:");
            try
            {
                colorChessPiece = Console.ReadLine();
                currentCell.TeamColor = colorChessPiece;
            }
            catch
            {
                Console.WriteLine("Not valid.");
            }


            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    // theGrid[i, j].CurrentlyOccupied = false;
                }

            }
            if (currentCell.TeamColor == "White")
            {
                switch (currentCell.CurrentPeice)
                {

                    case "Knight":
                        Console.WriteLine("A knight moves to one of the nearest squares not on the same rank, file, or diagonal.");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true; }
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;

                    case "King":
                        Console.WriteLine("The King is a slow piece that can move only one step in every direction forward, backward, to the sides or diagonall");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if
                            ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            {
                                theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                            }
                            if
                            ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            {
                                theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;

                    case "Rook":
                        Console.WriteLine("A rook moves any number of vacant squares horizontally or verticallyl.");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 8].LegalNextMove = true; }
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;


                    case "Bishop":
                        Console.WriteLine("Bishops can move only diagonal. Every bishop is confined to half of the board, as it can move only on its respective light or dark squares. . It cannot hop over other pieces like a knight");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.RowNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber - 8].LegalNextMove = true; }
                        }

                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;


                    case "Queen":
                        Console.WriteLine("The Queen can move 1-7 squares in any direction, up, down, left, right, or diagonal, until the Queen reaches an obstruction or captures a piece. It cannot jump over pieces and can only capture one piece per turn.");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.RowNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                        }

                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;


                    case "Pawn":
                        Console.WriteLine("The pawn can only move forwards one step at a time, and not backwards, but when they capture the other pieces they can only do so when the opponent's piece is on a square diagonally in front of them. Each Pawn may advance two squares forward the first time it is moved");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true; }
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            else if (currentCell.TeamColor == "Black")
            {
                switch (currentCell.CurrentPeice)
                {

                    case "Knight":
                        Console.WriteLine("A knight moves to one of the nearest squares not on the same rank, file, or diagonal.");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true; }
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;

                    case "King":
                        Console.WriteLine("The King is a slow piece that can move only one step in every direction forward, backward, to the sides or diagonall");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if
                            ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            {
                                theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                            }
                            if
                            ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            {
                                theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
                            }
                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            {
                                theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;

                    case "Rook":
                        Console.WriteLine("A rook moves any number of vacant squares horizontally or verticallyl.");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 8].LegalNextMove = true; }
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;

                    case "Bishop":
                        Console.WriteLine("Bishops can move only diagonal. Every bishop is confined to half of the board, as it can move only on its respective light or dark squares. . It cannot hop over other pieces like a knight");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.RowNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber - 8].LegalNextMove = true; }
                        }

                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;


                    case "Queen":
                        Console.WriteLine("The Queen can move 1-7 squares in any direction, up, down, left, right, or diagonal, until the Queen reaches an obstruction or captures a piece. It cannot jump over pieces and can only capture one piece per turn.");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.RowNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 1 >= 0 && currentCell.RowNumber - 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 2 >= 0 && currentCell.RowNumber - 2 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 3 >= 0 && currentCell.RowNumber - 3 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 3, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 4 >= 0 && currentCell.RowNumber - 4 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 4, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 5 >= 0 && currentCell.RowNumber - 5 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 5, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 6 >= 0 && currentCell.RowNumber - 6 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 6, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 7 >= 0 && currentCell.RowNumber - 7 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber - 8 >= 0 && currentCell.RowNumber - 8 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber - 8, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 2 >= 0 && currentCell.RowNumber + 2 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 3 >= 0 && currentCell.RowNumber + 3 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 3, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 4 >= 0 && currentCell.RowNumber + 4 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 4, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 5 >= 0 && currentCell.RowNumber + 5 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 5, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 6 >= 0 && currentCell.RowNumber + 6 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 6, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 7 >= 0 && currentCell.RowNumber + 7 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber + 8 >= 0 && currentCell.RowNumber + 8 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 8, currentCell.ColumnNumber].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 1 >= 0 && currentCell.ColumnNumber - 1 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 2 >= 0 && currentCell.ColumnNumber - 2 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 3 >= 0 && currentCell.ColumnNumber - 3 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 4 >= 0 && currentCell.ColumnNumber - 4 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 5 >= 0 && currentCell.ColumnNumber - 5 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 6 >= 0 && currentCell.ColumnNumber - 6 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 7 >= 0 && currentCell.ColumnNumber - 7 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber - 8 >= 0 && currentCell.ColumnNumber - 8 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 8].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 1 >= 0 && currentCell.ColumnNumber + 1 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 2 >= 0 && currentCell.ColumnNumber + 2 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 2].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 3 >= 0 && currentCell.ColumnNumber + 3 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 3].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 4 >= 0 && currentCell.ColumnNumber + 4 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 4].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 5 >= 0 && currentCell.ColumnNumber + 5 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 5].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 6 >= 0 && currentCell.ColumnNumber + 6 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 6].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 7 >= 0 && currentCell.ColumnNumber + 7 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 7].LegalNextMove = true; }

                            if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7 && currentCell.ColumnNumber + 8 >= 0 && currentCell.ColumnNumber + 8 <= 7))
                            { theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 8].LegalNextMove = true; }

                        }

                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;

                    case "Pawn":
                        Console.WriteLine("The pawn can only move forwards one step at a time, and not backwards, but when they capture the other pieces they can only do so when the opponent's piece is on a square diagonally in front of them. Each Pawn may advance two squares forward the first time it is moved");
                        if ((currentCell.RowNumber >= 0 && currentCell.RowNumber <= 7) && (currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                        {
                            if ((currentCell.RowNumber + 1 >= 0 && currentCell.RowNumber + 1 <= 7 && currentCell.ColumnNumber >= 0 && currentCell.ColumnNumber <= 7))
                            { theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true; }
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (theGrid[i, j].LegalNextMove)
                    {
                        Console.WriteLine("Row " + i + " Column " + j + " is a legal move.");
                    }
                }

            }
        }
        public void setCurrentCell()
        {
            Console.WriteLine("Enter the current row number");
            try
            {
                currentRow = int.Parse(Console.ReadLine());
                currentRow--;
            }
            catch
            {
                Console.WriteLine("Not valid.");
            }
            try
            {
                Console.WriteLine("Enter the current column number");
                currentCol = int.Parse(Console.ReadLine());
                currentCol--;
            }
            catch
            {
                Console.WriteLine("Not valid.");
            }
            if (currentRow < 0 || currentRow > Size || currentCol < 0 || currentCol > Size)
            {
                Console.WriteLine("Out of range");
            }
            theGrid[currentRow, currentCol].CurrentlyOccupied = true;

        }



        public void initalizboard()
        {
            theGrid[0, 0] = new Cell(0, 0, "Rook", "White");
            theGrid[0, 1] = new Cell(0, 1, "Knight", "White");
            theGrid[0, 2] = new Cell(0, 2, "Bishop", "White");
            theGrid[0, 3] = new Cell(0, 3, "Queen", "White");
            theGrid[0, 4] = new Cell(0, 4, "King", "White");
            theGrid[0, 5] = new Cell(0, 5, "Bishop", "White");
            theGrid[0, 6] = new Cell(0, 6, "Knight", "White");
            theGrid[0, 7] = new Cell(0, 7, "Rook", "White");
            theGrid[1, 0] = new Cell(1, 0, "Pawn", "White");
            theGrid[1, 1] = new Cell(1, 1, "Pawn", "White");
            theGrid[1, 2] = new Cell(1, 2, "Pawn", "White");
            theGrid[1, 3] = new Cell(1, 3, "Pawn", "White");
            theGrid[1, 4] = new Cell(1, 4, "Pawn", "White");
            theGrid[1, 5] = new Cell(1, 5, "Pawn", "White");
            theGrid[1, 6] = new Cell(1, 6, "Pawn", "White");
            theGrid[1, 7] = new Cell(1, 7, "Pawn", "White");
            theGrid[2, 0] = new Cell(2, 0, "", "");
            theGrid[2, 1] = new Cell(2, 1, "", "");
            theGrid[2, 2] = new Cell(2, 2, "", "");
            theGrid[2, 3] = new Cell(2, 3, "", "");
            theGrid[2, 4] = new Cell(2, 4, "", "");
            theGrid[2, 5] = new Cell(2, 5, "", "");
            theGrid[2, 6] = new Cell(2, 6, "", "");
            theGrid[2, 7] = new Cell(2, 7, "", "");
            theGrid[3, 0] = new Cell(3, 0, "", "");
            theGrid[3, 1] = new Cell(3, 1, "", "");
            theGrid[3, 2] = new Cell(3, 2, "", "");
            theGrid[3, 3] = new Cell(3, 3, "", "");
            theGrid[3, 4] = new Cell(3, 4, "", "");
            theGrid[3, 5] = new Cell(3, 5, "", "");
            theGrid[3, 6] = new Cell(3, 6, "", "");
            theGrid[3, 7] = new Cell(3, 7, "", "");
            theGrid[4, 0] = new Cell(4, 0, "", "");
            theGrid[4, 1] = new Cell(4, 1, "", "");
            theGrid[4, 2] = new Cell(4, 2, "", "");
            theGrid[4, 3] = new Cell(4, 3, "", "");
            theGrid[4, 4] = new Cell(4, 4, "", "");
            theGrid[4, 5] = new Cell(4, 5, "", "");
            theGrid[4, 6] = new Cell(4, 6, "", "");
            theGrid[4, 7] = new Cell(4, 7, "", "");
            theGrid[5, 0] = new Cell(5, 0, "", "");
            theGrid[5, 1] = new Cell(5, 1, "", "");
            theGrid[5, 2] = new Cell(5, 2, "", "");
            theGrid[5, 3] = new Cell(5, 3, "", "");
            theGrid[5, 4] = new Cell(5, 4, "", "");
            theGrid[5, 5] = new Cell(5, 5, "", "");
            theGrid[5, 6] = new Cell(5, 6, "", "");
            theGrid[5, 7] = new Cell(5, 7, "", "");
            theGrid[7, 0] = new Cell(7, 0, "Rook", "Black");
            theGrid[7, 1] = new Cell(7, 1, "Knight", "Black");
            theGrid[7, 2] = new Cell(7, 2, "Bishop", "Black");
            theGrid[7, 3] = new Cell(7, 3, "Queen", "Black");
            theGrid[7, 4] = new Cell(7, 4, "King", "Black");
            theGrid[7, 5] = new Cell(7, 5, "Bishop", "Black");
            theGrid[7, 6] = new Cell(7, 6, "Knight", "Black");
            theGrid[7, 7] = new Cell(7, 7, "Rook", "Black");
            theGrid[6, 0] = new Cell(6, 0, "Pawn", "Black");
            theGrid[6, 1] = new Cell(6, 1, "Pawn", "Black");
            theGrid[6, 2] = new Cell(6, 2, "Pawn", "Black");
            theGrid[6, 3] = new Cell(6, 3, "Pawn", "Black");
            theGrid[6, 4] = new Cell(6, 4, "Pawn", "Black");
            theGrid[6, 5] = new Cell(6, 5, "Pawn", "Black");
            theGrid[6, 6] = new Cell(6, 6, "Pawn", "Black");
            theGrid[6, 7] = new Cell(6, 7, "Pawn", "Black");



        }

        public void Drawboard()
        {

        }

        public void Movepiece()
        {
            Console.WriteLine("choose your current pieces row number");
            string userimputRow = Console.ReadLine();

            Console.WriteLine("choose your current pieces Column number");
            string userimputColumn = Console.ReadLine();
            if (theGrid[Convert.ToInt32(userimputRow), Convert.ToInt32(userimputColumn)].CurrentPeice != "") ;
            {
                if (theGrid[Convert.ToInt32(userimputRow), Convert.ToInt32(userimputColumn)].TeamColor == "White") ;
                Console.WriteLine("choose your new row number");
                string NewuserimputRow = Console.ReadLine();
                Console.WriteLine("choose your new Column number");
                string NewuserimputColumn = Console.ReadLine();
                if (isValidMove(theGrid[Convert.ToInt32(userimputRow), Convert.ToInt32(userimputColumn)], theGrid[Convert.ToInt32(NewuserimputRow), Convert.ToInt32(NewuserimputColumn)]))
                {
                    //is cell ocupied
                    //is other team
                    // move peice to location
                    //clear old location

                }
            }
            bool isValidMove(Cell startLocation, Cell endLocation)
            {
                if (startLocation.CurrentPeice == "King")
                {
                    if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                    {
                        return true;
                    }
                    if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                    {
                        return true;
                    }
                    if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                    {
                        return true;
                    }
                    if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                    {
                        return true;
                    }
                    if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                    {
                        return true;
                    }
                    if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                    {
                        return true;
                    }
                    if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                    {
                        return true;
                    }
                    if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                    {
                        return true;
                    }

                    if (startLocation.CurrentPeice == "Knight")
                    {

                        if ((startLocation.RowNumber - 2 == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }

                        if ((startLocation.RowNumber - 2 == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }

                        if ((startLocation.RowNumber + 2 == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }

                        if ((startLocation.RowNumber + 2 == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }

                        if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber + 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }

                        if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber - 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }

                        if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber + 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }

                        if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber - 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                    }

                    if (startLocation.CurrentPeice == "Rook")
                    {

                        if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 2 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 3 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 4 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 5 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 6 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 7 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 8 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 2 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 3 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 4 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 5 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 6 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 7 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;

                        }
                        if ((startLocation.RowNumber + 8 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 8 == startLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                    }

                    if (startLocation.CurrentPeice == "Bishop")
                    {
                        if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 2 == endLocation.RowNumber && startLocation.ColumnNumber + 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 3 == endLocation.RowNumber && startLocation.ColumnNumber + 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 4 == endLocation.RowNumber && startLocation.ColumnNumber + 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 5 == endLocation.RowNumber && endLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 6 == endLocation.RowNumber && startLocation.ColumnNumber + 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 7 == endLocation.RowNumber && startLocation.ColumnNumber + 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 8 == endLocation.RowNumber && startLocation.ColumnNumber + 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 2 == endLocation.RowNumber && startLocation.ColumnNumber - 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 3 == endLocation.RowNumber && startLocation.ColumnNumber - 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 4 == endLocation.RowNumber && startLocation.ColumnNumber - 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 5 == endLocation.RowNumber && startLocation.ColumnNumber - 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 6 == endLocation.RowNumber && startLocation.ColumnNumber - 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 7 == endLocation.RowNumber && startLocation.ColumnNumber - 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 8 == endLocation.RowNumber && startLocation.ColumnNumber - 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 2 == endLocation.RowNumber && startLocation.ColumnNumber + 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 3 == endLocation.RowNumber && startLocation.ColumnNumber + 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 4 == endLocation.RowNumber && startLocation.ColumnNumber + 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 5 == endLocation.RowNumber && startLocation.ColumnNumber + 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 6 == endLocation.RowNumber && startLocation.ColumnNumber + 6 == endLocation.ColumnNumber))
                        {
                            return true;

                        }
                        if ((startLocation.RowNumber - 7 == endLocation.RowNumber && startLocation.ColumnNumber + 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 8 == endLocation.RowNumber && startLocation.ColumnNumber + 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 2 == endLocation.RowNumber && startLocation.ColumnNumber - 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 3 == endLocation.RowNumber && startLocation.ColumnNumber - 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 4 == endLocation.RowNumber && startLocation.ColumnNumber - 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 5 == endLocation.RowNumber && startLocation.ColumnNumber - 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 6 == endLocation.RowNumber && startLocation.ColumnNumber - 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 7 == endLocation.RowNumber && startLocation.ColumnNumber - 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 8 == endLocation.RowNumber && startLocation.ColumnNumber - 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }

                    }
                    if (startLocation.CurrentPeice == "Queen")
                    {

                        if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 2 == endLocation.RowNumber && startLocation.ColumnNumber + 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 3 == endLocation.RowNumber && startLocation.ColumnNumber + 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 4 == endLocation.RowNumber && startLocation.ColumnNumber + 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 5 == endLocation.RowNumber && endLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 6 == endLocation.RowNumber && startLocation.ColumnNumber + 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 7 == endLocation.RowNumber && startLocation.ColumnNumber + 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 8 == endLocation.RowNumber && startLocation.ColumnNumber + 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 2 == endLocation.RowNumber && startLocation.ColumnNumber - 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 3 == endLocation.RowNumber && startLocation.ColumnNumber - 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 4 == endLocation.RowNumber && startLocation.ColumnNumber - 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 5 == endLocation.RowNumber && startLocation.ColumnNumber - 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 6 == endLocation.RowNumber && startLocation.ColumnNumber - 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 7 == endLocation.RowNumber && startLocation.ColumnNumber - 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 8 == endLocation.RowNumber && startLocation.ColumnNumber - 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 2 == endLocation.RowNumber && startLocation.ColumnNumber + 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 3 == endLocation.RowNumber && startLocation.ColumnNumber + 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 4 == endLocation.RowNumber && startLocation.ColumnNumber + 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 5 == endLocation.RowNumber && startLocation.ColumnNumber + 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 6 == endLocation.RowNumber && startLocation.ColumnNumber + 6 == endLocation.ColumnNumber))
                        {
                            return true;

                        }
                        if ((startLocation.RowNumber - 7 == endLocation.RowNumber && startLocation.ColumnNumber + 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 8 == endLocation.RowNumber && startLocation.ColumnNumber + 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 2 == endLocation.RowNumber && startLocation.ColumnNumber - 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 3 == endLocation.RowNumber && startLocation.ColumnNumber - 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 4 == endLocation.RowNumber && startLocation.ColumnNumber - 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 5 == endLocation.RowNumber && startLocation.ColumnNumber - 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 6 == endLocation.RowNumber && startLocation.ColumnNumber - 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 7 == endLocation.RowNumber && startLocation.ColumnNumber - 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 8 == endLocation.RowNumber && startLocation.ColumnNumber - 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 1 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 2 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 3 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 4 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 5 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 6 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 7 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber - 8 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 1 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 2 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 3 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 4 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 5 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 6 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber + 7 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;

                        }
                        if ((startLocation.RowNumber + 8 == endLocation.RowNumber && startLocation.ColumnNumber == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber - 8 == startLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 1 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 2 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 3 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 4 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 5 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 6 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 7 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                        if ((startLocation.RowNumber == endLocation.RowNumber && startLocation.ColumnNumber + 8 == endLocation.ColumnNumber))
                        {
                            return true;
                        }
                    }
                    if (startLocation.CurrentPeice == "Pawn"){
                        
                            if ((startLocation.RowNumber + 1 == endLocation.RowNumber  && startLocation.ColumnNumber == endLocation.ColumnNumber ))
{
    return true;
}                    }


                }

                return false;
            }
        }
    }
}

