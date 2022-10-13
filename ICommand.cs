using System;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms.VisualStyles;

namespace Chess
{
    public interface ICommand
    {
        void Execute();

        void Cancle();
    }
    
    public class MoveCommand: ICommand
    {
        public Pies movedPies;
        public int fromX;
        public int toX;
        public int fromY;
        public int toY;

        public MoveCommand(int fromX,int fromY, int toX, int toY, Pies pies)
        {
            this.fromX = fromX;
            this.fromY = fromY;
            this.toX = toX;
            this.toY = toY;
            this.movedPies = pies;
        }

        public MoveCommand(int toX, int toY, Pies pies)
        {
            this.fromX = pies.GetPoint().GetX();
            this.fromY = pies.GetPoint().GetY();
            this.toX = toX;
            this.toY = toY;
            this.movedPies = pies;
        }
        
        public MoveCommand(Point to, Pies pies)
        {
            this.fromX = pies.GetPoint().GetX();
            this.fromY = pies.GetPoint().GetY();
            this.toX = to.GetX();
            this.toY = to.GetY();
            this.movedPies = pies;
        }

        public void Execute()
        {
            Board.ClearOptions();
            movedPies.Move(toX,toY);
            Board.Replace(toX,toY,movedPies);
            Board.cells[fromX, fromY] = null;
            Board.Replace(fromX,fromY,new Cell(fromX,fromY));
        }

        public void Cancle()
        {
            Board.ClearOptions();
            movedPies.Move(fromX,fromY);
            Board.Replace(fromX,fromY,movedPies);
            Board.cells[toX, toY] = null;
            Board.Replace(toX,toY,new Cell(toX,toY));
        }
    }

    public class EatCommand : ICommand
    {
        public Pies eaten;
        public Pies eating;
        public MoveCommand move;
        public EatCommand(Pies eating, Pies eaten)
        {
            this.eating = eating;
            this.eaten = eaten;
            this.move = new MoveCommand(eaten.GetPoint().GetX(), eaten.GetPoint().GetY(), eating);
        }

        public void Execute()
        {
            move.Execute();
        }

        public void Cancle()
        {
            this.move.Cancle();
            Board.Replace(eaten.GetPoint().GetX(),eaten.GetPoint().GetY(),eaten);
        }
    }

    public class BackGroundMoveCommand : ICommand
    {
        private Cell owner;
        private Cell target;
        private Point ownerPoint;
        private Point targetPoint;
        
        public BackGroundMoveCommand(Cell owner, Cell target)
        {
            this.owner = owner;
            this.target = target;
        }

        public BackGroundMoveCommand(MoveOption move)
        {
            this.owner = move.GetOwner();
            this.target = move.GetTarget();
            this.ownerPoint = move.GetOwner().GetPoint();
            this.targetPoint = move.GetTarget().GetPoint();
        }
        
        public void Execute()
        {
            Board.cells[target.GetPoint().GetX(), target.GetPoint().GetY()] = owner;
            Board.cells[owner.GetPoint().GetX(), owner.GetPoint().GetY()] = new Cell(target.GetPoint().GetX(), target.GetPoint().GetY());
            owner.SetPoint(targetPoint);
        }
        
        public void Cancle()
        {
            target.SetPoint(targetPoint);
            owner.SetPoint(ownerPoint);
            Board.cells[owner.GetPoint().GetX(), owner.GetPoint().GetY()] = owner;
            Board.cells[target.GetPoint().GetX(), target.GetPoint().GetY()] = target;
        }
    }


}
