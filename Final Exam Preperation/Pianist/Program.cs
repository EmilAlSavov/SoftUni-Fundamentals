using System;
using System.Collections.Generic;
using System.Linq;

namespace Pianist
{
    class Piece
    {
        public string PieceName { get; set; }

        public string Composer { get; set; }

        public string Key { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Piece> pieces = GetDefaultPieces(n);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                
                string commandType = command[0];

                if (commandType == "Add")
                {
                    string pieceName = command[1];
                    string composer = command[2];
                    string key = command[3];

                    if (pieces.Any(x => x.PieceName == pieceName))
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                        continue;
                    }
                    pieces.Add(new Piece() { Composer = composer, Key = key, PieceName = pieceName });
                    Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                }
                else if (commandType == "Remove")
                {
                    string pieceName = command[1];

                    var removePiece = pieces.SingleOrDefault(x => x.PieceName == pieceName);
                    if (removePiece != null)
                    {
                        pieces.Remove(removePiece);
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (commandType == "ChangeKey")
                {
                    string pieceName = command[1];
                    string key = command[2];

                    var changeKeyPiece = pieces.FirstOrDefault(x => x.PieceName == pieceName);

                    if (changeKeyPiece != null)
                    {
                        changeKeyPiece.Key = key;
                        Console.WriteLine($"Changed the key of {pieceName} to {key}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
            }
            PrintPieces(pieces);
        }

        static void PrintPieces(List<Piece> pieces)
        {
            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.PieceName} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }

        static List<Piece> GetDefaultPieces(int num)
        {
            List<Piece> defaultPieces = new List<Piece>();

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string pieceName = command[0];
                string composer = command[1];
                string key = command[2];

                Piece piece = new Piece() { Composer = composer, Key = key, PieceName = pieceName };
                defaultPieces.Add(piece);
            }
            return defaultPieces;
        }
    }
}
