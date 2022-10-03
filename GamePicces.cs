using System;
using System.Drawing;

namespace Chess
{
    public class GamePicces
    {
        public class Pawn : Pies
        {
            private bool moved = false;

            public Pawn(int x, int y, int team) : base(x, y, team)
            {
                this.PieceType = ProjectEnums.PieceType.Pawn;
                if (this._team == GameSession.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.PawnWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.PawnBlack;
                }
            }

            public override void CreateOptions(object sender, EventArgs e)
            {
                if (this._team == ProjectEnums.OPPONENT)
                {
                    EnemyOptions(this, EventArgs.Empty);
                    return;
                }

                Board.ClearOptions();
                if (CheckMove(this.X, this.Y - 1))
                {
                    Board.AddMoveOption(this.X, this.Y - 1);
                    if (!moved)
                    {
                        if (CheckMove(this.X, this.Y - 2))
                        {
                            Board.AddMoveOption(this.X, this.Y - 2);
                        }
                    }
                }
            }

            public void EnemyOptions(object sender, EventArgs e)
            {
                Board.ClearOptions();
                if (CheckMove(this.X, this.Y + 1))
                {
                    Board.AddMoveOption(this.X, this.Y + 1);
                    if (!moved)
                    {
                        if (CheckMove(this.X, this.Y + 2))
                        {
                            Board.AddMoveOption(this.X, this.Y + 2);
                        }
                    }
                }
            }

            private static bool CheckMove(int x, int y)
            {
                return Board.isInBoard(x, y) && Board.isCellEmpty(x, y);
            }
        }

        public class Rook : Pies
        {
            public Rook(int x, int y, int team) : base(x, y, team)
            {
                this.PieceType = ProjectEnums.PieceType.Rook;
                if (this._team == GameSession.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.RookWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.RookBlack;
                }
            }

            public override void CreateOptions(object sender, EventArgs e)
            {
                Board.ClearOptions();
                int offset;
                //check up
                offset = 1;
                while (checkMove(this.X, this.Y - offset))
                {
                    Board.AddMoveOption(this.X, this.Y - offset);
                    offset++;
                }

                if (Board.IsEnemy(this.X, this.Y - offset, this._team))
                {
                    Board.AddMoveOption(this.X, this.Y - offset);
                }

                //check down
                offset = 1;
                while (checkMove(this.X, this.Y + offset))
                {
                    Board.AddMoveOption(this.X, this.Y + offset);
                    offset++;
                }

                if (Board.IsEnemy(this.X, this.Y + offset, this._team))
                {
                    Board.AddMoveOption(this.X, this.Y + offset);
                }

                //check left
                offset = 1;
                while (checkMove(this.X - offset, this.Y))
                {
                    Board.AddMoveOption(this.X - offset, this.Y);
                    offset++;
                }

                if (Board.IsEnemy(this.X - offset, this.Y, this._team))
                {
                    Board.AddMoveOption(this.X - offset, this.Y);
                }

                //check right
                offset = 1;
                while (checkMove(this.X + offset, this.Y))
                {
                    Board.AddMoveOption(this.X + offset, this.Y);
                    offset++;
                }

                if (Board.IsEnemy(this.X + offset, this.Y, this._team))
                {
                    Board.AddMoveOption(this.X + offset, this.Y);
                }
            }

            private bool checkMove(int x, int y)
            {
                if (!Board.isInBoard(x, y))
                {
                    return false;
                }

                return Board.isCellEmpty(x, y);
            }
        }

        public class Knight : Pies
        {
            public Knight(int x, int y, int team) : base(x, y, team)
            {
                this.PieceType = ProjectEnums.PieceType.Knight;
                if (this._team == GameSession.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.KnightWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.KnightBlack;
                }
            }

