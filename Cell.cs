using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Chess
{
    public class Cell : Label
    {
        private int x;
        private int y;
        private ProjectEnums.PieceType pieceType;
        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Width = 50;
            this.Height = 50;
            this.Location = new System.Drawing.Point(x * 50 + GameSettings.BoardMarginLeft, y * 50 + GameSettings.BoardMarginTop);
            if ((x + y) % 2 == 0)
            {
                this.BackColor = GameSettings.LightColor;
            }
            else
            {
                this.BackColor = GameSettings.DarkColor;
            }
            
            this.pieceType = ProjectEnums.PieceType.None;

        }
        
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public ProjectEnums.PieceType PieceType
        {
            get { return pieceType; }
            set { pieceType = value; }
        }
    }
}