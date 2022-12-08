

using System;

namespace PieceBoard
{
    public class Piece
    {
        public String Color { get; set; }
        public PieceType Type { get; set; }

        public Piece(String color, PieceType type)
        {
            Color = color;
            Type = type;
        }
    

    public enum PieceType
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn
    }
    public static Piece p1 = new Piece ("White", PieceType.King);
    public static Piece p2 = new Piece ("White", PieceType.Queen);
    public static Piece p3 = new Piece ("White", PieceType.Rook);
    public static Piece p4 = new Piece ("White", PieceType.Bishop);
    public static Piece p5 = new Piece ("White", PieceType.Knight);
    public static Piece p6 = new Piece ("White", PieceType.Pawn);
    


    
}  
}