            public override void CreateOptions(object sender, EventArgs e)
            {
                Board.ClearOptions();
                if (checkMove(this.X + 1, this.Y + 2))
                {
                    Board.AddMoveOption(this.X + 1, this.Y + 2);
                }

                if (checkMove(this.X - 1, this.Y + 2))
                {
                    Board.AddMoveOption(this.X - 1, this.Y + 2);
                }

                if (checkMove(this.X + 1, this.Y - 2))
                {
                    Board.AddMoveOption(this.X + 1, this.Y - 2);
                }

                if (checkMove(this.X - 1, this.Y - 2))
                {
                    Board.AddMoveOption(this.X - 1, this.Y - 2);
                }

                if (checkMove(this.X + 2, this.Y + 1))
                {
                    Board.AddMoveOption(this.X + 2, this.Y + 1);
                }

                if (checkMove(this.X - 2, this.Y + 1))
                {
                    Board.AddMoveOption(this.X - 2, this.Y + 1);
                }

                if (checkMove(this.X + 2, this.Y - 1))
                {
                    Board.AddMoveOption(this.X + 2, this.Y - 1);
                }

                if (checkMove(this.X - 2, this.Y - 1))
                {
                    Board.AddMoveOption(this.X - 2, this.Y - 1);
                }
            }

            private bool checkMove(int x, int y)
            {
                if (!Board.isInBoard(x, y))
                {
                    return false;
                }

                return Board.isCellEmpty(x, y) || Board.IsEnemy(x, y, this._team);
            }
        }

        public class Bishop : Pies
        {
            public Bishop(int x, int y, int team) : base(x, y, team)
            {
                this.PieceType = ProjectEnums.PieceType.Bishop;
                if (this._team == GameSession.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.BishopWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.BishopBlack;
                }
            }

            public override void CreateOptions(object sender, EventArgs e)
            {
                Board.ClearOptions();
                int offset;
                //check up left
                offset = 1;
                while (checkMove(this.X - offset, this.Y - offset))
                {
                    Board.AddMoveOption(this.X - offset, this.Y - offset);
                    offset++;
                }

                if (Board.IsEnemy(this.X - offset, this.Y - offset, this._team))
                {
                    Board.AddMoveOption(this.X - offset, this.Y - offset);
                }

                //check up right
                offset = 1;
                while (checkMove(this.X + offset, this.Y - offset))
                {
                    Board.AddMoveOption(this.X + offset, this.Y - offset);
                    offset++;
                }

                if (Board.IsEnemy(this.X + offset, this.Y - offset, this._team))
                {
                    Board.AddMoveOption(this.X + offset, this.Y - offset);
                }

                //check down left
                offset = 1;
                while (checkMove(this.X - offset, this.Y + offset))
                {
                    Board.AddMoveOption(this.X - offset, this.Y + offset);
                    offset++;
                }

                if (Board.IsEnemy(this.X - offset, this.Y + offset, this._team))
                {
                    Board.AddMoveOption(this.X - offset, this.Y + offset);
                }

                //check down right
                offset = 1;
                while (checkMove(this.X + offset, this.Y + offset))
                {
                    Board.AddMoveOption(this.X + offset, this.Y + offset);
                    offset++;
                }

                if (Board.IsEnemy(this.X + offset, this.Y + offset, this._team))
                {
                    Board.AddMoveOption(this.X + offset, this.Y + offset);
                }
            }

            private bool checkMove(int x, int y)
            {
                if (!Board.isInBoard(x, y))
                {
                    return false;
                }

                return Board.isCellEmpty(x, y);
            }
        }

        public class Queen : Pies
        {
            public Queen(int x, int y, int team) : base(x, y, team)
            {
                this.PieceType = ProjectEnums.PieceType.Queen;
                if (this._team == GameSession.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.QueenWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.QweenBlack;
                }
            }

