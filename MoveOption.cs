using System;

namespace Chess
{
    public class MoveOption
    {
        private Pies owner;
        private Cell target;
        private bool isOnPies;
        
        //constructor
        public MoveOption(Pies owner, ref Cell target, bool isOnPies)
        {
            this.owner = owner;
            this.target = target;
            this.isOnPies = isOnPies;
        }
        
        //constructor with owner, point and is on pies
        public MoveOption(Pies owner, Point target, bool isOnPies)
        {
            this.owner = owner;
            this.target = Board.cells[target.GetX(), target.GetY()];
            this.isOnPies = isOnPies;
        }

        //constructor with owner, x, y and is on pies
        public MoveOption(Pies owner, int x, int y, bool isOnPies)
        {
            this.owner = owner;
            this.target = Board.cells[x, y];
            this.isOnPies = isOnPies;
        }

        //constructor with owner, x, y, and check if is on pies
        public MoveOption(Pies owner, int x, int y)
        {
            this.owner = owner;
            this.target = Board.cells[x, y];
            this.isOnPies = target.GetType() != ProjectEnums.PieceType.None;
        }
        
        //getters and setters
        public Pies GetOwner()
        {
            return owner;
        }
        public Cell GetTarget()
        {
            return target;
        }
        
        public void ShowOption()
        {
            Board.cells[target.GetPoint().GetX(), target.GetPoint().GetY()].MakeSelectedByMove(owner);
        }

        public void HideOption()
        {
            Board.cells[target.GetPoint().GetX(), target.GetPoint().GetY()].MakeUnselected();
        }

        public override string ToString()
        {
            return owner.GetPoint() + " to " + target;
        }
    }
}