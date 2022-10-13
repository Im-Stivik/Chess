using System;
using System.Collections.Generic;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Chess
{
    public class Board
    {
        public static Cell[,] cells = new Cell[8, 8];
        public static Form context;
        public static Pies selectedCell;

        private static GamePicces.King whiteKing;
        private static GamePicces.King blackKing;
        
        public static GamePicces.King GetKing(ProjectEnums.Team team)
        {
            if (team == ProjectEnums.Team.WhiteTeam)
            {
                return whiteKing;
            }
            return blackKing;
            }

        public static void Init(Form context)
        {
            Board.context = context;
            Console.WriteLine("Creating cells");
            //create cells
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    cells[i, j] = new Cell(i, j);
                    context.Controls.Add(cells[i, j]);
                }
            }

            //create pawns
            Console.WriteLine("Creating pawns");
            for (int i = 0; i < 8; i++)
            {
                Replace(cells[i, 1], new GamePicces.Pawn(i, 1, ProjectEnums.Team.WhiteTeam));
                Replace(cells[i, 6], new GamePicces.Pawn(i, 6, ProjectEnums.Team.BlackTeam));
            }

            //create rooks
            Console.WriteLine("Creating rooks");
            Replace(cells[0, 0], new GamePicces.Rook(0, 0, ProjectEnums.Team.WhiteTeam));
            Replace(cells[7, 0], new GamePicces.Rook(7, 0, ProjectEnums.Team.WhiteTeam));
            Replace(cells[0, 7], new GamePicces.Rook(0, 7, ProjectEnums.Team.BlackTeam));
            Replace(cells[7, 7], new GamePicces.Rook(7, 7, ProjectEnums.Team.BlackTeam));
            //create knights
            Console.WriteLine("Creating knights");
            Replace(cells[1, 0], new GamePicces.Knight(1, 0, ProjectEnums.Team.WhiteTeam));
            Replace(cells[6, 0], new GamePicces.Knight(6, 0, ProjectEnums.Team.WhiteTeam));
            Replace(cells[1, 7], new GamePicces.Knight(1, 7, ProjectEnums.Team.BlackTeam));
            Replace(cells[6, 7], new GamePicces.Knight(6, 7, ProjectEnums.Team.BlackTeam));
            //create bishops
            Console.WriteLine("Creating bishops");
            Replace(cells[2, 0], new GamePicces.Bishop(2, 0, ProjectEnums.Team.WhiteTeam));
            Replace(cells[5, 0], new GamePicces.Bishop(5, 0, ProjectEnums.Team.WhiteTeam));
            Replace(cells[2, 7], new GamePicces.Bishop(2, 7, ProjectEnums.Team.BlackTeam));
            Replace(cells[5, 7], new GamePicces.Bishop(5, 7, ProjectEnums.Team.BlackTeam));
            //create queens
            Console.WriteLine("Creating queens");
            Replace(cells[4, 0], new GamePicces.Queen(4, 0, ProjectEnums.Team.WhiteTeam));
            Replace(cells[4, 7], new GamePicces.Queen(4, 7, ProjectEnums.Team.BlackTeam));
            
            //create kings
            Console.WriteLine("Creating kings");
            Replace(cells[3, 0], new GamePicces.King(3, 0, ProjectEnums.Team.WhiteTeam));
            Replace(cells[3, 7], new GamePicces.King(3, 7, ProjectEnums.Team.BlackTeam));
            
            UpdateMoves();
        }


        public static void Replace(Cell remove, Cell add)
        {
            cells[remove.GetPoint().GetX(), remove.GetPoint().GetY()] = add;
            context.Controls.Remove(remove);
            context.Controls.Add(add);
            //if the cell is King update its position
            if (add.GetType() == ProjectEnums.PieceType.King)
            {
                GamePicces.King king = (GamePicces.King)add;
                if (king.GetTeam() == ProjectEnums.Team.WhiteTeam)
                    whiteKing = king;
                else
                    blackKing = king;
            }
        }

        public static void Replace(int x, int y, Cell add)
        {
            context.Controls.Remove(cells[x, y]);
            cells[x, y] = add;
            context.Controls.Add(add);
            if (add.GetType() == ProjectEnums.PieceType.King)
            {
                GamePicces.King king = (GamePicces.King)add;
                if (king.GetTeam() == ProjectEnums.Team.WhiteTeam)
                    whiteKing = king;
                else
                    blackKing = king;
            }
        }

        public static void ClearOptions()
        {
            if (selectedCell != null)
            {
                selectedCell.HideMoveOptions();
            }
        }

        public static Point[] GetPiecesLocations()
        {
            List<Point> pieces = new List<Point>();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (cells[i, j] is Pies)
                    {
                        pieces.Add((new Point(i, j)));
                    }
                }
            }
            return pieces.ToArray();
        }
        
        public static bool isCellEmpty(int x, int y)
        {
            if (!isInBoard(x, y))
            {
                Console.Error.WriteLine("Cell is not in board");
            }

            return cells[x, y].GetType() == ProjectEnums.PieceType.None;
        }

        public static bool isInBoard(int x, int y)
        {
            return x >= 0 && x < 8 && y >= 0 && y < 8;
        }

        public static bool IsEnemy(int x, int y, ProjectEnums.Team team)
        {
            if (!isInBoard(x, y)) return false;
            if (cells[x, y].GetType() == ProjectEnums.PieceType.None) return false;
            Pies p = (Pies)cells[x, y];
            return (p.GetTeam() != team);
        }

        public static void UpdateMoves()
        {
            foreach (Cell c in cells)
            {
                if (c.GetType() != ProjectEnums.PieceType.None)
                {
                    Pies p = (Pies)c;
                    p.CreateOptions();
                }
            }
        }

        public static void UpdateMoves(int x, int y)
        {
            if (isInBoard(x, y))
            {
                if (cells[x, y].GetType() != ProjectEnums.PieceType.None)
                {
                    Pies p = (Pies)cells[x, y];
                    p.CreateOptions();
                }
            }
        }

        public static bool CheckForCheckMate()
        {
            //todo: implement
            return false;
        }
    }
}