            public override void CreateOptions(object sender, EventArgs e)
            {
                Board.ClearOptions();
                int offset;
                //check up
                offset = 1;
                while (checkMove(this.X, this.Y - offset))
                {
                    Board.AddMoveOption(this.X, this.Y - offset);
                    offset++;
                }

                if (Board.IsEnemy(this.X, this.Y - offset, this._team))
                {
                    Board.AddMoveOption(this.X, this.Y - offset);
                }

                //check down
                offset = 1;
                while (checkMove(this.X, this.Y + offset))
                {
                    Board.AddMoveOption(this.X, this.Y + offset);
                    offset++;
                }

                if (Board.IsEnemy(this.X, this.Y + offset, this._team))
                {
                    Board.AddMoveOption(this.X, this.Y + offset);
                }

                //check left
                offset = 1;
                while (checkMove(this.X - offset, this.Y))
                {
                    Board.AddMoveOption(this.X - offset, this.Y);
                    offset++;
                }

                if (Board.IsEnemy(this.X - offset, this.Y, this._team))
                {
                    Board.AddMoveOption(this.X - offset, this.Y);
                }

                //check right
                offset = 1;
                while (checkMove(this.X + offset, this.Y))
                {
                    Board.AddMoveOption(this.X + offset, this.Y);
                    offset++;
                }

                if (Board.IsEnemy(this.X + offset, this.Y, this._team))
                {
                    Board.AddMoveOption(this.X + offset, this.Y);
                }

                //check up left
                offset = 1;
                while (checkMove(this.X - offset, this.Y - offset))
                {
                    Board.AddMoveOption(this.X - offset, this.Y - offset);
                    offset++;
                }

                if (Board.IsEnemy(this.X - offset, this.Y - offset, this._team))
                {
                    Board.AddMoveOption(this.X - offset, this.Y - offset);
                }
                //check up right
                offset = 1;
                while (checkMove(this.X + offset, this.Y - offset))
                {
                    Board.AddMoveOption(this.X + offset, this.Y - offset);
                    offset++;
                }
                //check down left
                offset = 1;
                while (checkMove(this.X - offset, this.Y + offset))
                {
                    Board.AddMoveOption(this.X - offset, this.Y + offset);
                    offset++;
                }
                //check down right
                offset = 1;
                while (checkMove(this.X + offset, this.Y + offset))
                {
                    Board.AddMoveOption(this.X + offset, this.Y + offset);
                    offset++;
                }
            }

            private bool checkMove(int x, int y)
            {
                if (!Board.isInBoard(x, y))
                {
                    return false;
                }

                return Board.isCellEmpty(x, y);
            }

        }

        public class King : Pies
        {
            public King(int x, int y, int team) : base(x, y, team)
            {
                this.PieceType = ProjectEnums.PieceType.King;
                if (this._team == GameSession.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.KingWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.KingBlack;
                }
            }
            
            public override void CreateOptions(object sender, EventArgs e)
            {
                Board.ClearOptions();
                //check up
                if (checkMove(this.X, this.Y - 1))
                {
                    Board.AddMoveOption(this.X, this.Y - 1);
                }
                //check down
                if (checkMove(this.X, this.Y + 1))
                {
                    Board.AddMoveOption(this.X, this.Y + 1);
                }
                //check left
                if (checkMove(this.X - 1, this.Y))
                {
                    Board.AddMoveOption(this.X - 1, this.Y);
                }
                //check right
                if (checkMove(this.X + 1, this.Y))
                {
                    Board.AddMoveOption(this.X + 1, this.Y);
                }
                //check up left
                if (checkMove(this.X - 1, this.Y - 1))
                {
                    Board.AddMoveOption(this.X - 1, this.Y - 1);
                }
                //check up right
                if (checkMove(this.X + 1, this.Y - 1))
                {
                    Board.AddMoveOption(this.X + 1, this.Y - 1);
                }
                //check down left
                if (checkMove(this.X - 1, this.Y + 1))
                {
                    Board.AddMoveOption(this.X - 1, this.Y + 1);
                }
                //check down right
                if (checkMove(this.X + 1, this.Y + 1))
                {
                    Board.AddMoveOption(this.X + 1, this.Y + 1);
                }
            }
            
            private bool checkMove(int x, int y)
            {
                if (!Board.isInBoard(x, y))
                {
                    return false;
                }

                return Board.isCellEmpty(x, y);
            }
        }
    }
}