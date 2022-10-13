using System.Security.AccessControl;

namespace Chess
{
    public class Point
    {
        private int x;
        private int y;
        
        //constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        //copy constructor
        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
        }
        
        //getters and setters
        public int GetX() { return x;}
        public void SetX(int x){this.x = x;}
        public int GetY(){return y;}
        public void SetY(int y){this.y = y;}
        
        //returns the location in the screen
        public System.Drawing.Point GetLocation()
        {
            return new System.Drawing.Point(x * 50 + GameSettings.BoardMarginLeft,
                y * 50 + GameSettings.BoardMarginTop);
        }

        public override string ToString()
        {
            return "[" + x + ", "+ y + "]";
        }
    }
}