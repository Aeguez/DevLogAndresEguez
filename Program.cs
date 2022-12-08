// Console.WriteLine(Console.CursorLeft);
// Console.WriteLine(Console.CursorTop);

// while (true){
//     ConsoleKeyInfo pressed = Console.ReadKey(true);
//     switch (pressed.Key) {
//         case ConsoleKey.Escape:
//         return;
//         case ConsoleKey.UpArrow:
//         Console.CursorTop--;
//         break;
//         case ConsoleKey.DownArrow:
//         Console.CursorTop++;
//         break;
//         case ConsoleKey.LeftArrow:
//         Console.CursorLeft--;
//         break;
//         case ConsoleKey.RightArrow:
//         Console.CursorLeft++;
//         break;
//         case ConsoleKey.Enter:
//         Console.CursorVisible = false;
//         Console.BackgroundColor = ConsoleColor.Red;
//         Console.BackgroundColor = ConsoleColor.Yellow;
//         Console.Write("p");
//         Console.CursorLeft--;
//         Console.CursorVisible = true;
//         break;
//     }
// }

using System.Diagnostics;
using System;
using CellBoard;
using ChessBoard;

namespace Chess
{
    partial class Program
    {

        static void Main()
        {
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.Size == 8);
            }
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.theGrid[0, 0].ColumnNumber == 0);
                Debug.Assert(myBoard.theGrid[0, 0].RowNumber == 0);
            }
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.theGrid[3, 5].ColumnNumber == 5);
                Debug.Assert(myBoard.theGrid[3, 5].RowNumber == 3);
            }
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.theGrid[7, 7].ColumnNumber == 7);
                Debug.Assert(myBoard.theGrid[7, 7].RowNumber == 7);
            }
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.theGrid[7, 7].LegalNextMove == false);
            }


            Console.WriteLine("All tests passed.");

            {

                // Write an introduction

                Board myBoard = new Board(8);


                Console.WriteLine("Do you need help?");


                string response = Console.ReadLine();

                while (response == "Yes")
                {

                    myBoard.setCurrentCell();
                    myBoard.MarkNextLegalMove();
                    response = Console.ReadLine();

                    printBoard(myBoard);

                    Console.ReadLine();
                }
                string player = "White";
                myBoard.initalizboard();
                while (true)
                {
                    Drawboard(myBoard);
                    Console.ReadKey();
                    myBoard.Movepiece(player);
                    //Drawboard(myBoard);
                    Console.ReadKey();

                    if (player == "White")
                    {
                        player = "Black";
                        Console.WriteLine("Black teams turn");
                        Console.WriteLine("press any key to continue");

                        Console.ReadKey();

                        // Method of help 
                    }

                    else if (player == "Black")
                    {
                        player = "White";
                        Console.WriteLine("White teams turn");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();

                        //Method of help
                    }
                }
            }
            //////////////////////////////Functions that need to be moved///////////////////////////////////////////////////
            static void printBoard(Board myBoard)
            {
                for (int i = 0; i < myBoard.Size; i++)
                {
                    for (int j = 0; j < myBoard.Size; j++)
                    {
                        Cell c = myBoard.theGrid[i, j];

                        if (c.CurrentlyOccupied == true)
                        {
                            Console.Write("| X");
                        }
                        else if (c.LegalNextMove == true)
                        {
                            Console.Write("| +");
                        }
                        else
                        {
                            Console.Write("|  ");
                        }
                    }
                    Console.WriteLine("\n________________________");

                }

            }
        }


        static void Drawboard(Board myBoard)
        {
            Console.Clear();
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    // if(c.TeamColor == "Black")
                    
                    // {
                    //     Console.ForegroundColor = ConsoleColor.DarkBlue;
                    // }

                    if (c.CurrentPeice == "King")
                    {
                        Console.Write("| K");
                    }

                    if (c.CurrentPeice == "Rook")
                    {
                        Console.Write("| R");
                    }
                    if (c.CurrentPeice == "Pawn")
                    {
                        Console.Write("| P");
                    }
                    if (c.CurrentPeice == "Bishop")
                    {
                        Console.Write("| B");
                    }
                    if (c.CurrentPeice == "Queen")
                    {
                        Console.Write("| Q");
                    }
                    if (c.CurrentPeice == "Knight")
                    {
                        Console.Write("| H");
                    }
                    if (c.CurrentPeice == "")
                    {
                        Console.Write("|  ");
                    }
                }
                Console.WriteLine($"| {i + 1}\n________________________");
            }
            Console.WriteLine("  1  2  3  4  5  6  7  8 ");
        }
    }

}


