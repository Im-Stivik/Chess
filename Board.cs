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
            
            //saving some information for convenience
            ProjectEnums.Team playerTeam = GameSession.playerTeam;
            ProjectEnums.Team enemyTeam = ProjectEnums.GetOppositeTeam(playerTeam);
            
            //create pawns
            Console.WriteLine("Creating pawns");
            for (int i = 0; i < 8; i++)
            {
                Replace(cells[i, 1], new GamePicces.Pawn(i, 1, enemyTeam));
                Replace(cells[i, 6], new GamePicces.Pawn(i, 6, playerTeam));
            }

            //create rooks
            Console.WriteLine("Creating rooks");
            Replace(cells[0, 0], new GamePicces.Rook(0, 0, enemyTeam));
            Replace(cells[7, 0], new GamePicces.Rook(7, 0, enemyTeam));
            Replace(cells[0, 7], new GamePicces.Rook(0, 7, playerTeam));
            Replace(cells[7, 7], new GamePicces.Rook(7, 7, playerTeam));
            //create knights
            Console.WriteLine("Creating knights");
            Replace(cells[1, 0], new GamePicces.Knight(1, 0, enemyTeam));
            Replace(cells[6, 0], new GamePicces.Knight(6, 0, enemyTeam));
            Replace(cells[1, 7], new GamePicces.Knight(1, 7, playerTeam));
            Replace(cells[6, 7], new GamePicces.Knight(6, 7, playerTeam));
            //create bishops
            Console.WriteLine("Creating bishops");
            Replace(cells[2, 0], new GamePicces.Bishop(2, 0, enemyTeam));
            Replace(cells[5, 0], new GamePicces.Bishop(5, 0, enemyTeam));
            Replace(cells[2, 7], new GamePicces.Bishop(2, 7, playerTeam));
            Replace(cells[5, 7], new GamePicces.Bishop(5, 7, playerTeam));
            //create queens
            Console.WriteLine("Creating queens");
            Replace(cells[4, 0], new GamePicces.Queen(4, 0, enemyTeam));
            Replace(cells[4, 7], new GamePicces.Queen(4, 7, playerTeam));
            
            //create kings
            Console.WriteLine("Creating kings");
            Replace(cells[3, 0], new GamePicces.King(3, 0, enemyTeam));
            Replace(cells[3, 7], new GamePicces.King(3, 7, playerTeam));
            
            UpdateMoves();
        }


        public static void Replace(Cell remove, Cell add)
        {
            cells[remove.GetPoint().GetX(), remove.GetPoint().GetY()] = add;
            context.Controls.Remove(remove);
            context.Controls.Add(add);
        }

        public static void Replace(int x, int y, Cell add)
        {
            context.Controls.Remove(cells[x, y]);
            cells[x, y] = add;
            context.Controls.Add(add);
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

        public static void UpdateMovesForTeam(ProjectEnums.Team team)
        {
            foreach (Cell c in cells)
            {
                if (c.GetType() != ProjectEnums.PieceType.None)
                {
                    Pies p = (Pies)c;
                    if (p.GetTeam() == team)
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
        public static void UpdateMoves(Point p)
        {
            UpdateMoves(p.GetX(), p.GetY());
        }
        
        public static void UpdateMoves(Pies p)
        {
            UpdateMoves(p.GetPoint());
        }

        public static bool CheckForCheck(ProjectEnums.Team team)
        {
            for (int i = 0; i < GameSettings.BoardSize; i++)
            {
                for(int j = 0; j < GameSettings.BoardSize; j++)
                {
                    if (cells[i, j].GetType() != ProjectEnums.PieceType.None)
                    {
                        Pies pies = (Pies)cells[i, j];
                        if (pies.GetTeam() != team)
                        {
                            if (pies.IsMakingCheck())
                            {

                                return true;
                            }
                            
                        }
                    }
                }
            }

            return false;
        }

        public static bool WillMoveCauseCheck(MoveOption move)
        {
            ICommand command = new BackGroundMoveCommand(move);
            
            
            command.Execute();

            UpdateMovesForTeam(ProjectEnums.GetOppositeTeam(move.GetOwner().GetTeam()));

            bool check = CheckForCheck(move.GetOwner().GetTeam());
            command.Cancle();

            return check;
        }

        public static void FilterMovesForTeam(ProjectEnums.Team team)
        {
            for(int i = 0; i < GameSettings.BoardSize; i++)
            {
                for(int j = 0; j < GameSettings.BoardSize; j++)
                {
                    if (cells[i, j].GetType() != ProjectEnums.PieceType.None)
                    {
                        Pies p = (Pies)cells[i, j];
                        if (p.GetTeam() == team)
                        {
                            p.RemoveOptionThatWillMakeCheck();
                        }
                    }
                }
            }
        }
        
        public static bool CheckForCheckMate(ProjectEnums.Team team)
        {
            Console.WriteLine("Checking for check mate!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            for(int i = 0; i < GameSettings.BoardSize; i++)
            {
                for(int j = 0; j < GameSettings.BoardSize; j++)
                {
                    if (cells[i, j].GetType() != ProjectEnums.PieceType.None)
                    {
                        Pies p = (Pies)cells[i, j];
                        if (p.GetTeam() == team)
                        {
                            if (p.GetMoveOptions().Length > 0)
                            {
                                return false;
                            }

                            Console.WriteLine(p + "Have " + p.GetMoveOptions() + " options");
                        }
                    }
                }
            }
            return true;
        }
    }
}