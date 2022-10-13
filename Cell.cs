using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Chess
{
    public class Cell : Label
    {
        protected Point point;
        protected ProjectEnums.PieceType pieceType;
        protected ProjectEnums.SelectionState selectionState = ProjectEnums.SelectionState.NotSelected;
        private Pies owner = null;
        
        
        //getters and setters
        public Point GetPoint(){return this.point;}
        public void SetPoint(Point point){this.point = new Point(point);}
        public ProjectEnums.PieceType GetType(){return this.pieceType;}
        
        //constructor
        public Cell(int x, int y)
        {
            this.point = new Point(x, y);
            this.Width = GameSettings.PieceSize;
            this.Height = GameSettings.PieceSize;
            this.Location = point.GetLocation();
            this.BackColor = GetBackColor(this.point);
            this.pieceType = ProjectEnums.PieceType.None;

        }
        
        //constructor with point
        public Cell(Point point)
        {
            this.point = new Point(point);
            this.Width = GameSettings.PieceSize;
            this.Height = GameSettings.PieceSize;
            this.Location = point.GetLocation();
            this.BackColor = GetBackColor(this.point);
            this.pieceType = ProjectEnums.PieceType.None;
        }

        //copy constructor
        public Cell(Cell cell)
        {
            this.point = new Point(cell.point);
            this.Width = GameSettings.PieceSize;
            this.Height = GameSettings.PieceSize;
            this.Location = this.point.GetLocation();
        }
        
        //returns the needed back color
        public static System.Drawing.Color GetBackColor(Point point)
        {
            if ((point.GetX() + point.GetY()) % 2 == 0)
            {
               return GameSettings.LightColor;
            }
            else
            {
                return GameSettings.DarkColor;
            }
        }

        public virtual void MakeSelectedByMove(Pies owner)
        {
            this.owner = owner;
            this.BackColor = GameSettings.OptionsColor;
            this.selectionState = ProjectEnums.SelectionState.SelectedByMove;
            this.Click += new EventHandler(ClickedSelected);
        }
        
        public void MakeUnselected()
        {
            this.selectionState = ProjectEnums.SelectionState.NotSelected;
            this.BackColor = Cell.GetBackColor((this.GetPoint()));
            this.owner = null;
            this.Click -= new EventHandler(ClickedSelected);
        }
        
        public override string ToString()
        {
            return pieceType +" " + this.point.ToString();
        }

        public virtual void ClickedSelected(object sender, EventArgs e)
        {
            if (!canPlayerMove()) return;
            if (this.selectionState != ProjectEnums.SelectionState.SelectedByMove) return;
            ICommand command = new MoveCommand(this.GetPoint().GetX(),this.GetPoint().GetY(),this.owner);
            GameSession.ExecuteCommand(command);
        }
        
        protected bool canPlayerMove(){
            if(GameSession.gameType == ProjectEnums.GameType.Local)
                return GameSession.currentTurn == this.owner.GetTeam();
            return GameSession.IsPlayerTurn();
        }
    }
}