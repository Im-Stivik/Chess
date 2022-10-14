using System;
using System.Collections.Generic;
using System.Drawing;

namespace Chess
{
    public class GamePicces
    {
        public class Pawn : Pies
        {
            //constructor
            public Pawn(int x, int y, ProjectEnums.Team team) : base(x, y, team)
            {
                this.pieceType = ProjectEnums.PieceType.Pawn;
                if (this.team == ProjectEnums.Team.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.PawnWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.PawnBlack;
                }
            }

            public override void CreateOptions()
            {
                if (this.team != GameSession.playerTeam)
                {
                    EnemyOptions(this, EventArgs.Empty);
                    return;
                }
                List<MoveOption> optionsList = new List<MoveOption>();
                if (CheckMove(this.point.GetX(), this.point.GetY() - 1))
                {
                    optionsList.Add(new MoveOption(this,new Point(this.point.GetX(),this.point.GetY() - 1), false));
                    if (!IsMoved)
                    {
                        if (CheckMove(this.GetPoint().GetX(), this.point.GetY() - 2))
                        {
                            optionsList.Add(new MoveOption(this,this.point.GetX(),this.point.GetY() - 2, false));
                        }
                    }
                }

                if (Board.IsEnemy(this.point.GetX() + 1, this.GetPoint().GetY() - 1, this.GetTeam()))
                {
                    optionsList.Add(new MoveOption(this,this.point.GetX() + 1, this.GetPoint().GetY() - 1,true));
                }
                if(Board.IsEnemy(this.GetPoint().GetX() - 1, this.GetPoint().GetY() - 1, this.GetTeam()))
                {
                    optionsList.Add(new MoveOption(this,this.point.GetX() - 1, this.GetPoint().GetY() - 1,true));
                }
                this.moveOptions = optionsList.ToArray();
            }
            
            //seperate moves for the enemy
            public void EnemyOptions(object sender, EventArgs e)
            {
                List<MoveOption> optionsList = new List<MoveOption>();
                if (CheckMove(this.point.GetX(), this.point.GetY() + 1))
                {
                    optionsList.Add(new MoveOption(this,new Point(this.point.GetX(),this.point.GetY() + 1), false));
                    if (!IsMoved)
                    {
                        if (CheckMove(this.GetPoint().GetX(), this.point.GetY() + 2))
                        {
                            optionsList.Add(new MoveOption(this,this.point.GetX(),this.point.GetY() + 2, false));
                        }
                    }
                }

                if (Board.IsEnemy(this.point.GetX() + 1, this.GetPoint().GetY() + 1, this.GetTeam()))
                {
                    optionsList.Add(new MoveOption(this,this.point.GetX() + 1, this.GetPoint().GetY() + 1,true));
                }
                if(Board.IsEnemy(this.GetPoint().GetX() - 1, this.GetPoint().GetY() + 1, this.GetTeam()))
                {
                    optionsList.Add(new MoveOption(this,this.point.GetX() - 1, this.GetPoint().GetY() + 1,true));
                }

                this.moveOptions = optionsList.ToArray(); 
            }

            //checks if you can move to the given point
            private static bool CheckMove(int x, int y)
            {
                return Board.isInBoard(x, y) && Board.isCellEmpty(x, y);
            }
        }

        public class Rook : Pies
        {
            public Rook(int x, int y, ProjectEnums.Team team) : base(x, y, team)
            {
                this.pieceType = ProjectEnums.PieceType.Rook;
                if (this.team == ProjectEnums.Team.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.RookWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.RookBlack;
                }
            }

            public override void CreateOptions()
            {
                List<MoveOption> options = new List<MoveOption>();
                int offset = 1;
                //check up
                while (checkMove(this.GetPoint().GetX(), this.GetPoint().GetY() - offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() - offset,false));
                    offset++;
                }

                if (Board.IsEnemy(this.GetPoint().GetX(), this.GetPoint().GetY() - offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() - offset,true));
                }

                //check down
                offset = 1;
                while (checkMove(this.GetPoint().GetX(), this.GetPoint().GetY() + offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() + offset,false));
                    offset++;
                }

