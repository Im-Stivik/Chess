using System;
using System.Runtime.CompilerServices;

namespace Chess
{
    public class OptionCell: Cell
    {
        private Cell _target;
        public Cell Target
        {
            get { return _target; }
            set { _target = value; }
        }
        public OptionCell(Cell target): base(target.X, target.Y)
        {
            _target = target;
            this.BackColor = GameSettings.OptionsColor;
            this.Image = target.Image;
            this.PieceType = ProjectEnums.PieceType.Option;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
    }
}