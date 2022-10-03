using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Chess
{
    public class Board
    {
        public static Cell[,] cells = new Cell[8, 8];
        public static Form context;
        private static List<OptionCell> currentOptions = new List<OptionCell>();
        public static Pies selectedCell = null;
        
        public static void Init(Form context)
        {
            Board.context = context;
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
            for (int i = 0; i < 8; i++)
            {
                Replace(cells[i, 1], new GamePicces.Pawn(i, 1, ProjectEnums.OPPONENT));
                Replace(cells[i, 6], new GamePicces.Pawn(i, 6, ProjectEnums.PLAYER));
            }
            //create rooks
            Replace(cells[0, 0], new GamePicces.Rook(0, 0, ProjectEnums.OPPONENT));
            Replace(cells[7, 0], new GamePicces.Rook(7, 0, ProjectEnums.OPPONENT));
            Replace(cells[0, 7], new GamePicces.Rook(0, 7, ProjectEnums.PLAYER));
            Replace(cells[7, 7], new GamePicces.Rook(7, 7, ProjectEnums.PLAYER));
            //create knights
            Replace(cells[1, 0], new GamePicces.Knight(1, 0, ProjectEnums.OPPONENT));
            Replace(cells[6, 0], new GamePicces.Knight(6, 0, ProjectEnums.OPPONENT));
            Replace(cells[1, 7], new GamePicces.Knight(1, 7, ProjectEnums.PLAYER));
            Replace(cells[6, 7], new GamePicces.Knight(6, 7, ProjectEnums.PLAYER));
            //create bishops
            Replace(cells[2, 0], new GamePicces.Bishop(2, 0, ProjectEnums.OPPONENT));
            Replace(cells[5, 0], new GamePicces.Bishop(5, 0, ProjectEnums.OPPONENT));
            Replace(cells[2, 7], new GamePicces.Bishop(2, 7, ProjectEnums.PLAYER));
            Replace(cells[5, 7], new GamePicces.Bishop(5, 7, ProjectEnums.PLAYER));
            //create queens
            Replace(cells[3, 0], new GamePicces.Queen(3, 0, ProjectEnums.OPPONENT));
            Replace(cells[3, 7], new GamePicces.Queen(3, 7, ProjectEnums.PLAYER));
            //create kings
            Replace(cells[4, 0], new GamePicces.King(4, 0, ProjectEnums.OPPONENT));
            Replace(cells[4, 7], new GamePicces.King(4, 7, ProjectEnums.PLAYER));
        }


        public static void Replace(Cell remove, Cell add)
        {
            cells[remove.X, remove.Y] = add;
            context.Controls.Remove(remove);
            context.Controls.Add(add);
        }
        
        public static void AddMoveOption(int x, int y)
        {
            OptionCell option = new OptionCell(cells[x,y]);
            Replace(cells[x, y], option);
            currentOptions.Add(option);
            Console.WriteLine("Added option");
            
        }
        
        public static void ClearOptions()
        {
            foreach (OptionCell c in currentOptions)
            {
                Replace(c, c.Target);
            }
            currentOptions.Clear();
            //make the selected cell back to normal
            if (selectedCell != null)
            {
                if ((selectedCell.X + selectedCell.Y) % 2 == 0)
                {
                    selectedCell.BackColor = GameSettings.LightColor;
                }
                else
                {
                    selectedCell.BackColor = GameSettings.DarkColor;
                }
                selectedCell = null;
            }
        }
        
        public static bool isCellEmpty(int x, int y)
        {
            if (!isInBoard(x, y))
            {
                Console.Error.WriteLine("Cell is not in board");
            }
            return cells[x, y].PieceType == ProjectEnums.PieceType.None;
        }
        
        public static bool isInBoard(int x, int y)
        {
            return x >= 0 && x < 8 && y >= 0 && y < 8;
        }
        
        public static Pies GetPiece(int x, int y)
        {
            if(cells[x,y].PieceType == ProjectEnums.PieceType.None)
            {
                return null;
            }
            return (Pies)cells[x, y];
        }

        public static bool IsEnemy(int x, int y, int team)
        {
            if (!isInBoard(x, y)) return false;
            if (cells[x, y].PieceType == ProjectEnums.PieceType.None) return false;
            Pies p = (Pies)cells[x, y];
            return (p.Team != team);
        }
    }
}