                if (Board.IsEnemy(this.GetPoint().GetX(), this.GetPoint().GetY() + offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() + offset,true));
                }

                //check left
                offset = 1;
                while (checkMove(this.GetPoint().GetX() - offset, this.GetPoint().GetY()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY(),false));
                    offset++;
                }

                if (Board.IsEnemy(this.GetPoint().GetX() - offset, this.GetPoint().GetY(), this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY(),true));
                }

                //check right
                offset = 1;
                while (checkMove(this.GetPoint().GetX() + offset, this.GetPoint().GetX()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY(),false));
                    offset++;
                }

                if (Board.IsEnemy(this.GetPoint().GetX() + offset, this.GetPoint().GetX(), this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY(),true));
                }
                this.moveOptions = options.ToArray();
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
            public Knight(int x, int y, ProjectEnums.Team team) : base(x, y, team)
            {
                this.pieceType = ProjectEnums.PieceType.Knight;
                if (this.team== ProjectEnums.Team.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.KnightWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.KnightBlack;
                }
            }

            public override void CreateOptions()
            {
                List<MoveOption> options = new List<MoveOption>();
                if (checkMove(this.GetPoint().GetX() + 1, this.GetPoint().GetY() + 2))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + 1,this.GetPoint().GetY() + 2));
                }

                if (checkMove(this.GetPoint().GetX() - 1, this.GetPoint().GetY() + 2))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - 1,this.GetPoint().GetY() + 2));
                }

                if (checkMove(this.GetPoint().GetX() + 1, this.GetPoint().GetY() - 2))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + 1,this.GetPoint().GetY() - 2));
                }

                if (checkMove(this.GetPoint().GetX() - 1, this.GetPoint().GetY() - 2))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - 1,this.GetPoint().GetY() - 2));
                }

                if (checkMove(this.GetPoint().GetX() + 2, this.GetPoint().GetY() + 1))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + 2,this.GetPoint().GetY() + 1));
                }
                
                if (checkMove(this.GetPoint().GetX() - 2, this.GetPoint().GetY() + 1))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - 2,this.GetPoint().GetY() + 1));
                }

                if (checkMove(this.GetPoint().GetX() + 2, this.GetPoint().GetY() - 1))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + 2,this.GetPoint().GetY() - 1));
                }

                if (checkMove(this.GetPoint().GetX() - 2, this.GetPoint().GetY() - 1))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - 2,this.GetPoint().GetY() - 1));
                }
                
                this.moveOptions = options.ToArray(); }

            private bool checkMove(int x, int y)
            {
                if (!Board.isInBoard(x, y))
                {
                    return false;
                }

                return Board.isCellEmpty(x, y) || Board.IsEnemy(x, y, this.GetTeam());
            }
        }

        public class Bishop : Pies
        {
            public Bishop(int x, int y, ProjectEnums.Team team) : base(x, y, team)
            {
                this.pieceType = ProjectEnums.PieceType.Bishop;
                if (this.team == ProjectEnums.Team.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.BishopWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.BishopBlack;
                }
            }

            public override void CreateOptions()
            {
                List<MoveOption> options = new List<MoveOption>();
                int offset;
                //check up left
                offset = 1;
                while (checkMove(this.GetPoint().GetX() - offset, this.GetPoint().GetY() - offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY() - offset,false));
                    offset++;
                }

                if (Board.IsEnemy(this.GetPoint().GetX() - offset, this.GetPoint().GetY() - offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY() - offset,true));
                }

                //check up right
                offset = 1;
                while (checkMove(this.GetPoint().GetX() + offset, this.GetPoint().GetY() - offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY() - offset,false));
                    offset++;
                }

                if (Board.IsEnemy(this.GetPoint().GetX() + offset, this.GetPoint().GetY() - offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY() - offset,true));
                }

                //check down left
                offset = 1;
                while (checkMove(this.GetPoint().GetX() - offset, this.GetPoint().GetY() + offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY() + offset,false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX() - offset, this.GetPoint().GetY() + offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY() + offset,true));
                }
                //check down right
                offset = 1;
                while (checkMove(this.GetPoint().GetX() + offset, this.GetPoint().GetY() + offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY() + offset,false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX() + offset, this.GetPoint().GetY() + offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY() + offset,true));
                }
                
                this.moveOptions = options.ToArray();
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
            public Queen(int x, int y, ProjectEnums.Team team) : base(x, y, team)
            {
                this.pieceType = ProjectEnums.PieceType.Queen;
                if (this.team == ProjectEnums.Team.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.QueenWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.QweenBlack;
                }
            }

            public override void CreateOptions()
            {
                List<MoveOption> options = new List<MoveOption>();
                int offset;
                //check up
                offset = 1;
                while (checkMove(this.GetPoint().GetX(), this.GetPoint().GetY() - offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() - offset,false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX(), this.GetPoint().GetY() - offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() - offset,true));
                }

                //check down
                offset = 1;
                while (checkMove(this.GetPoint().GetX(), this.GetPoint().GetY() + offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() + offset,false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX(), this.GetPoint().GetY() + offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() + offset,true));
                }

                //check left
                offset = 1;
                while (checkMove(this.GetPoint().GetX() - offset, this.GetPoint().GetY()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY(),false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX() - offset, this.GetPoint().GetY(), this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY(),true));
                }

                //check right
                offset = 1;
                while (checkMove(this.GetPoint().GetX() + offset, this.GetPoint().GetY()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY(),false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX() + offset, this.GetPoint().GetY(), this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY(),true));
                }

                //check up left
                offset = 1;
                while (checkMove(this.GetPoint().GetX() - offset, this.GetPoint().GetY() - offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY() - offset,false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX() - offset, this.GetPoint().GetY() - offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY() - offset,true));
                }

                //check up right
                offset = 1;
                while (checkMove(this.GetPoint().GetX() + offset, this.GetPoint().GetY() - offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY() - offset,false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX() + offset, this.GetPoint().GetY() - offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY() - offset,true));
                }
                //check down right
                offset = 1;
                while (checkMove(this.GetPoint().GetX() - offset, this.GetPoint().GetY() + offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY() + offset,false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX() - offset, this.GetPoint().GetY() + offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - offset,this.GetPoint().GetY() + offset,true));
                }
                
                //check down left
                offset = 1;
                while (checkMove(this.GetPoint().GetX() + offset, this.GetPoint().GetY() + offset))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY() + offset,false));
                    offset++;
                }
                
                if (Board.IsEnemy(this.GetPoint().GetX() + offset, this.GetPoint().GetY() + offset, this.GetTeam()))
                {
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + offset,this.GetPoint().GetY() + offset,true));
                }
                
                this.moveOptions = options.ToArray();
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
            public King(int x, int y, ProjectEnums.Team team) : base(x, y, team)
            {
                this.pieceType = ProjectEnums.PieceType.King;
                if (this.team == ProjectEnums.Team.WhiteTeam)
                {
                    this.Image = Chess.Properties.Resources.KingWhite;
                }
                else
                {
                    this.Image = Chess.Properties.Resources.KingBlack;
                }
            }
            
            public override void CreateOptions()
            {
                List<MoveOption> options = new List<MoveOption>();
                //check up
                if(checkMove(this.GetPoint().GetX(),this.GetPoint().GetY() -1))
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() - 1));
                //check down
                if(checkMove(this.GetPoint().GetX(),this.GetPoint().GetY() + 1))
                    options.Add(new MoveOption(this,this.GetPoint().GetX(),this.GetPoint().GetY() + 1));
                //check left
                if(checkMove(this.GetPoint().GetX() - 1,this.GetPoint().GetY()))
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - 1,this.GetPoint().GetY()));
                //check right
                if(checkMove(this.GetPoint().GetX() + 1,this.GetPoint().GetY()))
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + 1,this.GetPoint().GetY()));
                //check up left
                if(checkMove(this.GetPoint().GetX() - 1,this.GetPoint().GetY() - 1))
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - 1,this.GetPoint().GetY() - 1));
                //check up right
                if(checkMove(this.GetPoint().GetX() + 1,this.GetPoint().GetY() - 1))
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + 1,this.GetPoint().GetY() - 1));
                //check down left
                if(checkMove(this.GetPoint().GetX() - 1,this.GetPoint().GetY() + 1))
                    options.Add(new MoveOption(this,this.GetPoint().GetX() - 1,this.GetPoint().GetY() + 1));
                //check down right
                if(checkMove(this.GetPoint().GetX() + 1,this.GetPoint().GetY() + 1))
                    options.Add(new MoveOption(this,this.GetPoint().GetX() + 1,this.GetPoint().GetY() + 1));

                this.moveOptions = options.ToArray();
                
            }
            
            private bool checkMove(int x, int y)
            {
                if (!Board.isInBoard(x, y))
                {
                    return false;
                }

                return Board.isCellEmpty(x, y) || Board.IsEnemy(x,y,this.GetTeam());
            }
        }
    }
}