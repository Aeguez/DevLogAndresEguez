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

        static void SpecialMoves()
        {
            Console.WriteLine("Special Moves: ");
            Console.WriteLine("In order to win, you nedd to place your oponnet's king in checkmate. Checkmate is when your oponnents' king cannot move legally to protect himself from the other piece.");
            Console.WriteLine("Stalemate: If a players turn to move he is not in check but has not legal moves. This is called Stalemate and ends the game in a tie.");
            Console.WriteLine("Pawn promotion: This i when a pawn reaches the back of the other teams side and can become either queen, rook, bishop, or kight (whatever the player chooses).");
        }


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


            Console.WriteLine("Welcome to Chess, victory is simple, KILL the opposite teams KING!");

            {
                Board myBoard = new Board(8);

 void  help (){
                Console.WriteLine("Do you need help? if so Type Yes");
                Console.WriteLine();
                Console.WriteLine();



                string response = Console.ReadLine();

                while (response == "Yes")
                {

                    myBoard.setCurrentCell();
                    myBoard.MarkNextLegalMove();
                    response = Console.ReadLine();

                    printBoard(myBoard);

                    Console.ReadLine();
                }
                }
                string player = "White";
                myBoard.initalizboard();
                Console.WriteLine("White team goes first. the team is located on the top side of the board");
                Console.WriteLine();
                Console.WriteLine();

                while (true)
                {
                    help();
                    Drawboard(myBoard);
                    myBoard.Movepiece(player);
                    Drawboard(myBoard);
                    

                    if (player == "White")
                    {
                        player = "Black";
                        Console.WriteLine("Black teams turn");
                        Console.WriteLine("press any key to continue");

                        
                    }
                    else if (player == "Black")
                    {
                        player = "White";
                        Console.WriteLine("White teams turn");
                        Console.WriteLine("press any key to continue");
                        

                    }
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
                    /*  if(c.TeamColor=="Black")
                      {
                          Console.ForegroundColor=ConsoleColor.DarkBlue;

                      }
                      else if (c.TeamColor=="White")
                      {

                      }*/

                    if (c.CurrentPeice == "King")
                        Console.Write("| K");
                    if (c.CurrentPeice == "Rook")
                        Console.Write("| R");
                    if (c.CurrentPeice == "Pawn")
                        Console.Write("| P");
                    if (c.CurrentPeice == "Bishop")
                        Console.Write("| B");
                    if (c.CurrentPeice == "Queen")
                        Console.Write("| Q");
                    if (c.CurrentPeice == "Knight")
                        Console.Write("| H");
                    if (c.CurrentPeice == "")
                    {
                        Console.Write("|  ");

                    }
                }
                Console.WriteLine($"| {i + 1}\n________________________");
            }
            Console.WriteLine("  1  2  3  4  5  6  7  8 ");
        }



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
}