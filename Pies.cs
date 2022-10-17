using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Chess
{
    public abstract class Pies: Cell
    {
        protected ProjectEnums.Team team;
        protected MoveOption[] moveOptions;
        protected bool IsMoved = false;

        //getters and setters
        public ProjectEnums.Team GetTeam(){return team;}
        public MoveOption[] GetMoveOptions(){return moveOptions;}
    
        //constructor    
        public Pies(int x, int y,ProjectEnums.Team team) : base(x, y)
        {
            this.team = team;
            this.Click += new EventHandler(OnClick);
        }
        
        //creates all the move options
        public abstract void CreateOptions();

        //will change the pies point and back color to match new location
        public void Move(int x, int y)
        {
            this.point.SetX(x);
            this.point.SetY(y);
            this.Location = this.point.GetLocation();
            this.BackColor = Cell.GetBackColor(this.point);
            if (this.GetType() == ProjectEnums.PieceType.Pawn && y == 0)
            {
                //TODO: make animation
            }

            IsMoved = true;
        }

        //will make all the move options visible
        public void ShowMoveOptions()
        {
            Board.ClearOptions();
            Console.WriteLine("Showing move options for " + this.pieceType + "...");
            Console.WriteLine("\tMove options: " + moveOptions.Length);
            for (int i = 0; i < moveOptions.Length; i++)
            {
                Console.Write("\t\tShowing option for: " + moveOptions[i].ToString());
                moveOptions[i].ShowOption();
                Console.WriteLine("Done!");
            }
            Console.WriteLine("Done!");
            
            this.BackColor = GameSettings.SelectedColor;
            Board.selectedCell = this;
            this.selectionState = ProjectEnums.SelectionState.Selected;
        }

        //will hide all the options
        public void HideMoveOptions()
        {
            Console.WriteLine("Hiding move options for " + this.pieceType + "...");
            for (int i = 0; i < moveOptions.Length; i++)
            {
                moveOptions[i].HideOption();
            }
            
            this.BackColor = Cell.GetBackColor(this.point);
            Board.selectedCell = null;
            this.selectionState = ProjectEnums.SelectionState.NotSelected;
        }
        
        //will call the right click method when the cell is clicked
        public void OnClick(object sender, EventArgs e)
        {
            if (!GameSession.IsBoardLatest) return;
            if (selectionState == ProjectEnums.SelectionState.SelectedByMove) return;
            Board.ClearOptions();
            if(this.selectionState == ProjectEnums.SelectionState.NotSelected)
            {
                this.selectionState = ProjectEnums.SelectionState.Selected;
                this.ShowMoveOptions();
            }
            else
            {
                this.selectionState = ProjectEnums.SelectionState.NotSelected;
                this.HideMoveOptions();
            }
        }

        public override void MakeSelectedByMove(Pies owner)
        {
            base.MakeSelectedByMove(owner);
            this.BackColor = GameSettings.EatPiesOptionColor;
        }
        
        public bool IsMakingCheck()
        {
            for (int i = 0; i < moveOptions.Length; i++)
            {
                if (moveOptions[i].IsMakingCheck())
                {
                    return true;
                }
            }
            
            return false;
        }
        
        public void RemoveOptionThatWillMakeCheck()
        {
            Console.WriteLine("Removing options that will make check...");
            List<MoveOption> options = new List<MoveOption>();
            for(int i = 0; i < moveOptions.Length; i++)
            {
                if (Board.WillMoveCauseCheck(moveOptions[i]))
                {
                    Console.WriteLine("Removing option that will make check: " + moveOptions[i].ToString());
                }
                else
                {
                    options.Add(moveOptions[i]);
                }
            }

            Console.WriteLine("Done!");
            moveOptions = options.ToArray();
        }
    }
}