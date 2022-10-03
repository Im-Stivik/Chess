using System;

namespace Chess
{
    public abstract class Pies: Cell
    {
        protected int _team;
        public int Team
        {
            get { return _team; }
            set { _team = value; }
        }
        public Pies(int x, int y,int team) : base(x, y)
        {
            this._team = team;
            this.Click += new EventHandler(Pies_Click);
        }
        public abstract void CreateOptions(object sender, EventArgs e);

        private void Pies_Click(object sender, EventArgs e)
        {
            CreateOptions(sender, e);
            this.BackColor = GameSettings.SelectedColor;
            Board.selectedCell = this;
        }
    }
}