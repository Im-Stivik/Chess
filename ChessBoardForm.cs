using System;
using System.Windows.Forms;

namespace Chess
{
    public partial class ChessBoardForm : Form
    {
        public ChessBoardForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Board.Init(this);
        }
    }
}